using System;
using OpenDDD;
using UnleashedDDD.Sales.Domain.Model;

namespace UnleashedDDD.Sales.Port
{
    public interface IProvidesSalesTaxes : IExternalImplementationRequired
    {
        SalesTax[] GetTaxes();

        SalesTax GetTax(Guid id);

        SalesTax[] GetTaxes(string taxFamily);
    }
}