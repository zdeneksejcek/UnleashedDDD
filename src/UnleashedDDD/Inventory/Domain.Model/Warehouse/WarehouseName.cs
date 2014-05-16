using OpenDDD.Common;

namespace UnleashedDDD.Inventory.Domain.Model.Warehouse
{
    public class WarehouseName : GenericValueObject<string>
    {
        public string Name { get { return Value; } }

        public WarehouseName(string value) : base(value) { }
    }
}
