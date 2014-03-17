using OpenDDD.Common;

namespace UnleashedDDD.Inventory.Domain.Model.Product
{
    public class ProductName : GenericValueObject<string>
    {
        public ProductName(string value) : base(value) { }
    }
}
