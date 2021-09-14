using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism
{
    public class OurClass : Interface1, Interface2
    {
        void Interface1.Display()
        {
            Console.WriteLine("I am Interface 1 Display");
        }

        void Interface2.Display()
        {
            Console.WriteLine("Hi, This is Interface 2 Display");
        }
    }
}
