using System;
using OpenDDD;

namespace UnleashedDDD.Inventory.Domain.Model.Product
{
    public class ProductDoesNotExist : DomainException
    {
        public Guid ProductId { get; private set; }

        public ProductDoesNotExist(Guid productId)
        {
            ProductId = productId;
        }
    }
}
