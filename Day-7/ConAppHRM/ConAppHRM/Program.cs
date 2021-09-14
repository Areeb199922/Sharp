using System;
using EmpLib;
namespace ConAppHRM
{
    public static class OurClass
    {
        public static void Welcome(this Emp ob)
        {
            Console.WriteLine("Extension Says : Welcome to our Organisation "+ob.Name);
        }

        public static double BonusCalc(this Emp emp, double bonus)
        {
            double empBonus = emp.Salary * bonus;
            return empBonus;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
           
            emp.Register();
            //emp.Welcome(emp.Name);
            emp.Welcome();
            emp.Display();
            Console.WriteLine("Enter Bonus Percentage for the year : ");
            double bp = double.Parse(Console.ReadLine())/100;
            Console.WriteLine("Bonus = "+ emp.BonusCalc(bp)); 
            Console.ReadKey();
        }
    }
}
