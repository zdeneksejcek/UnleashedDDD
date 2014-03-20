using OpenDDD;
using UnleashedDDD.Sales.Domain.Model.SalesOrder;
using UnleashedDDD.Sales.Domain.Model.SalesOrder.Events;
using UnleashedDDD.Sales.Port;

namespace UnleashedDDD.Sales.Application.EventHandlers.SalesOrder
{
    public class SalesOrderCompletionHandler : IEventualEventHandler<SalesOrderCompletionStarted>
    {
        private ISalesOrderRepository _repository;

        public SalesOrderCompletionHandler(ISalesOrderRepository repository)
        {
            _repository = repository;
        }

        public void Handle(SalesOrderCompletionStarted @event)
        {
            var order = _repository.GetById(new SalesOrderId(@event.SalesOrderId));
        }
    }
}