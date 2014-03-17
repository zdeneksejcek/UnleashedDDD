using System;
using OpenDDD.Common;

namespace UnleashedDDD.Inventory.Domain.Model.Warehouse
{
    public class WarehouseId : IdValueObject
    {
        public WarehouseId(Guid id) : base(id) { }
    }
}