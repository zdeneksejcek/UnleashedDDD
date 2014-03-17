using UnleashedDDD.Accounting.Application.Model;

namespace UnleashedDDD.Accounting.Application
{
    public interface IConfigurationService
    {
        ConfigurationModel GetCurrentConfiguration();

    }
}
