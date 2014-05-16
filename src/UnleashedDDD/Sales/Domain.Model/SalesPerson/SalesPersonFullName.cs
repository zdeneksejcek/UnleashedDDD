using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesPerson
{
    public class SalesPersonFullName : GenericValueObject<string>
    {
        public SalesPersonFullName(string value) : base(value) { }
    }
}
