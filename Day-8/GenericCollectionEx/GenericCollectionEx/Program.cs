//using System;
//using System.Collections;
//using System.Collections.Generic;
//namespace GenericCollectionEx
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//ArrayList alist = new ArrayList
//{
//    1,
//    13,
//    "Areeb",
//    'c'
//};
//Console.WriteLine("ARRAY LIST");
//foreach (var n in alist)
//{
//    Console.WriteLine(n);
//}

//---------------------------GENERIC LIST----------------------------------------------------------//
//List<int> numList = new List<int>()
//{ 12,13,14,15,21};
//Console.WriteLine("GENERIC NUMBER LIST");
//foreach (var n in numList)
//{
//    Console.WriteLine(n);
//}



//List<string> nameList = new List<string>()
//{ "Sam","Tim","John","Kol",13.ToString()};
//Console.WriteLine("GENERIC NAME LIST");
//foreach (var n in nameList)
//{
//    Console.WriteLine(n);
//}


//nameList.Sort();
//Console.WriteLine("GENERIC NAME LIST AFTER SORTING");
//foreach (var n in nameList)
//{
//    Console.WriteLine(n);
//}


//nameList.Reverse();
//Console.WriteLine("GENERIC NAME LIST AFTER REVERSE");
//foreach (var n in nameList)
//{
//    Console.WriteLine(n);
//}


//nameList.Clear();
//Console.WriteLine("GENERIC NAME LIST AFTER CLEAR");
//foreach (var n in nameList)
//{
//    Console.WriteLine(n);
//}

//Console.ReadKey();


//----------------------------------------------------------DICTIONARY----------------------------------------------------//
//Dictionary<int, string> objD = new Dictionary<int, string>()
//{
//    { 1,"Sam"},
//    { 2,"Raj"},
//    { 5,"Rohan"},
//    { 4,"Sohan"},
//    { 3,"Mohan"}
//};

//Console.WriteLine("DICTIONARY");
//foreach (var k in objD.Keys)
//{
//    Console.WriteLine(k + " \t " + objD[k]);
//}




////-------------------------------------------------------------SORTED LIST------------------------------- ---------------------------//
//SortedList<int, string> slist = new SortedList<int, string>()
//{
//    { 1,"Sam"},
//    { 2,"Raj"},
//    { 5,"Rohan"},
//    { 4,"Sohan"},
//    { 3,"Mohan"}
//};
//Console.WriteLine("SORTED LIST");
//foreach (var k in slist.Keys)
//{
//    Console.WriteLine(k+" \t "+slist[k]);

//}

//Console.ReadKey();



//---------------------------------------------------stack GENERIC COLLECTION-----------------------------------------------------//
//Stack<int> stack = new Stack<int>();
//stack.Push(12);
//stack.Push(3);

//foreach (var e in stack)
//{
//    Console.WriteLine(e);
//}
//Console.WriteLine("Number Of Items : "+stack.Count);
//Console.WriteLine("Peek : "+stack.Peek());
//Console.WriteLine("Count after PEEK : "+stack.Count);
//Console.WriteLine("Pop : "+stack.Pop());
//Console.WriteLine("Count after pop : "+stack.Count);

//Console.WriteLine("\n\n\nSTRING stack");
//            Console.WriteLine("------------------------------GENERIC STACK----------------------------------------------");
//            Stack<string> stack2 = new Stack<string>();
//            stack2.Push("Sam");
//            stack2.Push("Tim");
//            stack2.Push("John");
//            stack2.Push("Timothy");

//            foreach (var e in stack2)
//            {
//                Console.WriteLine(e);
//            }
//            Console.WriteLine("Number Of Items : " + stack2.Count);
//            Console.WriteLine("Peek : " + stack2.Peek());
//            Console.WriteLine("Count after PEEK : " + stack2.Count);
//            Console.WriteLine("Pop : " + stack2.Pop());
//            Console.WriteLine("Count after pop : " + stack2.Count);



//            //-----------------------------------------------------GENERIC QUEUE--------------------------------------------------------//


//            Console.WriteLine("\n\n\n---------------------------------STRING GENERIC QUEUE--------------------------------------------");

//            Queue<string> queue2 = new Queue<string>();
//            queue2.Enqueue("Sam");
//            queue2.Enqueue("Tim");
//            queue2.Enqueue("John");
//            queue2.Enqueue("Timothy");

//            foreach (var e in queue2)
//            {
//                Console.WriteLine(e);
//            }
//            Console.WriteLine("Number Of Items : " + queue2.Count);
//            Console.WriteLine("Peek : " + queue2.Peek());
//            Console.WriteLine("Count after PEEK : " + queue2.Count);
//            Console.WriteLine("Pop : " + queue2.Dequeue());
//            Console.WriteLine("Count after pop : " + queue2.Count);



//            Console.ReadKey();

//        }
//    }
//}


