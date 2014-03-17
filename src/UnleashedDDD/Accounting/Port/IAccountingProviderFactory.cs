using OpenDDD;

namespace UnleashedDDD.Accounting.Port
{
    public interface IAccountingProviderFactory : IExternalImplementationRequired
    {
        IAccountingProvider GetAccountingProviderByType(string type);

        string[] GetAvailableProviders();
    }
}