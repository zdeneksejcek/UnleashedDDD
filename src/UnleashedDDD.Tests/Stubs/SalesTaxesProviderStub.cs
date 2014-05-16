using System;
using UnleashedDDD.Sales.Domain.Model;
using UnleashedDDD.Sales.Port;

namespace UnleashedDDD.Tests.Stubs
{
    public class SalesTaxesProviderStub : IProvidesSalesTaxes
    {
        public SalesTax ShouldReturn { get; set; }

        public SalesTax[] GetTaxes()
        {
            throw new NotImplementedException();
        }

        public SalesTax GetTax(Guid id)
        {
            return ShouldReturn;
        }

        public SalesTax[] GetTaxes(string taxFamily)
        {
            throw new NotImplementedException();
        }
    }
}
