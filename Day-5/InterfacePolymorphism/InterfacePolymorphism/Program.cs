using System;


namespace InterfacePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface1 obj = new OurClass();
            //obj.Display();
            //Interface2 objd = new OurClass();
            //objd.Display();

            OurClass obj = new OurClass();

            Interface1 obi1 = obj; 
            obi1.Display();

            Interface2 obi2 = obj;
            obi2.Display();
            

            Console.ReadKey();
        }
    }
}
