//using System;
//namespace MulticastDelegate
//{
    
//    public class Program
//    {
//        public delegate void OurDel(double n1, double n2);//we can add it in namespace or in class
//        public static void Main(string[] args)
//        {

//            BasicCal basic = new BasicCal();
//            OurDel del = new OurDel(basic.Add);
//            Console.WriteLine("Calling delegate after adding one method in invocation list");
//            del(12.45, 45.67);

//            del += new OurDel(basic.Sub);
//            del += new OurDel(basic.Multi);
//            del += new OurDel(basic.Add);
//            Console.WriteLine("\n\n----- After adding four methods and 2 adds -----");
//            del(20.68, 10.24);

//            Console.WriteLine("\n\nAdding 5 methods");
//            del += new OurDel(AdvanceCalc.Average);
//            del(20.68, 10.24);

//            Console.WriteLine("\n\nRemoving Multi method from invocation list");
//            del -= new OurDel(basic.Multi);
//            del(1, 2);


//            Console.WriteLine("\n\nRemoving one Add method from invocation list");
//            del -= new OurDel(basic.Add);
//            del(1, 2);
//            Console.ReadKey();
//        }
//    }
//}
