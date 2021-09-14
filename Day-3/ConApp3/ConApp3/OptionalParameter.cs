using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp3
{
    //--------------------Optional Parameter----------------//
    //-----------Optional Parameter Must be at the end of the parameter list ------------------//
    public class OurCalc
    {
        public static void Display(string name, string city = "Delhi")
        {
            Console.WriteLine("Welcome to OurCalc {0} \nDetails as follows \nName : {0}\nCity : {1}", name, city);
        }
        public double Add(double num1, double num2, double num3 = 8, double num4 = 9.987)
        {
            double res = num1 + num2 + num3 + num4;
            return res;
        }
    }
    public class OptionalParameter
    {
        public static void Main()
        {
            OurCalc.Display("Tim");
            OurCalc objc = new OurCalc();
            Console.WriteLine(objc.Add(2, 3, 4, 5));
            Console.ReadKey();

        }
    }
}
