//using System;
//namespace DelegateExample
//{
//    public delegate void OurDel(string n);
//    class Program
//    {
//        public static void Display(string mName)
//        {
//            Console.WriteLine("Display of "+mName+" Mobile");
//        }
//        static void Main(string[] args)
//        {
//            //OurDel obj = new OurDel(Display);
//            //obj("One Plus Nord");
//            Bank bank = new Bank();
//            OurDel objd = new OurDel(bank.Welcome);
//            objd("Sam");
//            Console.ReadKey();
//        }
//    }
//}
