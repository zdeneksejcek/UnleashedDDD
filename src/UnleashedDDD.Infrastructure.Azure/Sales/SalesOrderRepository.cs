using UnleashedDDD.Sales.Domain.Model.SalesOrder;
using UnleashedDDD.Sales.Port;

namespace UnleashedDDD.Infrastructure.Azure.Sales
{
    public class SalesOrderRepository : BaseTableRepository<SerializedEntity>, ISalesOrderRepository
    {
        public SalesOrderRepository(IAzureConfiguration configuration) : base(configuration, "Users") { }

        public SalesOrder GetById(SalesOrderId id)
        {
            
            return null;
        }

        public void Save(SalesOrder order)
        {
            var memento = order.GetMemento();

            base.SaveSerializedEntity(order.Id.Id, memento);
        }
    }
}