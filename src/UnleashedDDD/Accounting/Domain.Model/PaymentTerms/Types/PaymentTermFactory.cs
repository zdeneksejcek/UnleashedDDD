namespace UnleashedDDD.Accounting.Domain.Model.PaymentTerms.Types
{
    public class PaymentTermFactory
    {
        public static IPaymentTermType GetPaymentTerm(PaymentTermTypes type)
        {
            switch (type)
            {
                case PaymentTermTypes.DaysAfter: return new DaysAfterPaymentTermType();
                case PaymentTermTypes.DaysFollowingEndOfFollowingMonth: return new DaysFollowingEndOfFollowingMonthPaymentTermType();
            }

            return null;
        }
    }
}
