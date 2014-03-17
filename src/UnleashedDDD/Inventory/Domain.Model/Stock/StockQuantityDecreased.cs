using OpenDDD;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;

namespace UnleashedDDD.Inventory.Domain.Model.Stock
{
    public class StockQuantityDecreased : Event
    {
        public WarehouseId Warehouse { get; private set; }

        public Product.ProductId Product { get; private set; }

        public StockQuantity Quantity { get; private set; }

        public StockQuantityDecreased(WarehouseId warehouse, Product.ProductId product, StockQuantity quantity)
        {
            Warehouse = warehouse;
            Product = product;
            Quantity = quantity;
        }
    }
}
