using OpenDDD.Common;

namespace UnleashedDDD.Accounting.Domain.Model.PaymentTerms
{
    public class PaymentTermName : GenericValueObject<string>
    {
        public PaymentTermName(string value) : base(value) { }
    }
}
