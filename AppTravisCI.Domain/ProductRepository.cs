using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTravisCI.Domain
{
    public class ProductRepository
    {
        private readonly List<Product> _context;

        public ProductRepository(List<Product> products)
        {
            _context = products;
        }
        public void AddProduct(Product product)
        {
            _context.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            _context.Remove(product);
        }

        public List<Product> SelectAllProductsBy(Func<Product, bool> preFunc)
        {
            return _context.Where(preFunc).ToList();
        }
        public List<Product> SelectAllProducts()
        {
            return _context.ToList();
        }
    }
}
