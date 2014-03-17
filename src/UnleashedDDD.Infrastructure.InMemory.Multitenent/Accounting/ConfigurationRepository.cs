using System.Collections.Generic;
using System.Linq;
using UnleashedDDD.Accounting.Domain.Model.Configuration;
using UnleashedDDD.Accounting.Port;

namespace UnleashedDDD.Infrastructure.InMemory.Multitenent.Accounting
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private IOrganizationContextFactory _contextFactory;

        private List<Configuration> _list = new List<Configuration>();

        public ConfigurationRepository(IOrganizationContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public Configuration Get()
        {
            var context = _contextFactory.GetContext();

            return _list.FirstOrDefault();
        }

        public void Save(Configuration configuration)
        {
            _list.Add(configuration);
        }
    }
}
