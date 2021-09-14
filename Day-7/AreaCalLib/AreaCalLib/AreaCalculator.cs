using System;
namespace AreaCalLib
{
    public class AreaCalculator
    {
        public void Rectangle()
        {
            Console.Write("Enter width of rectangle : ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter Length of rectangle : ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of Rectangle = " + width * length);
        }

        public void Circle()
        {
            Console.Write("Enter radius of the circle : ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine( "Area of Circle = "+ 3.14 * radius * radius); 
        }

        public void Square()
        {
            Console.Write("Enter side of square : ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Area Of Square = "+ s * s);
        }

        public void Ellipse()
        {
            Console.Write("Enter Radius1 : ");
            double r1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Radius2 : ");
            double r2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Area Of Ellipse = "+ 3.14 * r1 * r2);
        }
    }
}
