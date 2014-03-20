
using System;

namespace UnleashedDDD.Sales.Application.Commands
{
    public class CompleteSalesOrderCommand
    {
        public Guid SalesOrderId { get; private set; }

        public CompleteSalesOrderCommand(Guid salesOrderId)
        {
            SalesOrderId = salesOrderId;
        }
    }
}
