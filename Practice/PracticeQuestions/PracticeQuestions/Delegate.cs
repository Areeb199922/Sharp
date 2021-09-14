using System;
namespace MulticastDelegateDemo
{
    public delegate void MathDelegate(int No1, int No2);
    public class Program
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("THE SUM IS : " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("THE SUB IS : " + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("THE MUL IS : " + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("THE DIV IS : " + (x / y));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            MathDelegate del1 = new MathDelegate(Add);
            del1 += p.Div;
            MathDelegate del2 = new MathDelegate(Program.Sub);
            MathDelegate del3 = p.Mul;
            MathDelegate del4 = new MathDelegate(p.Div); ;
            //In this example del5 is a multicast delegate. We can use +(plus) 
            // operator to chain delegates together and -(minus) operator to remove.
            MathDelegate del5 = del1 + del2 + del3 + del4;
            del5(20, 5);
            Console.WriteLine();
            del5 -= del2;
            del5(22, 7);

            Console.ReadKey();
        }
    }
}