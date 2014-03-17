using OpenDDD;
using OpenDDD.Attributes;
using UnleashedDDD.Accounting.Application.Model;
using UnleashedDDD.Accounting.Port;

namespace UnleashedDDD.Accounting.Application
{
    internal class SalesOrderExportService : IApplicationService
    {
        public IAccountingProviderFactory _providerFactory;
        public IConfigurationRepository _configurationRepository;

        public SalesOrderExportService(
            IAccountingProviderFactory providerFactory,
            IConfigurationRepository configurationRepository)
        {
            _providerFactory = providerFactory;
            _configurationRepository = configurationRepository;
        }

        [UnitOfWork]
        public void Export(SalesOrderExportModel salesOrder)
        {
            
        }
    }
}
