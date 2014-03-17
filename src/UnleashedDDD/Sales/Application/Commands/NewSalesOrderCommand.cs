using System;

namespace UnleashedDDD.Sales.Application.Commands
{
    public class NewSalesOrderCommand
    {
        public Guid CustomerId { get; private set; }
        public Guid WarehouseId { get; private set; }

        public NewSalesOrderCommand(Guid customerId, Guid warehouseId)
        {
            CustomerId = customerId;
            WarehouseId = warehouseId;
        }
    }
}