using System.Configuration;
using UnleashedDDD.Infrastructure.Azure;

namespace UnleashedApplication
{
    public class AzureConfiguration : IAzureConfiguration
    {
        public string GetStorageConnectionString()
        {
            return ConfigurationManager.AppSettings["StorageConnectionString"];
        }
    }
}
