using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVCApp.Models
{
    public class ProductRepository
    {
        // Dati statici per simulare il database
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Prodotto A", Price = 10.0m },
            new Product { Id = 2, Name = "Prodotto B", Price = 20.0m },
            new Product { Id = 3, Name = "Prodotto C", Price = 30.0m },
        };

        public IEnumerable<Product> GetAll() => _products;

        public Product GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existing = GetById(product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
            }
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}