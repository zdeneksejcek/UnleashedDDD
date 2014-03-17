namespace UnleashedDDD.Inventory.Application.Commands
{
    public class NewWarehouseCommand
    {
        public string WarehouseName { get; private set; }

        public NewWarehouseCommand(string warehouseName)
        {
            WarehouseName = warehouseName;
        }
    }
}
