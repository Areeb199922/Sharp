//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////----------------------------------CALL BY PARAM PARAMTER TYPE-----------------------------------
//namespace ConApp3
//{
//    public class Calc
//    {
//        public double Add(params double[] numbers)//after param we cannot add parameters, it must be last parameter in parameter list
//        {
//            double result = 0;
//            foreach (var n in numbers)
//            {
//                result += n;
//            }
//            return result;


//        }
//    }
//    //----------------with OUT parameter we can send UN-INITIALISED variable , but this is not possible with REF
//    public class Program
//    {//we can pass any number of agumnets in param
//        static void Main(string[] args)
//        {
//            Calc objc = new Calc();
//            Console.WriteLine("Result after adding 1,2,3.5,45.5 is = " + objc.Add(1, 2, 3.5, 45.5));
//            Console.WriteLine("Result after adding 13.25,45.5 is = " + objc.Add(13.25, 45.5));
//            Console.WriteLine("Result after adding 10.10,20.78,3.90,3.89 is = " + objc.Add(10.10, 20.78, 3.90, 3.89));
           

//            Console.ReadKey();
//        }

//    }
//}
