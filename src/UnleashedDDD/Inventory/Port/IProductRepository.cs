using OpenDDD;
using UnleashedDDD.Inventory.Domain.Model.Product;

namespace UnleashedDDD.Inventory.Port
{
    public interface IProductRepository : IExternalImplementationRequired
    {
        Product GetExistingById(ProductId id);

        void Save(Product product);
    }
}
