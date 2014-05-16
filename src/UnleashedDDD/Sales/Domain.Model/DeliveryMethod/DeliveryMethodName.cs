using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.DeliveryMethod
{
    public class DeliveryMethodName : GenericValueObject<string>
    {
        public DeliveryMethodName(string value) : base(value) { }
    }
}
