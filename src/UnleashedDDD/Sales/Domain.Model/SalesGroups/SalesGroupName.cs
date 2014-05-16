using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesGroups
{
    public class SalesGroupName : GenericValueObject<string>
    {
        public SalesGroupName(string value) : base(value)
        {
        }
    }
}
