using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    public class SalesOrderId : IdValueObject
    {
        public SalesOrderId(Guid id) : base(id) { }
    }
}