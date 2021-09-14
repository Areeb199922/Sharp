using System;
namespace AnonymousMethod
{
    public delegate void Del(double val);

    public class AnonymousExercise
    {
        public static void Main()
        {
            double num;
            Console.Write("Enter Number : ");
            num = double.Parse(Console.ReadLine());

            Del del = delegate (double a)
            {

                Console.WriteLine("----------Anonymous Method--------------\nCube of {0} = {1}",a,a*a*a);
            };
            del(num);


            Del del2 = a =>
                        {
                            Console.WriteLine("\n----------------Lambda Expression-----------------\nCube of {0} = {1}", a, a * a * a );
                        };
            del2(num);
            Console.ReadKey();
        }
    }
}
