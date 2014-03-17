using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    public class UnitPrice : MonetaryValue
    {
        public UnitPrice(decimal amount, Currency currency) : base(amount, currency)
        {

        }
    }
}