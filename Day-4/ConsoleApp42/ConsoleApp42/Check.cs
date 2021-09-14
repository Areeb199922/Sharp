using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            int v = 40;
            int[] x = new int[5];
            try
            {
                Console.WriteLine(" Enter the number: ");
                index = Convert.ToInt32(Console.ReadLine());
                x[index] = v;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception occurred");
            }
            Console.WriteLine("Program executed");
            Console.ReadKey();
        }
    }
}





