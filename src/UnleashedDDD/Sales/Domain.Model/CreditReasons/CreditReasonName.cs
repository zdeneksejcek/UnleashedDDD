using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.CreditReasons
{
    public class CreditReasonName : GenericValueObject<string>
    {
        public CreditReasonName(string value) : base(value) { }
    }
}