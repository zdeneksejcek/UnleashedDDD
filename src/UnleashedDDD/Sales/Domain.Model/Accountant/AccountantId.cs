using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.Accountant
{
    public class AccountantId : IdValueObject
    {
        public AccountantId(Guid id) : base(id) { }
    }
}