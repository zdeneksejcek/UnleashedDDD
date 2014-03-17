﻿using System.Collections.Generic;
using System.Linq;
using UnleashedDDD.Inventory.Domain.Model.Product;
using UnleashedDDD.Inventory.Port;

namespace UnleashedDDD.Infrastructure.InMemory.Multitenent.Inventory
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _list = new List<Product>();

        public Product GetById(ProductId id)
        {
            return _list.FirstOrDefault(p => p.Id.Id == id.Id);
        }

        public void Save(Product product)
        {
            _list.Add(product);
        }
    }
}