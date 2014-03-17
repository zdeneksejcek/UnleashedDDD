using OpenDDD;
using UnleashedDDD.Inventory.Domain.Model.Product;

namespace UnleashedDDD.Inventory.Port
{
    public interface IProductRepository : IExternalImplementationRequired
    {
        Product GetById(ProductId id);

        void Save(Product product);
    }
}
