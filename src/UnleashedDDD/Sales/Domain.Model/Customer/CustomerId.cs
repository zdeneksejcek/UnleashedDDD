using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.Customer
{
    public class CustomerId : IdValueObject
    {
        public CustomerId(Guid id) : base(id) { }
    }
}
