using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    public class LineId : IdValueObject
    {
        public LineId() : base(Guid.NewGuid()) { }

        public LineId(Guid id) : base(id) { }
    }
}