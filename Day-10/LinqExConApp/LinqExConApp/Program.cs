//using System;
//using System.Linq;
//namespace LinqExConApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {//---------------------------LINQ WITH ARRAY--------------------------------//
//            string[] studNames = new string[] { "Raj", "Freya", "Amit", "Zoya", "Sam", "Neha", "Esha" };
//            //-----------------------QUERY SYNTAX----------------------------
//            //var QueryResult = from qvar in collection where condition
//            var eNames = from names in studNames where names.Contains('e') select names;
//            Console.WriteLine("QUERY SYNTAX OUTPUT");
//            foreach (var n in eNames)
//            {
//                Console.WriteLine(n);
//            }

//            //---------------------------METHOD SYNTAX----------------------------
//            var sStudents = studNames.Where(n => n.Contains('e'));
//            Console.WriteLine("METHOD SYNTAX OUTPUT");
//            foreach (var p in sStudents)
//            {
//                Console.WriteLine(p);
//            }
//            Console.ReadKey();
//        }
//    }
//}


using System;
using System.Linq;
namespace LinqExConApp
{
    class Program
    {
        static void Main(string[] args)
        {//---------------------------LINQ WITH ARRAY--------------------------------//
            int[] numbers = new int[] { 12, 25, 60, 90, 4, 88, 9, 10, 34,5,7,11,19,13 };
            var oddNums = from nums in numbers orderby nums descending where nums % 2 != 0 select nums;
            Console.WriteLine("Odd numbers in array are");
            foreach (var n in oddNums)
            {
                Console.WriteLine(n);
            }
            //var evenNums = numbers.Where(n=>n%2==0);
            var evenNums = numbers.Where(n => n % 2 == 0).OrderByDescending(n=>n);
            Console.WriteLine("Even Numbers in array are");
            foreach (var n in evenNums)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}

