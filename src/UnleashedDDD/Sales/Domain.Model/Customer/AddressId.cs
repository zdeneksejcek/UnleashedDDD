using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.Customer
{
    public class AddressId : IdValueObject
    {
        public AddressId(Guid id) : base(id) { }
    }
}
