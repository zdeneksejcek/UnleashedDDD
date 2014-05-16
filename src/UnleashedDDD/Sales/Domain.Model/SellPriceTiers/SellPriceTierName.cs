using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SellPriceTiers
{
    public class SellPriceTierName : GenericValueObject<string>
    {
        public SellPriceTierName(string value) : base(value) { }
    }
}
