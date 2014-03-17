using System;
using OpenDDD.Common;

namespace UnleashedDDD.Inventory.Domain.Model.Stock
{
    public class StockId : IdValueObject
    {
        public StockId(Guid id) : base(id) { }
    }
}
