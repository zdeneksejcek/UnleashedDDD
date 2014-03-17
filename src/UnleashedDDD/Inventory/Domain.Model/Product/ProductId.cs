using System;
using OpenDDD.Common;

namespace UnleashedDDD.Inventory.Domain.Model.Product
{
    public class ProductId : IdValueObject
    {
        public ProductId(Guid id) : base(id) { }
    }
}
