using System;
using UnleashedDDD.Sales.Domain.Model.SalesOrder;
using UnleashedDDD.Sales.Port;

namespace UnleashedDDD.Tests.Stubs
{
    public class SalesOrderRepositoryStub : ISalesOrderRepository
    {
        public bool SaveHasBeenCalled { get; private set; }
        public SalesOrder ShouldReturn { get; set; }

        public SalesOrder GetById(SalesOrderId id)
        {
            return ShouldReturn;
        }

        public void Save(SalesOrder order)
        {
            SaveHasBeenCalled = true;
        }
    }
}
