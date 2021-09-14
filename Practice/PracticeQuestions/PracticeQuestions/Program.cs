//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeQuestions
//{
//    public class add
//    {
//        public static double addnums(params double[] num)
//        {
//            //double res = 0;

//            //foreach (var n in num)
//            //{
//            //    Console.WriteLine(num[0]);
//            //    res += n;
//            //}
//            //return res;
//            Console.Write("Enter numberof elements : ");
//            int n = int.Parse(Console.ReadLine());

//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("Enter {0}th element : ", i);
//                num.Append(double.Parse(Console.ReadLine()));
//            }

//            for (int i=0;i<n;i++)
//            {
//                Console.WriteLine(num[i]);
//            }
//            //Console.WriteLine(num);
//            return 0.0;
//        }
//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            //Console.WriteLine(add.addnums(1,2,3)); 
//            add.addnums();
//            Console.ReadKey();
//        }
//    }
//}

