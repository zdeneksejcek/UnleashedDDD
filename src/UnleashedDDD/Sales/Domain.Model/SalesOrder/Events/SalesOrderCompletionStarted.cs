using System;
using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder.Events
{
    public class SalesOrderCompletionStarted : Event
    {
        public Guid SalesOrderId { get; private set; }

        public SalesOrderCompletionStarted(Guid salesOrderId)
        {
            SalesOrderId = salesOrderId;
        }
    }
}
