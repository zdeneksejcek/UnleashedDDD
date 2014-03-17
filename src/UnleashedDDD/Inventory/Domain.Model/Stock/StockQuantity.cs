using OpenDDD.Common;

namespace UnleashedDDD.Inventory.Domain.Model.Stock
{
    public class StockQuantity : GenericValueObject<decimal>
    {
        public new decimal Value { get { return base.Value; } }

        public StockQuantity(decimal value) : base(value)
        {
            if (value < 0)
                throw new NegativeStockQuantityNotAllowed();
        }
    }
}
