using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Display();
            obj.MyProperty = 125;
            obj.Welcome("Timothy");
            Console.WriteLine("Property Value : {0}",obj.MyProperty);
            Console.ReadKey();
        }
    }
}
