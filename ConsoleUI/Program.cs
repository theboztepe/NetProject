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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (Product product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductId + " - " + product.ProductName);
            }
        }
    }
}
