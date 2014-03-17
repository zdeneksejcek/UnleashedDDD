using System;
using OpenDDD;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    public class Line : Entity
    {
        public LineId Id { get; private set; }

        public ProductId Product { get; private set; }

        public Quantity Quantity { get; set; }

        public UnitPrice Price { get; set; }

        public Comment Comment { get; set; }

        public SalesOrderId SalesOrder { get; private set; }

        public SalesTax Tax { get; set; }

        public MonetaryValue LineTax
        {
            get
            {
                return new MonetaryValue(LineTotal.Amount * Tax.Rate, Price.Currency);
            }
        }

        public MonetaryValue LineTotal
        {
            get
            {
                return new MonetaryValue(Price.Amount * Quantity.Value, Price.Currency);
            }
        }

        public LineStatus Status { get; set; }

        internal Line(SalesOrderId salesOrder, ProductId product, Quantity quantity, UnitPrice price, SalesTax tax)
        {
            Id = new LineId(Guid.NewGuid());
            SalesOrder = salesOrder;
            Quantity = quantity;
            Product = product;
            Price = price;
            Tax = tax;
        }

#region restore

        private Line(LineId id)
        {
            Id = id;
        }

        public static Line Restore(Guid id)
        {
            return new Line(new LineId(id));
        }


#endregion

    }
}