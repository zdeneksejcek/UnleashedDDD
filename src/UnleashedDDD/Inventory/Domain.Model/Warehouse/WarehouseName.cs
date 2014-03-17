using OpenDDD.Common;

namespace UnleashedDDD.Inventory.Domain.Model.Warehouse
{
    public class WarehouseName : GenericValueObject<string>
    {
        public string Value { get { return base.Value; } }

        public WarehouseName(string value) : base(value) { }
    }
}
