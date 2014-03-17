using System;
using OpenDDD;
using UnleashedDDD.Sales.Domain.Model;

namespace UnleashedDDD.Inventory.Domain.Model.Stock
{
    public class Stock : Aggregate
    {
        public StockId Id { get; private set; }

        public ProductId Product { get; private set; }

        public Quantity Quantity { get; private set; }

        public Stock(ProductId product)
        {
            Id = new StockId(Guid.NewGuid());
            Product = product;
        }

        public void IncreaseStockBy(Quantity quantity)
        {
            Quantity = new Quantity(Quantity.Value + quantity.Value);
        }

        public void DecreaseStockBy(Quantity quantity)
        {
            Quantity = new Quantity(Quantity.Value - quantity.Value);
        }
    }
}