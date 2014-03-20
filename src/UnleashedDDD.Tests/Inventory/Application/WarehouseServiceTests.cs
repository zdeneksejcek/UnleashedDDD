
using System;
using NUnit.Framework;
using UnleashedDDD.Inventory.Application;
using UnleashedDDD.Inventory.Application.Commands;
using UnleashedDDD.Inventory.Domain.Model.Warehouse;
using UnleashedDDD.Tests.Stubs;

namespace UnleashedDDD.Tests.Inventory.Application
{
    [TestFixture]
    public class WarehouseServiceTests : TestBase
    {
        private WarehouseService Service { get; set; }
        private WarehouseRepositoryStub Repository { get; set; }

        private ProductRepositoryStub ProductRepository { get; set; }

        [SetUp]
        public void Setup()
        {
            Repository = new WarehouseRepositoryStub();
            ProductRepository = new ProductRepositoryStub();
            Service = new WarehouseService(Repository, ProductRepository);
        }

        [Test]
        public void CreateWarehouse_Success()
        {
            var model = Service.CreateNewWarehouse(new NewWarehouseCommand("warehouse A"));

            Assert.IsTrue(Repository.SaveMethodCalled);
        }

        [Test]
        public void IncreaseStockOnHand_Success()
        {
            var warehouseId = new WarehouseId(Guid.NewGuid());
            var warehouseName = new WarehouseName("warehouse A");
            Repository.ShouldReturn = Warehouse.Restore(warehouseId, warehouseName);

            //Service.IncreaseStockOnHand()
        }

    }
}
