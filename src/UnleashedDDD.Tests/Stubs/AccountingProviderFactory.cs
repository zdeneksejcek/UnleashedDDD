using UnleashedDDD.Accounting.Port;

namespace UnleashedDDD.Tests.Stubs
{
    public class AccountingProviderFactory : IAccountingProviderFactory
    {
        public IAccountingProvider GetAccountingProviderByType(string type)
        {
            return null;
        }

        public string[] GetAvailableProviders()
        {
            return new string[0];
        }
    }
}
