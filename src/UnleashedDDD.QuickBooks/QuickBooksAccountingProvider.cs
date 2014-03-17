using UnleashedDDD.Accounting.Application.Model;
using UnleashedDDD.Accounting.Port;
using UnleashedDDD.Accounting.Port.Model;

namespace UnleashedDDD.QuickBooks
{
    public class QuickBooksAccountingProvider : IAccountingProvider
    {
        public ProviderTax[] GetTaxes()
        {
            throw new System.NotImplementedException();
        }

        public ProviderAccount[] GetAccounts()
        {
            throw new System.NotImplementedException();
        }

        public void Export(SalesOrderExportModel salesOrder)
        {
            throw new System.NotImplementedException();
        }
    }
}
