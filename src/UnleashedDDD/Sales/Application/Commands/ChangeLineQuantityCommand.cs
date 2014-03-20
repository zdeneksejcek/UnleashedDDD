using System;

namespace UnleashedDDD.Sales.Application.Commands
{
    public class ChangeLineQuantityCommand
    {
        public Guid SalesOrder { get; private set; }
        public Guid Line { get; private set; }
        public decimal NewQuantity { get; private set; } 

        public ChangeLineQuantityCommand(Guid salesOrder, Guid line, decimal newQuantity)
        {
            SalesOrder = salesOrder;
            Line = line;
            NewQuantity = newQuantity;
        }
    }
}