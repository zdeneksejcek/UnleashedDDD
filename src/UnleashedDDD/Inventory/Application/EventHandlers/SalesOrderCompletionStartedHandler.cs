using OpenDDD;
using UnleashedDDD.Sales.Domain.Model.SalesOrder.Events;

namespace UnleashedDDD.Inventory.Application.EventHandlers
{
    public class SalesOrderCompletionStartedHandler : IEventualEventHandler<SalesOrderCompletionStarted>
    {
        public void Handle(SalesOrderCompletionStarted @event)
        {
            
        }
    }
}
