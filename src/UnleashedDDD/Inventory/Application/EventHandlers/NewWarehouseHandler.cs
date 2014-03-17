using OpenDDD;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;

namespace UnleashedDDD.Inventory.Application.EventHandlers
{
    public class NewWarehouseHandler : IEventualEventHandler<WarehouseCreated>
    {
        public void Handle(WarehouseCreated @event)
        {
            
        }
    }
}
