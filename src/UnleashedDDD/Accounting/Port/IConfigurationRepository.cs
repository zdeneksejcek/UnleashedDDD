using OpenDDD;
using UnleashedDDD.Accounting.Domain.Model.Configuration;

namespace UnleashedDDD.Accounting.Port
{
    public interface IConfigurationRepository : IExternalImplementationRequired
    {
        Configuration Get();

        void Save(Configuration configuration);
    }
}