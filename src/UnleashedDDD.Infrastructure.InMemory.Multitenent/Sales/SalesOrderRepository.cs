using System.Collections.Generic;
using System.Linq;
using UnleashedDDD.Sales.Domain.Model.SalesOrder;
using UnleashedDDD.Sales.Port;

namespace UnleashedDDD.Infrastructure.InMemory.Multitenent.Sales
{
    public class SalesOrderRepository : ISalesOrderRepository
    {
        private List<SalesOrder> _list = new List<SalesOrder>(); 

        public SalesOrder GetById(SalesOrderId id)
        {
            return _list.FirstOrDefault(p => p.Id.Id == id.Id);
        }

        public void Save(SalesOrder order)
        {
            _list.Add(order);
        }
    }
}