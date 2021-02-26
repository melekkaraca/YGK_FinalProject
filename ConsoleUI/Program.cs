using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryId + "-" + category.CategoryName);
            }
            Console.WriteLine(categoryManager.GetById(5).Data.CategoryName);
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal(),new CategoryManager(new EFCategoryDal()));

            //foreach (var product in productManager.GetAll().Data)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //Console.WriteLine();
            //foreach (var product in productManager.GetByUnitPrice(40, 100).Data)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //Console.WriteLine();
            //foreach (var item in productManager.GetProductDetails().Data)
            //{
            //    Console.WriteLine(item.ProductName + "/" + item.CategoryName);
            //}
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
