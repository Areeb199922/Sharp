using System;
using CalcLib;
//------------------E:\Coforge\Day-6\CalcLib\CalcLib\bin\Debug------------------------
namespace UsageOfLib
{
    class Program
    {
        static void Main(string[] args)
        {
            double fnum, snum;
            string choice = "n";
            do
            {
                Console.Write("Enter first number : ");
                fnum = double.Parse(Console.ReadLine());
                Console.Write("\nEnter Second number : ");
                snum = double.Parse(Console.ReadLine());
                Console.WriteLine("\n\n-----------Choose Operation From List-----------");
                Console.WriteLine("\n1. Add\n2. Subtract\n3. Multiply\n4. Division\n5. Average");
                int op = int.Parse(Console.ReadLine());
                Calculation cal = new Calculation();
                switch (op)
                {
                    case 1:
                        {
                            cal.Add(fnum, snum);
                            break;
                        }
                    case 2:
                        {
                            cal.Sub(fnum, snum);
                            break;
                        }
                    case 3:
                        {
                            cal.Mul(fnum, snum);
                            break;
                        }
                    case 4:
                        {
                            cal.Div(fnum, snum);
                            break;
                        }
                    case 5:
                        {
                            cal.Avg(fnum, snum);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Operation Choice");
                            break;
                        }
                }
                Console.WriteLine("To continue press Y");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
