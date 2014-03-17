using System;
using OpenDDD;
using UnleashedDDD.Accounting.Application.Model;
using UnleashedDDD.Accounting.Port;

namespace UnleashedDDD.Accounting.Application
{
    public class ConfigurationService : IApplicationService, IConfigurationService
    {
        private readonly IConfigurationRepository _repository;
        private readonly IAccountingProviderFactory _providerFactory;

        public ConfigurationService(IConfigurationRepository repository, IAccountingProviderFactory providerFactory)
        {
            _repository = repository;
            _providerFactory = providerFactory;
        }

        public ConfigurationModel GetCurrentConfiguration()
        {
            var currentConfiguration = _repository.Get();

            throw new NotImplementedException();
        }

        public void SaveConfiguration(ConfigurationModel model)
        {
            
        }

        public void InitializeConfiguration(string providerType)
        {
            var currentConfiguration = _repository.Get();

            throw new NotImplementedException();
        }

    }
}