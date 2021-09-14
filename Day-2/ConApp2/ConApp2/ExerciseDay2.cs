//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConApp2
//{
//    public class ExerciseDay2
//    {
//        public static void Main()
//        {
//            double[,] smarks = new double[4, 7];
//            double total = 0;
//            int j=0;
//            Console.WriteLine("Enter Four Students Semester Wise Marks out of 100\n\n");

//            for (int i = 0; i < 4; i++)
//            {
//                total = 0;
//                Console.WriteLine("Enter Student{0}\'s Roll Number", (i + 1));
//                smarks[i, 0] = double.Parse(Console.ReadLine());
//                for (j = 1; j < 5; j++)
//                {
//                    Console.WriteLine("Enter Student {0}\'s Marks in Sem{1}", (i + 1), j);
//                    smarks[i, j] = double.Parse(Console.ReadLine());
//                    total += smarks[i, j];

//                }
//                smarks[i, j] = total;
//                smarks[i, j + 1] = (total / 400) * 100;
               
//            }
//            Console.WriteLine("\n\n\n");
//            Console.WriteLine("Roll \tSem1 \tSem2 \tSem3 \tSem4 \tTotal \tPercentage");
//            Console.WriteLine("------------------------------------------------------------------");
//            for (int i = 0; i < 4; i++)
//           {
//                for (j = 0; j < 7; j++)
//                {
//                    Console.Write(smarks[i,j]+"\t");
//                }
//                Console.WriteLine("\n");
//            }
//            Console.ReadKey();
//        }
//    }
//}
