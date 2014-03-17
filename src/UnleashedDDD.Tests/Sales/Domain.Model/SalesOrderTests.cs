using System;
using NUnit.Framework;
using OpenDDD.Common;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;
using UnleashedDDD.Sales.Domain.Model;
using UnleashedDDD.Sales.Domain.Model.Customer;
using UnleashedDDD.Sales.Domain.Model.SalesOrder;
using UnleashedDDD.Sales.Domain.Model.SalesOrder.Exceptions;

namespace UnleashedDDD.Tests.Sales.Domain.Model
{
    [TestFixture]
    public class SalesOrderTests
    {
        private SalesOrder CreateSalesOrder()
        {
            return new SalesOrder(
                new CustomerId(Guid.NewGuid()),
                new WarehouseId(Guid.NewGuid()));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Organization id cannot be null")]
        public void InitializeWithNullOrganization_ExpectException()
        {
            var order = new SalesOrder(null, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Customer id cannot be null")]
        public void InitializeWithNullCustomer_ExpectException()
        {
            var order = new SalesOrder(null, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Warehouse id cannot be null")]
        public void InitializeWithNullWarehouse_ExpectException()
        {
            var order = new SalesOrder(new CustomerId(Guid.NewGuid()), null);
        }

        [Test]
        [ExpectedException(typeof(NoLine))]
        public void StartCompleting_ExpectNoLinesException()
        {
            var order = CreateSalesOrder();

            order.StartCompleting();
        }

        [Test]
        [ExpectedException(typeof(FinishCompletingIsNotAllowedForCurrentState))]
        public void FinishCompleting_ExpectOrderContainsUnallocatedLinesException()
        {
            var order = CreateSalesOrder();
	
            order.FinishCompleting();
        }

        [Test]
        public void GetTotals_ExpectSuccess()
        {
            var order = CreateSalesOrder();

            order.AddLine(
                new ProductId(Guid.Empty),
                new Quantity(2),
                new UnitPrice(100, Currency.NZD),
                new SalesTax(Guid.NewGuid(), 0.15M));

            order.AddLine(
                new ProductId(Guid.Empty),
                new Quantity(5),
                new UnitPrice(100, Currency.NZD),
                new SalesTax(Guid.NewGuid(), 0.15M));

            var totals = order.GetTotals();

            Assert.AreEqual(new MonetaryValue(700, Currency.NZD), totals.SubTotal);
            Assert.AreEqual(new MonetaryValue(105, Currency.NZD), totals.TaxTotal);
            Assert.AreEqual(new MonetaryValue(805, Currency.NZD), totals.Total);
        }


    }
}
