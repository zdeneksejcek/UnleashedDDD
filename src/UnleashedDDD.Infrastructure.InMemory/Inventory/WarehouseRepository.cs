using System.Collections.Generic;
using System.Linq;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;
using UnleashedDDD.Inventory.Port;

namespace UnleashedDDD.Infrastructure.InMemory.Inventory
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private List<Warehouse> _list = new List<Warehouse>();

        public void Save(Warehouse warehouse)
        {
            _list.Add(warehouse);
        }

        public Warehouse GetById(WarehouseId id)
        {
            return _list.FirstOrDefault(p => p.Id.Id == id.Id);
        }
    }
}
