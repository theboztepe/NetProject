using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private readonly List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Laptop",UnitPrice=10,UnitsInStock=10},
                new Product{ProductId=2,CategoryId=2,ProductName="Mouse",UnitPrice=20,UnitsInStock=20},
                new Product{ProductId=3,CategoryId=3,ProductName="Keyboard",UnitPrice=30,UnitsInStock=30},
                new Product{ProductId=4,CategoryId=4,ProductName="Monitor",UnitPrice=40,UnitsInStock=40},
                new Product{ProductId=5,CategoryId=5,ProductName="Speaker",UnitPrice=50,UnitsInStock=50},
                new Product{ProductId=6,CategoryId=6,ProductName="Headphone",UnitPrice=60,UnitsInStock=60},
                new Product{ProductId=7,CategoryId=7,ProductName="Printer",UnitPrice=70,UnitsInStock=70},
                new Product{ProductId=8,CategoryId=8,ProductName="Scanner",UnitPrice=80,UnitsInStock=80},
                new Product{ProductId=9,CategoryId=9,ProductName="Camera",UnitPrice=90,UnitsInStock=90},
                new Product{ProductId=10,CategoryId=10,ProductName="TV",UnitPrice=100,UnitsInStock=100},
                new Product{ProductId=11,CategoryId=11,ProductName="Mobile",UnitPrice=110,UnitsInStock=110},
                new Product{ProductId=12,CategoryId=12,ProductName="Tablet",UnitPrice=120,UnitsInStock=120}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
