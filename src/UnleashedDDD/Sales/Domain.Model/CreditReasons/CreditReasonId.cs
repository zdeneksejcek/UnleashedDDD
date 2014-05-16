using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.CreditReasons
{
    public class CreditReasonId : IdValueObject
    {
        public CreditReasonId() : base(Guid.NewGuid()) { }

        public CreditReasonId(Guid id) : base(id) { }
    }
}