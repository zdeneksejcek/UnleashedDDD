using OpenDDD;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;

namespace UnleashedDDD.Inventory.Port
{
    public interface IWarehouseRepository : IExternalImplementationRequired
    {
        void Save(Warehouse warehouse);
        Warehouse GetById(WarehouseId id);
    }
}
