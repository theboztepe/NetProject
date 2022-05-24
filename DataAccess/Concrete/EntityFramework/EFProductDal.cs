using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product { ProductId = 100, CategoryId = 100, ProductName = "A", UnitPrice = 1000, UnitsInStock = 1000 },
                new Product { ProductId = 200, CategoryId = 200, ProductName = "B", UnitPrice = 2000, UnitsInStock = 2000 }
            };
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
