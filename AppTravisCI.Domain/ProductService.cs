using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTravisCI.Domain
{
    public class ProductService
    {
        private readonly ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;

        }


        public void StorageProduct(Product product)
        {
            _repository.AddProduct(product);
        }

        public void DiscardProduct(Product product)
        {
            _repository.RemoveProduct(product);
        }
        public List<Product> SelecProduct(Func<Product, bool> func)
        {
            return _repository.SelectAllProductsBy(func).ToList();
        }
        public List<Product> SelecProduct()
        {
            return _repository.SelectAllProducts();
        }


    }
}
