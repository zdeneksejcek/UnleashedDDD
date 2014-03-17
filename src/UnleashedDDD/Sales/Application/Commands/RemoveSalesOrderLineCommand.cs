using System;

namespace UnleashedDDD.Sales.Application.Commands
{
    public class RemoveSalesOrderLineCommand
    {
        public Guid SalesOrder { get; private set; }
        public Guid Line { get; private set; }

        public RemoveSalesOrderLineCommand(Guid salesOrder, Guid line)
        {
            SalesOrder = salesOrder;
            Line = line;
        }
    }
}