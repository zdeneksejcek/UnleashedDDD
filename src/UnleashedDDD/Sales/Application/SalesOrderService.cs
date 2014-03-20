using System;
using OpenDDD;
using OpenDDD.Attributes;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;
using UnleashedDDD.Sales.Application.Commands;
using UnleashedDDD.Sales.Application.Exceptions;
using UnleashedDDD.Sales.Application.Model;
using UnleashedDDD.Sales.Domain.Model;
using UnleashedDDD.Sales.Domain.Model.Customer;
using UnleashedDDD.Sales.Domain.Model.SalesOrder;
using UnleashedDDD.Sales.Port;

namespace UnleashedDDD.Sales.Application
{
    internal class SalesOrderService : IApplicationService
    {
        private readonly ISalesOrderRepository _repository;
        private readonly IProvidesSalesTaxes _salesTaxProvider;

        public SalesOrderService(ISalesOrderRepository repository, IProvidesSalesTaxes salesTaxProvider)
        {
            _repository = repository;
            _salesTaxProvider = salesTaxProvider;
        }

        [UnitOfWork]
        public NewSalesOrderModel CreateNewSalesOrder(NewSalesOrderCommand command)
        {
            var order = new SalesOrder(
                new CustomerId(command.CustomerId),
                new WarehouseId(command.WarehouseId));

            _repository.Save(order);
            
            return new NewSalesOrderModel(order.Id.Id, order.Customer.Id, order.Warehouse.Id);
        }

        [UnitOfWork]
        public Line AddLine(NewSalesOrderLineCommand command)
        {
            var order = GetExistingSalesOrder(command.SalesOrder);
            var salesTax = _salesTaxProvider.GetTax(command.SalesTax);

            var line = order.Lines.Add(
                new ProductId(command.Product),
                new Quantity(command.Quantity),
                new UnitPrice(command.Price.Amount, command.Price.Currency),
                salesTax);

            _repository.Save(order);
            
            return line;
        }

        [UnitOfWork]
        public void RemoveLine(RemoveSalesOrderLineCommand command)
        {
            var order = GetExistingSalesOrder(command.SalesOrder);

            var line = order.Lines.Get(new LineId(command.Line));
            order.Lines.Remove(line);

            _repository.Save(order);
        }

        [UnitOfWork]
        public void ChangeSalesOrderLineQuantity(ChangeLineQuantityCommand command)
        {
            var order = GetExistingSalesOrder(command.SalesOrder);

            var line =  order.Lines.Get(new LineId(command.Line));

            line.Quantity = new Quantity(command.NewQuantity);

            _repository.Save(order);
        }

        [UnitOfWork]
        public void Complete(CompleteSalesOrderCommand command)
        {
            var order = GetExistingSalesOrder(command.SalesOrderId);

            order.StartCompleting();

            _repository.Save(order);
        }

        private SalesOrder GetExistingSalesOrder(Guid salesOrder)
        {
            var order = _repository.GetById(new SalesOrderId(salesOrder));

            if (order == null)
                throw new OrderDoesNotExist();

            return order;
        }

    }
}