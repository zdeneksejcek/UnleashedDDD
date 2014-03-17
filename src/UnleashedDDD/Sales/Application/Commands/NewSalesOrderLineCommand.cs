using System;
using OpenDDD.Common;
using UnleashedDDD.Sales.Domain.Model;

namespace UnleashedDDD.Sales.Application.Commands
{
    public class NewSalesOrderLineCommand
    {
        public Guid SalesOrder { get; private set; }
        public Guid Product { get; private set; }
        public int Quantity { get; private set; }
        public MonetaryValue Price { get; private set; }
        public Guid SalesTax { get; private set; }

        public NewSalesOrderLineCommand(Guid salesOrder, Guid product, int quantity, MonetaryValue price, Guid salesTax)
        {
            SalesOrder = salesOrder;
            Product = product;
            Quantity = quantity;
            Price = price;
            SalesTax = salesTax;
        }
    }
}