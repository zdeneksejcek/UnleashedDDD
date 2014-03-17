using OpenDDD;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder.Exceptions
{
    public class MultipleCurrenciesNotSupported : DomainException
    {
        public SalesOrderId SalesOrder { get; private set; }
        public Currency UnsupportedCurrency { get; private set; }

        public MultipleCurrenciesNotSupported(SalesOrderId salesOrder, Currency unsupportedCurrency)
        {
            SalesOrder = salesOrder;
            UnsupportedCurrency = unsupportedCurrency;
        }
    }
}
