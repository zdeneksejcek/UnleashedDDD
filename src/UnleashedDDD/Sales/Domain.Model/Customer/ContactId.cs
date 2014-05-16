using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.Customer
{
    public class ContactId : IdValueObject
    {
        public ContactId(Guid id) : base(id) { }
    }
}