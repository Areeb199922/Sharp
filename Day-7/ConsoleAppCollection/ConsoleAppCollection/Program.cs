using System;
using System.Collections;
namespace ConsoleAppCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList;
            //Hashtable hashTable;
            //SortedList sortedList;
            //Queue queue;
            //Stack stack;


            //ArrayList objList = new ArrayList();
            //objList.Add("Sam");
            //objList.Add(12);
            //objList.Add('C');
            //objList.Add(12.34f);

            //Console.WriteLine("Array List Stored!!!");
            //Console.WriteLine("No. of items in array list are : "+objList.Count);
            //Console.WriteLine("Capacity of array list is : "+objList.Capacity);
            //foreach (var item in objList)
            //{
            //    Console.WriteLine(item);
            //}
            //objList.Add("Tim");
            //objList.Add("Pam");
            //objList.Add("Reyna");
            //objList.Add("Nancy");
            //objList.Add("Demon");

            //Console.WriteLine("No. of items in array list are : " + objList.Count);
            //Console.WriteLine("Capacity of array list is : " + objList.Capacity);
            //Console.WriteLine("Array list after adding 4 more element");
            //foreach (var item in objList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            ArrayList nameList = new ArrayList
           {
               "Amit",
               "Ravi",
               "Sumit",
               "Tim",
               "Pam"
           };
            Console.WriteLine("Name List");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            nameList.Sort();
            Console.WriteLine("Name List order by Name Asc");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            nameList.Reverse();
            Console.WriteLine("Reversed List");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            nameList.Remove("Ravi");
            Console.WriteLine("After Removing Ravi");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            nameList.RemoveAt(1);
            Console.WriteLine("After removing index 1");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }
    }
}
