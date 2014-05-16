using OpenDDD;

namespace UnleashedDDD.Accounting.Domain.Model.Tax
{
    public abstract class Tax : Aggregate
    {
        public TaxId Id { get; private set; }
    }
}