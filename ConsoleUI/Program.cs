using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();


        }

        //private static void CategoryTest()
        //{
        //    CategoryManager cm = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in cm.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    ProductManager pm = new ProductManager(new EfProductDal());

        //    var result = pm.GetProductDetails();

        //    if (result.Success)
        //    {
        //        foreach (var product in result.Data)
        //        {
        //            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }

            
        //}
    }
}
