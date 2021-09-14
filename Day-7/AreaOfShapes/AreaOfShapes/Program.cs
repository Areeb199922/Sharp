using System;
using AreaCalLib;
namespace AreaOfShapes
{

    public static class OurClass
    {
        public static void Triangle(this AreaCalculator ob)
        {
            Console.Write("Enter base of Triangle : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter Vertical Height Of Triangle : ");
            double vh = double.Parse(Console.ReadLine());
            Console.WriteLine("Area Of Triangle = "+(0.5*b*vh));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator obj = new AreaCalculator();
            string choice = "n";
            do 
            {
                Console.WriteLine("Select Shape To Calculate Area\n");
                Console.WriteLine("\n1. Rectangle\n2. Circle\n3. Square\n4. Ellipse\n5. Triangle");
                int c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        {
                            obj.Rectangle();
                            break;
                        }
                    case 2:
                        {
                            obj.Circle();
                            break;
                        }
                    case 3:
                        {
                            obj.Square();
                            break;
                        }
                    case 4:
                        {
                            obj.Ellipse();
                            break;
                        }
                    case 5:
                        {
                           obj.Triangle();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Entry");
                            break;
                        }
                        
                }
                Console.WriteLine("To continue press Y");
                choice = Console.ReadLine();

            } while (choice == "y");
            Console.ReadKey();
        }
    }
}
