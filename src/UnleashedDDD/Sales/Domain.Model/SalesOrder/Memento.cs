using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    [Serializable]
    public class Memento
    {
        public Guid SalesOrderId { get; private set; }

        public string Status { get; private set; }

        public Guid CustomerId { get; private set; }

        public Guid WarehouseId { get; private set; }

        public Line[] Lines { get; private set; }

        public Memento(Guid salesOrderId, string status, Guid customerId, Guid warehouseId, Line[] lines)
        {
            SalesOrderId = salesOrderId;
            Status = status;
            CustomerId = customerId;
            WarehouseId = warehouseId;
            Lines = lines;
        }

        [Serializable]
        public class Tax
        {
            public Guid Id { get; private set; }

            public decimal Rate { get; private set; }

            public Tax(Guid id, decimal rate)
            {
                Id = id;
                Rate = rate;
            }
        }

        [Serializable]
        public class Line
        {
            public Guid LineId { get; private set; }

            public Guid ProductId { get; private set; }

            public MonetaryValue UnitPrice { get; private set; }

            public Tax Tax { get; private set; }

            public Line(Guid lineId, Guid productId, MonetaryValue unitPrice, Tax tax)
            {
                LineId = lineId;
                ProductId = productId;
                UnitPrice = unitPrice;
                Tax = tax;
            }
        }

    }
}