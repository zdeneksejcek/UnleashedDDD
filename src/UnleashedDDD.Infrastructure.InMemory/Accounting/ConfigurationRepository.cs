using UnleashedDDD.Accounting.Domain.Model.Configuration;
using UnleashedDDD.Accounting.Port;

namespace UnleashedDDD.Infrastructure.InMemory.Accounting
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private Configuration _configuration = null;

        public Configuration Get()
        {
            return _configuration;
        }

        public void Save(Configuration configuration)
        {
            _configuration = configuration;
        }
    }
}
