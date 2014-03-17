using System;
using System.Linq;
using NUnit.Framework;
using OpenDDD.Common;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;
using UnleashedDDD.Sales.Application;
using UnleashedDDD.Sales.Application.Commands;
using UnleashedDDD.Sales.Domain.Model;
using UnleashedDDD.Sales.Domain.Model.Customer;
using UnleashedDDD.Sales.Domain.Model.SalesOrder;
using UnleashedDDD.Tests.Stubs;

namespace UnleashedDDD.Tests.Sales.Application
{
    [TestFixture]
    public class SalesOrderServiceTests
    {
        private SalesOrder CreateSalesOrder()
        {
            return new SalesOrder(
                new CustomerId(Guid.NewGuid()),
                new WarehouseId(Guid.NewGuid()));
        }

        private Line AddLine(SalesOrder order)
        {
            return order.AddLine(
                new ProductId(Guid.NewGuid()), 5,
                new UnitPrice(5, Currency.NZD), new SalesTax(Guid.NewGuid(), 0.15M));
        }

        [Test]
        public void CreateNewSalesOrder_Success()
        {
            var repository = new SalesOrderRepositoryStub();
            var salesTaxProvider = new SalesTaxesProviderStub();

            var service = new SalesOrderService(repository, salesTaxProvider);

            service.CreateNewSalesOrder(new NewSalesOrderCommand(Guid.NewGuid(), Guid.NewGuid()));

            Assert.IsTrue(repository.SaveHasBeenCalled);
        }

        [Test]
        public void AddLine_Success()
        {
            var repository = new SalesOrderRepositoryStub {
                ShouldReturn = CreateSalesOrder()
            };
            var salesTaxProvider = new SalesTaxesProviderStub();

            var service = new SalesOrderService(repository, salesTaxProvider);

            var command = new NewSalesOrderLineCommand(
                repository.ShouldReturn.Id.Id,
                Guid.NewGuid(),
                5,
                new MonetaryValue(5, Currency.NZD),
                Guid.NewGuid());

            service.AddLine(command);

            Assert.IsTrue(repository.SaveHasBeenCalled);
            Assert.AreEqual(1, repository.ShouldReturn.Lines.Count());
        }

        [Test]
        public void RemoveLine_Success()
        {
            // arrange
            var order = CreateSalesOrder();

            var line = AddLine(order);

            var repository = new SalesOrderRepositoryStub { ShouldReturn = order };
            var salesTaxProvider = new SalesTaxesProviderStub();

            var service = new SalesOrderService(repository, salesTaxProvider);
            
            // act
            service.RemoveLine(new RemoveSalesOrderLineCommand(order.Id.Id, line.Id.Id));

            // assert
            Assert.IsTrue(repository.SaveHasBeenCalled);
            Assert.AreEqual(0, repository.ShouldReturn.Lines.Count());
        }

        [Test]
        public void Complete_Success() {
            // arrange
            var order = CreateSalesOrder();
            AddLine(order);

            var repository = new SalesOrderRepositoryStub { ShouldReturn = order };
            var salesTaxProvider = new SalesTaxesProviderStub();

            var service = new SalesOrderService(repository, salesTaxProvider);

            // act
            service.Complete(order.Id);

            // assert
            Assert.IsTrue(repository.SaveHasBeenCalled);
        }
    }
}
