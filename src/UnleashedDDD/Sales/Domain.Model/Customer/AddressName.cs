using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.Customer
{
    public class AddressName : GenericValueObject<string>
    {
        public AddressName(string value) : base(value) { }
    }
}