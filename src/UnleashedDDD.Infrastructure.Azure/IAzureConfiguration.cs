namespace UnleashedDDD.Infrastructure.Azure
{
    public interface IAzureConfiguration
    {
        string GetStorageConnectionString();
    }
}
