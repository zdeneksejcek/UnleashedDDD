using System;
using System.Linq;
using OpenDDD;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;
using UnleashedDDD.Sales.Domain.Model.Customer;
using UnleashedDDD.Sales.Domain.Model.SalesOrder.Events;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    [Serializable]
    public class SalesOrder : Aggregate
    {
        public SalesOrderId Id { get; private set; }

        private Status _status;
        public Status Status { get { return _status; } private set { _status = value; }}

        public CustomerId Customer {get; private set; }

        private WarehouseId _warehouse;
        public WarehouseId Warehouse
        {
            get { return _warehouse; }
            set
            {
                Status.AssureChangeToOrderIsAllowed();
                _warehouse = value;
            }
        }

        public Lines Lines { get; private set; }

        internal SalesOrder(CustomerId customer, WarehouseId warehouse)
        {
            AssertArgumentNotNull(customer, "Customer id cannot be null");
            AssertArgumentNotNull(warehouse, "Warehouse id cannot be null");

            Id = new SalesOrderId(Guid.NewGuid());
            Customer = customer;
            _warehouse = warehouse;
            
            Status = Status.CreateOpened();
            Lines = new Lines(Id, ref _status);

            EventDispacher.Raise(new SalesOrderCreated(Id));
        }

        public SalesOrder(Memento memento)
        {
            Id = new SalesOrderId(memento.SalesOrderId);
            Status = Status.FromString(memento.Status);
            Customer = new CustomerId(memento.CustomerId);
            Warehouse = new WarehouseId(memento.WarehouseId);
        }

        public Memento GetMemento()
        {
            return new Memento(Id.Id, Status.Value.ToString(), Customer.Id, Warehouse.Id, new Memento.Line[0]);
        }

        public Totals CalculateTotals()
        {
            return new Totals(Lines);
        }

        public void StartCompleting()
        {
            Lines.AssureContainsAnyLines();
            Status = Status.ChangeTo(Status.StatusEnum.Completing);

            EventDispacher.Raise(BuildSalesOrderCompletionStartedEvent());
        }

        private SalesOrderCompletionStarted BuildSalesOrderCompletionStartedEvent()
        {
            var lines = Lines.Select(p => new SalesOrderCompletionStarted.LineWithProductAndQuantity(p.Id.Id, p.Product.Id,p.Quantity.Value)).ToArray();

            return new SalesOrderCompletionStarted(Id.Id, lines);
        }

        public void FinishCompleting()
        {
            Status = Status.ChangeTo(Status.StatusEnum.Completed);
            Lines.AssureAllLinesAllocated();

            EventDispacher.Raise(new SalesOrderCompleted(Id));
        }
    }
}