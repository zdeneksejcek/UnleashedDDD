using UnleashedDDD.Inventory.Domain.Model.Product;
using UnleashedDDD.Inventory.Port;

namespace UnleashedDDD.Tests.Stubs
{
    public class ProductRepositoryStub : IProductRepository
    {
        public Product ShouldReturn { get; set; }
        public bool SaveMethodCalled { get; private set; }

        public Product GetById(ProductId id)
        {
            return ShouldReturn;
        }

        public void Save(Product product)
        {
            SaveMethodCalled = true;
        }
    }
}
