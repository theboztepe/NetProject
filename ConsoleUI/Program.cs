using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ProductTest();
            CategoryTest();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (Product product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine("Ürün=> " + product.ProductId + " - " + product.ProductName);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (Category category in categoryManager.GetAll())
            {
                Console.WriteLine("Kategori=> " + category.CategoryId + " - " + category.CategoryName);
            }
        }
    }
}
