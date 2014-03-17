using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder.Events
{
    public class SalesOrderCreated : Event
    {
        public SalesOrderId Id { get; private set; }

        public SalesOrderCreated(SalesOrderId id)
        {
            Id = id;
        }
    }
}