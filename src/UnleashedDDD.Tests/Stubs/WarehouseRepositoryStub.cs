using UnleashedDDD.Inventory.Domain.Model.Warehouse;
using UnleashedDDD.Inventory.Port;

namespace UnleashedDDD.Tests.Stubs
{
    public class WarehouseRepositoryStub : IWarehouseRepository
    {
        public bool SaveMethodCalled { get; private set; }
        public Warehouse ShouldReturn { get; set; }

        public void Save(Warehouse warehouse)
        {
            SaveMethodCalled = true;
        }

        public Warehouse GetById(WarehouseId id)
        {
            return ShouldReturn;
        }
    }
}
