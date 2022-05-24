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
            //CategoryTest();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetAll();
            if (result.Success)
            {
                foreach (Product product in result.Data)
                {
                    Console.WriteLine("Ürün=> " + product.ProductId + " - " + product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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
