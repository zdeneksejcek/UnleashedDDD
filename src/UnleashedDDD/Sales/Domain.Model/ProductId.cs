using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model
{
    public class ProductId : IdValueObject
    {
        public ProductId(Guid id) : base(id) { }
    }
}