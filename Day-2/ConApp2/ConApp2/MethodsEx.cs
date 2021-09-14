using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp2
{
    
    public class Calculation
    {
        public void display(string fname, string lname)
        {
            Console.WriteLine("Welcome To Methods!!!! "+ fname +" "+lname);
        }

        public static void display2()
        {
            Console.WriteLine("This is a static method");
        }

        public static int addint(int a, int b)
        {
            return a + b;
        }
    }
    
    
    class MethodsEx
    {
        public static void Main()
        {
            Calculation obj = new Calculation();
            obj.display(lname : "Areeb",fname : "Ansari");
            Calculation.display2();
            //int c = Calculation.addint(5, 5);
            Console.WriteLine(Calculation.addint(5, 5));
            Console.ReadKey();
         }
    }
}
