using OpenDDD.Common;

namespace UnleashedDDD.Accounting.Domain.Model.PaymentTerms.Types
{
    public interface IPaymentTermType
    {
        DateTimeUtc CalculateDueDate(DateTimeUtc date, int days);
    }
}
