using UnleashedDDD.Inventory.Application.Commands;
using UnleashedDDD.Inventory.Application.Model;

namespace UnleashedDDD.Inventory
{
    public class InventoryFacade
    {
        private OpenDDD.Core Core { get; set; }

        public InventoryFacade(OpenDDD.Core core)
        {
            Core = core;
        }

        public WarehouseModel CreateNewWarehouse(NewWarehouseCommand command)
        {
            return Core.ExecuteWithResult<NewWarehouseCommand, WarehouseModel>(command);
        }
    }
}