using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class Exercise3D3
    {
        public static void Main()
        {
            Customer obj = new Customer(1,"Areeb","areeb@gmail.com");
            Console.WriteLine("Initial Details\n");
            obj.Display();
            obj.Update();
            Console.ReadKey();
        }
    }
}
