using System;
using OpenDDD.Common;

namespace UnleashedDDD.Accounting.Domain.Model.PaymentTerms
{
    public class PaymentTermId : IdValueObject
    {
        public PaymentTermId() : base(new Guid()) { }

        public PaymentTermId(Guid id) : base(id) { }
    }
}
