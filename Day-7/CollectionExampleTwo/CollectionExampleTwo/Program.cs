//using System;
//using System.Collections;
//namespace CollectionExampleTwo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ArrayList listEmp = new ArrayList
//            {
//                new Emp{ ID =1,Name = "Sam",DOJ = new DateTime(day:12,month:02,year:2018),Salary = 86000.90},//AUTO IMPLEMENTED PROPERTY
//                new Emp{ ID =2,Name = "Tim",DOJ = new DateTime(day:12,month:12,year:2012),Salary = 96000.90},
//                new Emp{ ID =3,Name = "John",DOJ = new DateTime(day:12,month:09,year:2020),Salary = 96000.90},
//                new Emp{ ID =4,Name = "Kol",DOJ = new DateTime(day:23,month:08,year:2019),Salary = 78000.90},
//                new Emp{ ID =5,Name = "Stefan",DOJ = new DateTime(day:10,month:10,year:2017),Salary = 48000.90}
//            };
//            Console.WriteLine("Employees List");
//            foreach (Emp e in listEmp)
//            {
//                Console.WriteLine("------------------------------------------------");
//                Console.WriteLine("ID :"+e.ID);
//                Console.WriteLine("Name :"+e.Name);
//                Console.WriteLine("Salary : "+e.Salary);
//                Console.WriteLine("DOJ : "+e.DOJ.ToShortDateString());
//                Console.WriteLine("------------------------------------------------");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//----------------------HASHTABLE------------------------------------//
using System;
using System.Collections;
namespace CollectionExampleTwo
{
    public class OurTest
    {
        public static void Main()
        {

            Hashtable objht = new Hashtable
            {
                { 1,"Sam"},
                { 7,"Rohan"},
                { 3,"Sohan"},
                { 'a', "Mohan"},
                { 9,14}
            };
            Console.WriteLine("Keys");
            foreach (var k in objht.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Values");
            foreach(var v in objht.Values)
            {

                Console.WriteLine(v);
            }
            Console.WriteLine("Key \t Value\n-----------------");
            foreach(var k in objht.Keys)
            {
                Console.WriteLine(k+" \t "+objht[k]);
            }
            Console.WriteLine("\nEnter key to find out value : ");
            int nkey = int.Parse(Console.ReadLine());
            if (objht.ContainsKey(nkey))
            {
                Console.WriteLine(objht[nkey]);
                objht.Remove(nkey);
                Console.WriteLine("One record has been deleted");
                Console.WriteLine("Key \t Value\n-----------------");
                foreach (var k in objht.Keys)
                {
                    Console.WriteLine(k + " \t " + objht[k]);
                }
            }
            else 
            {
                Console.WriteLine("No such key exist");
            }

            
            Console.ReadKey();

        }
    }
}
