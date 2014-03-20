using UnleashedDDD.Accounting.Domain.Model.Configuration;
using UnleashedDDD.Accounting.Port;

namespace UnleashedDDD.Tests.Stubs
{
    public class ConfigurationRepositoryStub : IConfigurationRepository
    {
        public Configuration ShouldReturn { get; set; }

        public Configuration Get()
        {
            return ShouldReturn;
        }

        public void Save(Configuration configuration)
        {
            ShouldReturn = configuration;
        }
    }
}
