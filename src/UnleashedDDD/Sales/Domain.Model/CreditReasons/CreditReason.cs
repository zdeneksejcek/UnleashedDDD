using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.CreditReasons
{
    public class CreditReason : Entity
    {
        public CreditReasonId Id { get; private set; }

        public CreditReasonName Name { get; private set; }

        public CreditReason(CreditReasonName name)
        {
            Id = new CreditReasonId();
            Name = name;
        }
    }
}