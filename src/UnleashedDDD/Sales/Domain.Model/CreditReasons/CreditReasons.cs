using System.Collections.Generic;
using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.CreditReasons
{
    public class CreditReasons : Aggregate
    {
        private readonly List<CreditReason> _reasons = new List<CreditReason>();

        public IEnumerable<CreditReason> Reasons { get { return _reasons; } }
    }
}