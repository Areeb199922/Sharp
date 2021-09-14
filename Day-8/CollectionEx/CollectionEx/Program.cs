//using System;
//using System.Collections;
//namespace CollectionEx
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {//------------------------------SORTED LIST---------------------------------------//
//     SortedList sortedList = new SortedList
//            {
//                {1,"Raj" },
//                {2,"Mohan" },
//                {12,"Gohan" },
//                {7,"Nitin" }
//            };
//            Console.WriteLine("----------Keys-------------");
//            foreach(var k in sortedList.Keys)
//            {

//                Console.WriteLine(k);
//            }
//            Console.WriteLine("-----------Values-------------");
//            foreach (var v in sortedList.Values)
//            {

//                Console.WriteLine(v);
//            }
//            Console.WriteLine("----------------Index---------------");
//            foreach (var k in sortedList.Keys)
//            {

//                Console.WriteLine(sortedList.IndexOfKey(k));
//            }

//            Console.WriteLine("Index \t Key \t Value");
//            foreach (var e in sortedList.Keys)
//            {
//                Console.WriteLine(sortedList.IndexOfKey(e)+" \t "+e+" \t "+sortedList[e]);
//            }
//            Console.ReadKey();

//        }
//    }
//}

//using System;
//using System.Collections;

//class Program
//{
//    public static void Main()
//    {

//        //----------------------------STACK--------------------------------//
//        Stack stack = new Stack();
//        stack.Push("Anil");
//        //stack.Push(1);
//        stack.Push("Rohan");
//        stack.Push("Sam");

//        Console.WriteLine("Number of Names in stack are : "+stack.Count);
//        Console.WriteLine("Top Element in stack : "+stack.Peek());//To see the last inserted element

//        Console.WriteLine("\n\nValues stored inside stack printing using enumerator");

//        IEnumerator enumerator = stack.GetEnumerator();
//        while (enumerator.MoveNext())
//        {
//            Console.WriteLine(enumerator.Current);
//        }

//        Console.WriteLine("Number of Names in stack are : " + stack.Count);

//        Console.WriteLine("------------Using Foreach Loop with string n----------------");
//        foreach (string n in stack)
//        {
//            Console.WriteLine(n);
//        }
//        Console.WriteLine("\n\n");
//        int noe = stack.Count;

//        for (int i =0;i<noe;i++) 
//        {
//            Console.WriteLine(stack.Pop());
//        }
//        Console.WriteLine("Number of Names in stack are : " + stack.Count);


//        Console.ReadKey();

//        //Queue queue = new Queue();
//        //queue.Enqueue();
//        //queue.Dequeue();
//    }
//}

//using System;
//using System.Collections;
//namespace CollectionEx
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            Queue queue = new Queue();
//            string name;
//            string choice = "n";
//            Console.WriteLine("Enter Names");
//            do
//            {
//                name = Console.ReadLine();
//                queue.Enqueue(name);
//                Console.WriteLine("To insert next press 'Y'");
//                choice = Console.ReadLine().ToLower();
//            } while (choice == "y");

//            foreach (var e in queue)
//            {
//                Console.WriteLine(e);
//            }

//            Console.ReadKey();
//        }
//    }
//}


using System;
using System.Collections;
namespace CollectionEx
{
    public class Program
    {
        public static void Main()
        {
            Queue queue = new Queue();
            Queue myqueue = new Queue();
            queue.Enqueue("Sam");
            queue.Enqueue("Raj");
            queue.Enqueue("Arati");
            queue.Enqueue("Amit");
            queue.Enqueue("Roz");
            queue.Enqueue("Zoya");
            queue.Enqueue("Meena");


            
            string choice = "n";
            do
            {
                Console.WriteLine("Select Operation:\n1. Name List\n2. Remove Name From List\n3. Add Name in List");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("List of names present in Queue are ");
                            foreach (var e in queue)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Name To be Removed");
                            string name = Console.ReadLine();

                            foreach (string e in queue)
                            {
                                if (e != name)
                                {
                                    myqueue.Enqueue(e);
                                }

                            }
                            queue = myqueue;
                            Console.WriteLine("List of names present in Queue after deletion ");
                            foreach (var e in queue)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Write a name to enter into queue");
                            string newname = Console.ReadLine();

                            if (queue.Contains(newname))
                            {
                                Console.WriteLine("Name Already Exist");

                            }
                            else
                            {
                                queue.Enqueue(newname);
                                Console.WriteLine("List of names present in Queue after adding new name ");
                                foreach (var e in queue)
                                {
                                    Console.WriteLine(e);
                                }
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Entry");
                            break;
                        }
                }
                Console.WriteLine("Continue Press Y");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
            Console.ReadKey();

        }
    }
}