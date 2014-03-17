using OpenDDD;
using UnleashedDDD.Sales.Domain.Model.SalesOrder;

namespace UnleashedDDD.Sales.Port
{
    public interface ISalesOrderRepository : IExternalImplementationRequired
    {
        SalesOrder GetById(SalesOrderId id);

        void Save(SalesOrder order);
    }
}