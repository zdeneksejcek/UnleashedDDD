using OpenDDD.Common;

namespace UnleashedDDD.Accounting.Domain.Model.PaymentTerms.Types
{
    public class DaysAfterPaymentTermType : IPaymentTermType
    {
        public DateTimeUtc CalculateDueDate(DateTimeUtc date, int days)
        {
            return new DateTimeUtc(date.Value.AddDays(days));
        }
    }
}
