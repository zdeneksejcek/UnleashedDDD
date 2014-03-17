using OpenDDD;
using UnleashedDDD.Sales.Domain.Model.SalesOrder.Events;

namespace UnleashedDDD.Sales.Application.EventHandlers.SalesOrder
{
    public class SalesOrderCompletionHandler : IEventualEventHandler<SalesOrderCompletionStarted>
    {
        public void Handle(SalesOrderCompletionStarted @event)
        {
            
        }
    }
}