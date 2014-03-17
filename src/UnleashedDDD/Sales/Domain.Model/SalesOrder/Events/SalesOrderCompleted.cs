using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder.Events
{
    public class SalesOrderCompleted : Event
    {
        public SalesOrderId SalesOrder { get; private set; }

        public SalesOrderCompleted(SalesOrderId salesOrder)
        {
            SalesOrder = salesOrder;
        }
    }
}