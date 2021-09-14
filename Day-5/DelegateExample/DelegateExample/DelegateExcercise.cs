using System;
namespace DelegateExample
{

    public delegate double OurDel(double num1, double num2);

    public static  class Calculation
    {
        public static double Sum(double num1, double num2)
        {
            return num1 + num2;  
        }
    }

    public class SimpleCalc
    {
        public double Mul(double num1, double num2)
        {
            return num1 * num2;
        }
    }
    public class DelegateExcercise
    {
        public static void Main()
        {
            
            OurDel obj = new OurDel(Calculation.Sum);
            Console.WriteLine("--------------SUM---------------");
            Console.WriteLine("Enter First Number : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : "); ;
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Sum = "+ obj(a,b));

            Console.WriteLine("\n\n-----------------MULTIPLY---------------------");

            SimpleCalc obj2 = new SimpleCalc();
            OurDel objd = new OurDel(obj2.Mul);
            Console.WriteLine("Enter First Number : ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : "); ;
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Multiplication = "+ objd(c, d));
            Console.ReadKey();
        }
    }
}
