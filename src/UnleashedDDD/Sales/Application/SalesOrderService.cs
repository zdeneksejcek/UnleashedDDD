using OpenDDD;
using OpenDDD.Attributes;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;
using UnleashedDDD.Sales.Application.Commands;
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
            var order = _repository.GetById(new SalesOrderId(command.SalesOrder));
            var salesTax = _salesTaxProvider.GetTax(command.SalesTax);

            var line = order.AddLine(
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
            var order = _repository.GetById(new SalesOrderId(command.SalesOrder));
            var line = order.Lines.GetLine(new LineId(command.Line));
                
            order.Lines.RemoveLine(line);
            _repository.Save(order);
        }

        [UnitOfWork]
        public void Complete(SalesOrderId salesOrder)
        {
            var order = _repository.GetById(salesOrder);
            order.StartCompleting();

            _repository.Save(order);
        }
    }
}