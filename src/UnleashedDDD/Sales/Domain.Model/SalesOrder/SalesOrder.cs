using System;
using System.Linq;
using OpenDDD;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;
using UnleashedDDD.Sales.Domain.Model.Customer;
using UnleashedDDD.Sales.Domain.Model.SalesOrder.Events;
using UnleashedDDD.Sales.Domain.Model.SalesOrder.Exceptions;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    public class SalesOrder : Aggregate
    {
        public SalesOrderId Id { get; private set; }

        public Status Status { get; private set; }

        public CustomerId Customer {get; private set; }
        public WarehouseId Warehouse { get; set; }

        private readonly Lines _lines;
        public Lines Lines { get { return _lines; }}

        public SalesOrder(CustomerId customer, WarehouseId warehouse)
        {
            AssertArgumentNotNull(customer, "Customer id cannot be null");
            AssertArgumentNotNull(warehouse, "Warehouse id cannot be null");

            Id = new SalesOrderId(Guid.NewGuid());
            Customer = customer;
            Warehouse = warehouse;
            _lines = new Lines(Id);

            EventDispacher.Raise(new SalesOrderCreated(Id));
        }

        public Line AddLine(ProductId product, Quantity quantity, UnitPrice price, SalesTax tax)
        {
            AssureStateChangeIsAllowed();

            return _lines.AddLine(product, quantity, price, tax);
        }

        public void RemoveLine(Line line)
        {
            _lines.RemoveLine(line);
        }

        public Totals GetTotals()
        {
            return new Totals(_lines);
        }

        private void AssureStateChangeIsAllowed()
        {
            if (Status != Status.Opened)
                throw new StatusDoesNotAllowChangingState(Id, Status);
        }

        public void StartCompleting()
        {
            AssureContainsLines();

            Status = Status.Completing;

            EventDispacher.Raise(new SalesOrderCompletionStarted(this.Id.Id));
        }

        public void FinishCompleting()
        {
            AssureOrderIsCompleting();
            AssureAllLinesAllocated();

            Status = Status.Completed;

            EventDispacher.Raise(
                new SalesOrderCompleted(Id));
        }

        private void AssureOrderIsCompleting()
        {
            if (Status != Status.Completing)
                throw new FinishCompletingIsNotAllowedForCurrentState();
        }

        private void AssureAllLinesAllocated()
        {
            var containsUnallocatedLine = _lines.Any(p => p.Status != LineStatus.Allocated);

            if (containsUnallocatedLine)
                throw new OrderContainsUnallocatedLines();
        }

        private void AssureContainsLines()
        {
            if (!_lines.Any())
                throw new NoLine();
        }

#region restore
        private SalesOrder(SalesOrderId id)
        {
            Id = id;
        }

        public static SalesOrder Restore(Guid id)
        {
            return new SalesOrder(new SalesOrderId(id));
        }

#endregion

    }
}