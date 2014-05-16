using System.Collections.Generic;
using OpenDDD;

namespace UnleashedDDD.Accounting.Domain.Model.PaymentTerms
{
    public class PaymentTerms : Aggregate
    {
        private readonly List<PaymentTerm> _terms = new List<PaymentTerm>();

        public IEnumerable<PaymentTerm> Terms { get { return _terms; } }
    }
}