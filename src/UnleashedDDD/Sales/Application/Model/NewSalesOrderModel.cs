using System;

namespace UnleashedDDD.Sales.Application.Model
{
    public class NewSalesOrderModel
    {
        public Guid SalesOrderId { get; private set; }

        public Guid CustomerId { get; private set; }
        public Guid WarehouseId { get; private set; }

        public NewSalesOrderModel(Guid salesOrderId, Guid customerId, Guid warehouseId)
        {
            SalesOrderId = salesOrderId;
            CustomerId = customerId;
            WarehouseId = warehouseId;
        }
    }
}
