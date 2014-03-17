using UnleashedDDD.Accounting.Application.Model;
using UnleashedDDD.Accounting.Port.Model;

namespace UnleashedDDD.Accounting.Port
{
    public interface IAccountingProvider
    {
        ProviderTax[] GetTaxes();

        ProviderAccount[] GetAccounts();

        void Export(SalesOrderExportModel salesOrder);
    }
}