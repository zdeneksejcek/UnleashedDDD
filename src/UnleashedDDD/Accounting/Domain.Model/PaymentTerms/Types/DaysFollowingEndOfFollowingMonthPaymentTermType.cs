using System;
using OpenDDD.Common;

namespace UnleashedDDD.Accounting.Domain.Model.PaymentTerms.Types
{
    public class DaysFollowingEndOfFollowingMonthPaymentTermType : IPaymentTermType
    {
        public DateTimeUtc CalculateDueDate(DateTimeUtc date, int days)
        {
            var resultDate = new DateTime(date.Value.Year, date.Value.Month, 1, 0, 0, 0, DateTimeKind.Utc)
                        .AddMonths(2)
                        .AddDays(days);

            return new DateTimeUtc(resultDate);
        }
    }
}
