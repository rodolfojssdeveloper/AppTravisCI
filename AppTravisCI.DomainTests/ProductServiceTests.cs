using NUnit.Framework;
using AppTravisCI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTravisCI.Domain.Tests
{
    [TestFixture()]
    public class ProductServiceTests
    {
        private List<Product> _products;
        private ProductRepository _repository;
        private ProductService _service;

        public ProductServiceTests()
        {
            _products = new List<Product>();
            _repository = new ProductRepository(_products);
            _service = new ProductService(_repository);
        }

      
        [Test]
        public void Storage()
        {
            Product p01 = new Product("Caneta", 10);
            _service.StorageProduct(p01);

            Assert.AreEqual(2, _service.SelecProduct().Count);
        }
        [Test]
        public void DiscardProductTest()
        {
            Product p01 = new Product("Caneta", 10);
            _service.DiscardProduct(p01);
            Assert.AreEqual(0, _service.SelecProduct().Count);
        }
    }
}