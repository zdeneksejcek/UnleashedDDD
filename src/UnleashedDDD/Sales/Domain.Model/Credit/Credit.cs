using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.Credit
{
    public class Credit : Aggregate
    {
        public CreditId Id { get; private set; }
    }
}
