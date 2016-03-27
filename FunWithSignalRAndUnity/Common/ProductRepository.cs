using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FunWithSignalRAndUnity.Models;

namespace FunWithSignalRAndUnity.Common
{
    public class ProductRepository : IProductRepository
    {
        private static readonly List<Product> Products;

        static ProductRepository()
        {
            Products = new List<Product>
            {
                new Product { Id = 1, Description = "Product 1" },
                new Product { Id = 2, Description = "Product 2" },
                new Product { Id = 3, Description = "Product 3" }
            };
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public Product GetById(int id)
        {
            return Products.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}