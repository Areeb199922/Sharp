using System;
using System.Collections.Generic;
namespace GenCollection
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Mdate { get; set; }
        public string Edate { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<Product> obj = new List<Product>()
            {
                new Product{ ID =1,Name = "Product1",Price =123,Mdate = "12/12/2017",Edate = "12/12/2022"},
                new Product{ ID =2,Name = "Product2",Price =99,Mdate = "12/12/2017",Edate = "12/12/2022"},
                new Product{ ID =3,Name = "Product3",Price =77,Mdate = "12/12/2017",Edate = "12/12/2022"},
                new Product{ ID =4,Name = "Product4",Price =150,Mdate = "12/12/2017",Edate = "12/12/2022"},
                new Product{ ID =5,Name = "Product5",Price =199,Mdate = "12/12/2017",Edate = "12/12/2022"},
            };
            string choice = "n";
            do
            {
                Console.WriteLine("Choose Operation");
                Console.WriteLine("\n1. Show List\n2. Add Product");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\nID\tName\t\tPrice\tMfDate\t\tExpDate");
                            foreach (Product p in obj)
                            {
                                Console.Write(p.ID);
                                Console.Write("\t" + p.Name);
                                Console.Write("\t" + p.Price);
                                Console.Write("\t" + p.Mdate);
                                Console.WriteLine("\t" + p.Edate);
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Enter Product ID : ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Product Name : ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Price : ");
                            double price = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Manufacturing Date in dd/mm/yyyy format with slashes as well");
                            string mdate = Console.ReadLine();
                            Console.WriteLine("Enter Expiry Date in dd/mm/yyyy format with slashes as well");
                            string edate = Console.ReadLine();
                            obj.Add(new Product { ID = id, Name = name, Price = price, Mdate = mdate, Edate = edate });
                            //Console.Clear();
                            Console.WriteLine("After Adding New Product");
                            Console.WriteLine("ID\tName\t\tPrice\tMfDate\t\tExpDate");
                            foreach (Product p in obj)
                            {
                                Console.Write(p.ID);
                                Console.Write("\t" + p.Name);
                                Console.Write("\t" + p.Price);
                                Console.Write("\t" + p.Mdate);
                                Console.WriteLine("\t" + p.Edate);
                            }
                            Console.WriteLine("\n\nTotal Number Of Products = " + obj.Count);

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Entry");
                            break;
                        }
                }
                Console.WriteLine("\n\nTo Continue Press Y...........");
                choice = Console.ReadLine().ToLower();
                //Console.Clear();
            } while (choice == "y");
            Console.ReadKey();

        }
    }
}