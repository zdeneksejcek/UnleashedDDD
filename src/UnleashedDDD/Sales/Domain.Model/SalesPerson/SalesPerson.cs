using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.SalesPerson
{
    public class SalesPerson : Entity
    {
        public SalesPersonId Id { get; private set; }

        public SalesPersonFullName FullName { get; private set; }

        public SalesPersonEmail Email { get; private set; }
    }
}