using System;
using OpenDDD.Common;

namespace UnleashedDDD.Accounting.Domain.Model.Tax
{
    public class TaxId : IdValueObject
    {
        public TaxId() : base(new Guid()) { }

        public TaxId(Guid id) : base(id) { }
    }
}