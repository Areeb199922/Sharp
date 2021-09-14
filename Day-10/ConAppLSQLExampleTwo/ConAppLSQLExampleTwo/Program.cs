using System;
using System.Collections.Generic;
using System.Linq;
namespace ConAppLSQLExampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsDataDataContext db = new ProductsDataDataContext();
            var pList = db.Products.OrderByDescending(p => p.PName);
            Console.WriteLine("----------------------------Products List------------------------------");
            foreach (Product p in db.Products)//pass here pList in place of db.Products
            {
                Console.WriteLine("ID : "+p.PId);
                Console.WriteLine("Name : "+p.PName);
                Console.WriteLine("Price : "+p.PPrice);
                Console.WriteLine("Manufacturing Date : "+p.PMfDate);
                Console.WriteLine("Expiry Date : "+p.PExDate);
                Console.WriteLine("---------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
