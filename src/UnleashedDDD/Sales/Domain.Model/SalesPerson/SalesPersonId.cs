using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesPerson
{
    public class SalesPersonId : IdValueObject
    {
        public SalesPersonId(Guid id) : base(id) { }
    }
}
