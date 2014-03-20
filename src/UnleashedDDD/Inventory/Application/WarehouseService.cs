using System;
using OpenDDD;
using OpenDDD.Attributes;
using UnleashedDDD.Inventory.Application.Commands;
using UnleashedDDD.Inventory.Application.Model;
using UnleashedDDD.Inventory.Domain.Model.Product;
using UnleashedDDD.Inventory.Domain.Model.Stock;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;
using UnleashedDDD.Inventory.Port;

namespace UnleashedDDD.Inventory.Application
{
    internal class WarehouseService : IApplicationService
    {
        private readonly IWarehouseRepository _repository;
        private readonly IProductRepository _productRepository;

        public WarehouseService(IWarehouseRepository repository, IProductRepository productRepository)
        {
            _repository = repository;
            _productRepository = productRepository;
        }

        [UnitOfWork]
        public WarehouseModel CreateNewWarehouse(NewWarehouseCommand command)
        {
            var warehouse = new Warehouse(new WarehouseName(command.WarehouseName));
            _repository.Save(warehouse);

            return new WarehouseModel(warehouse);
        }

        [UnitOfWork]
        public void IncreaseStockOnHand(Guid warehouseId, Guid productId, int quantity)
        {
            var warehouse = _repository.GetById(new WarehouseId(warehouseId));
            var product = _productRepository.GetExistingById(new ProductId(productId));

            warehouse.IncreaseStock(
                product.Id, 
                new StockQuantity(quantity));
        }

        [UnitOfWork]
        public void DescreaseStockOnHand(Guid warehouseId, Guid productId, int quantity)
        {
            var warehouse = _repository.GetById(new WarehouseId(warehouseId));

            warehouse.DecreaseStock(
                new ProductId(productId),
                new StockQuantity(quantity));
        }

    }
}