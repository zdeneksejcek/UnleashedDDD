using System.Collections.Generic;
using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.SalesGroups
{
    public class SalesGroups : Aggregate
    {
        private readonly List<SalesGroup> _groups = new List<SalesGroup>();

        public IEnumerable<SalesGroup> Groups { get { return _groups; } }
    }
}