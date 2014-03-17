using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.Customer
{
    public class Customer : Aggregate
    {
        public CustomerId Id { get; private set; }
    }
}