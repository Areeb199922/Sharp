using System;
namespace CalcLib
{
    public class Calculation
    {
        public void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("Result after adding {0} and {1} = {2}",num1,num2, result); 
        }

        public void Sub(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine("Result after subtracting {1} from {0} = {2}", num1, num2, result);
        }

        public void Mul(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine("Result after multiplying {0} and {1} = {2}", num1, num2, result);
        }

        public void Div(double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine("Result after dividing {0} by {1} = {2}", num1, num2, result);
        }

        public void Avg(double num1, double num2)
        {
            double result = (num1 + num2)/2;
            Console.WriteLine("Average of {0} and {1} = {2}", num1, num2, result);
        }
    }
}
