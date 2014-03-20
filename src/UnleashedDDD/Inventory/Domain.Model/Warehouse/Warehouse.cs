using System;
using OpenDDD;
using UnleashedDDD.Inventory.Domain.Model.Stock;

namespace UnleashedDDD.Inventory.Domain.Model.Warehouse
{
    public class Warehouse : Aggregate
    {
        public WarehouseId Id { get; private set; }
        public WarehouseName Name { get; set; }

        public Warehouse(WarehouseName name)
        {
            Id = new WarehouseId(Guid.NewGuid());
            Name = name;

            EventDispacher.Raise(new WarehouseCreated());
        }

        public void IncreaseStock(Product.ProductId product, StockQuantity quantity)
        {


            EventDispacher.Raise(new StockQuantityIncreased(
                    Id, product, quantity
                ));
        }

        public void DecreaseStock(Product.ProductId product, StockQuantity quantity)
        {
            EventDispacher.Raise(new StockQuantityDecreased(
                    Id, product, quantity
                ));
        }

        #region restore

        private Warehouse(WarehouseId id, WarehouseName name)
        {
            Id = id;
            Name = name;
        }

        public static Warehouse Restore(WarehouseId id, WarehouseName name)
        {
            return new Warehouse(id, name);
        }

        #endregion
    }
}
