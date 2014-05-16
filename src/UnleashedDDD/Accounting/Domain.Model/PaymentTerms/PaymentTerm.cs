using OpenDDD;

namespace UnleashedDDD.Accounting.Domain.Model.PaymentTerms
{
    public class PaymentTerm : Entity
    {
        public PaymentTermId Id { get; private set; }

        public PaymentTermName Name { get; private set; }

        public PaymentTerm(PaymentTermName name)
        {
            Id = new PaymentTermId();
            Name = name;
        }
    }
}