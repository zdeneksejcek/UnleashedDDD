using System;
using OpenDDD;
using UnleashedDDD.Sales.Domain.Model.SalesOrder.Events;

namespace UnleashedDDD
{
    class TestingImmdediateHandler : IImmediateEventHandler<SalesOrderCompleted>
    {
        public void Handle(SalesOrderCompleted @event)
        {
            throw new NotImplementedException();
        }
    }
}
