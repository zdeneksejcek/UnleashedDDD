using System;
using UnleashedDDD.Sales.Domain.Model;
using UnleashedDDD.Sales.Port;

namespace UnleashedDDD.Infrastructure.InMemory.Multitenent.Accounting
{
    public class SalesTaxesProvider : IProvidesSalesTaxes
    {
        public SalesTax[] GetTaxes()
        {
            return new SalesTax[0];
        }

        public SalesTax GetTax(Guid id)
        {
            return null;
        }
    }
}
