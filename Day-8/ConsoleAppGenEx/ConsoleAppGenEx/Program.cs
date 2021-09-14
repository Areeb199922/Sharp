//using System;
//namespace ConsoleAppGenEx
//{
//    public class OurGen<T>//T = Type parameter,we can have more than 1 of it
//    {
//        T field1;
//        public OurGen(T param)
//        {
//            field1 = param;
//        }

//        public void Display()
//        {
//            Console.WriteLine("Value of Field : "+field1);
//            Console.WriteLine("DataType of Field : "+field1.GetType());
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            OurGen<int> obji = new OurGen<int>(12);
//            OurGen<char> objc = new OurGen<char>('c');
//            OurGen<string> objs = new OurGen<string>("Welcome");
//            obji.Display();
//            Console.WriteLine("\n-------------------");
//            objs.Display();
//            Console.WriteLine("\n-------------------");
//            objc.Display();
//            Console.ReadKey();
//        }
//    }
//}


//using System;
//namespace ConsoleAppGenEx
//{
//    public class OurGen<T,U>//T = Type parameter,we can have more than 1 of it
//    {
//        T field1;
//        U field2;

//        public OurGen(T p1, U p2)
//        {
//            field1 = p1;
//            field2 = p2;
//        }

//        public OurGen()
//        {
//            Console.WriteLine("Default Constructor");
//        }
//        public T PropOne { set { field1 = value; } }
//        public U PropTwo { set { field2 = value; } }
//        public void Display()
//        {
//            Console.WriteLine("Value1 \t DataType \t Value2 \t DataType");
//            Console.WriteLine(field1+" \t "+field1.GetType()+" \t "+field2+" \t "+field2.GetType());
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            OurGen<int, string> obj = new OurGen<int, string>();
//            Console.Write("Enter Integer Value :");
//            obj.PropOne = int.Parse(Console.ReadLine());
//            Console.Write("Enter String Value : ");
//            obj.PropTwo = Console.ReadLine();
//            Console.WriteLine("\n------------------------\n");
//            obj.Display();

//            Console.ReadKey();
//        }
//    }
//}


using System;
namespace ConsoleAppGenEx
{
    public class OurGen<T, U>
    {
        T field1;
        U field2;

        public void SetValues(T p1,U p2)
        {
            field1 = p1;
            field2 = p2;
        }
        public void Display()
        {
            Console.WriteLine("Value1 \t DataType \t Value2 \t DataType");
            Console.WriteLine(field1 + " \t " + field1.GetType() + " \t " + field2 + " \t " + field2.GetType());
        }
    }

    public class Program
    {
        public static void Main()
        {
            OurGen<int, string> obj = new OurGen<int, string>();
            Console.WriteLine("Enter Integer Value : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter String Value : ");
            string b = Console.ReadLine();
            obj.SetValues(a, b);
            obj.Display();
            dynamic d;
            Console.WriteLine("Enter Value");
            d = Console.ReadLine();
            Console.WriteLine(d);
            
            Console.ReadKey();
        }
    }
}

