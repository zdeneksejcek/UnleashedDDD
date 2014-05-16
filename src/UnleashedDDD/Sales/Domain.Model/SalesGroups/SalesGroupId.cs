using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesGroups
{
    public class SalesGroupId : IdValueObject
    {
        public SalesGroupId(Guid id) : base(id) { }
    }
}
