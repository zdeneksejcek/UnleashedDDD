using System;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;

namespace UnleashedDDD.Inventory.Application.Model
{
    public class WarehouseModel
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public WarehouseModel(Warehouse warehouse)
        {
            Id = warehouse.Id.Id;
            Name = warehouse.Name.Name;
        }
    }
}