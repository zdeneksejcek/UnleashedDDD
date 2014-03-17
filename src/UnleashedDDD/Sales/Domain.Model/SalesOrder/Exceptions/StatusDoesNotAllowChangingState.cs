using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder.Exceptions
{
    public class StatusDoesNotAllowChangingState : DomainException
    {
        public Status Status { get; private set; }

        public SalesOrderId SalesOrder { get; private set; }

        public StatusDoesNotAllowChangingState(SalesOrderId salesOrder, Status currentStatus)
        {
            SalesOrder = salesOrder;
            Status = currentStatus;
        }
    }
}
