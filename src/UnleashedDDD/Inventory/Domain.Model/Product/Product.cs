using OpenDDD;

namespace UnleashedDDD.Inventory.Domain.Model.Product
{
    public class Product : Aggregate
    {
        public ProductId Id { get; private set; }

        public ProductName Name { get; private set; }

        public Product(ProductName name)
        {
            Name = name;
        }
    }
}