using System;
using OpenDDD;
using UnleashedDDD.Accounting.Port;
using UnleashedDDD.QuickBooks;
using UnleashedDDD.Xero;

namespace UnleashedDDD.Main
{
    public class AccountingProviderFactory : IAccountingProviderFactory
    {
        private ITypeInstantiator _instantiator;

        public AccountingProviderFactory(ITypeInstantiator instantiator)
        {
            _instantiator = instantiator;
        }

        public IAccountingProvider GetAccountingProviderByType(string type)
        {
            switch (type)
            {
                case "Xero":
                    return _instantiator.Instantiate<XeroAccountingProvider>();

                case "QuickBooks":
                    return _instantiator.Instantiate<QuickBooksAccountingProvider>();
            }

            throw new AccountingProviderNotFound();
        }

        public string[] GetAvailableProviders()
        {
            return new[] {"QuickBooks","Xero"};
        }

        public class AccountingProviderNotFound : Exception {}
    }
}
