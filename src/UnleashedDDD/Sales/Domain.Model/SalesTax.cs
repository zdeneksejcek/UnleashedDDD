using System;
using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model
{
    public class SalesTax : IValueObject
    {
        public Guid Id { get; private set; }

        public decimal Rate { get; private set; }

        public SalesTax(Guid taxId, decimal rate)
        {
            Id = taxId;
            Rate = rate;
        }
    }
}