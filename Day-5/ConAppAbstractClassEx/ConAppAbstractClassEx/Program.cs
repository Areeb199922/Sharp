using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAbstractClassEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MyAbstract obj = new MyAbstract();// we cannot do this
            MyClass obj = new MyClass();
            obj.Display();
            Console.WriteLine(obj.Welcome("Sam"));
            Console.ReadKey();
        }
    }
}
