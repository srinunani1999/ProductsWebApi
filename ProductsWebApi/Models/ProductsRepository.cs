using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsWebApi.Models
{
    public class ProductsRepository
    {
        static List<Product> products = new List<Product>();
        static ProductsRepository()
        {
            products.Add(new Product { Id = 101, Name = "Asus i5", Description = "8gb Ram", Price = 50000 }
                );
            products.Add(new Product { Id = 102, Name = "MSI i5", Description = "8gb Ram", Price = 60000 });

        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }
        public Product Get(int id)
        {
            return products.Find(p => p.Id == id);
        }
    }
}
