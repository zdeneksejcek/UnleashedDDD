using UnleashedDDD.Accounting.Application;
using UnleashedDDD.Accounting.Application.Model;
using UnleashedDDD.Accounting.Port;
using UnleashedDDD.Accounting.Port.Model;

namespace UnleashedDDD.Xero
{
    public class XeroAccountingProvider : IAccountingProvider
    {
        private IConfigurationService _service;
        
        public XeroAccountingProvider(IConfigurationService configurationService)
        {
            _service = configurationService;
        }

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