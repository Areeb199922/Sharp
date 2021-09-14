//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConApp2
//{
//    class RecArrayEx
//    {
//        public static void Main()
//        {
//            //string[,] myRA = new string[4, 3];
//            //for (int row = 0; row < 4; row++)
//            //{
//            //    for (int col = 0; col < 3; col++)
//            //    {
//            //        myRA[row, col] = " Row " + row + " Col " + col; 
//            //    }

//            //}
//            //Console.WriteLine("Output from Array");
//            //for (int row = 0; row < 4; row++)
//            //{
//            //    for (int col = 0; col < 3; col++)
//            //    {
//            //        Console.Write(myRA[row,col]);
//            //    }
//            //    Console.WriteLine("\n");

//            //}
//            //Console.ReadKey();


//            //-------------2D Array Example----------------------//

//            int[,] smarks = new int[3, 3];
//            Console.WriteLine("Enter three Students Semester Wise Details");
//            for (int i = 0; i < 3; i++)
//            {
//                Console.WriteLine("Enter Student{0}\'s Roll Number",(i+1));
//                smarks[i, 0] = int.Parse(Console.ReadLine());
//                for (int j = 1; j < 3; j++)
//                {
//                    Console.WriteLine("Enter Student {0}\'s Marks in Sem{1}",(i+1),j);
//                    smarks[i, j] = int.Parse(Console.ReadLine());
//                }
//            }
//            //Console.WriteLine("Roll \tSem1 \tSem2");
//            Console.WriteLine("-----------------------------");
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    Console.Write(smarks[i,j]+"\t");
//                }
//                Console.WriteLine("\n");
//            }
//            Console.ReadKey();


//        }
//    }
//}
