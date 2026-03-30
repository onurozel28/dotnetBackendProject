// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

public class Program
{
    private static void Main(string[] args)
    {
        ProductTest();
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //foreach(var category in categoryManager.GetAll()) 
        //{
        //    Console.WriteLine(category.CategoryName);
        //}
        var category2 = categoryManager.GetById(3);   
        Console.WriteLine(category2.Data);
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

        //foreach (var product in productManager.GetAll())
        //{
        //    Console.WriteLine(product.ProductName);
        //}

        //foreach (var product in productManager.GetAllByCategoryId(2))
        //{
        //    Console.WriteLine(product.ProductName);
        //}
        //foreach (var product in productManager.GetByUnitPrice(40, 100))
        //{
        //    Console.WriteLine(product.ProductName + "-" + product.UnitPrice);
        //}
        var result = productManager.GetProductDetails();

        if(result.Success==true)
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

