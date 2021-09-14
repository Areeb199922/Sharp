//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConApp2
//{
//    public class JaggedArrayExercise
//    {
//        public static void Main()
//        {
//            Console.WriteLine("Enter Number Of Employees : ");
//            int n = int.Parse(Console.ReadLine());
//            int[][] Emp = new int[n][];
//            int j = 0;
//            int total = 0;

//            for (int i = 0; i < n; i++)
//            {
//                total = 0;
//                Console.WriteLine("Enter number of working days of Employee {0} : ",(i+1));
//                int wd = int.Parse(Console.ReadLine());
//                Emp[i] = new int[wd+1];
//                for (j = 0; j < wd; j++)
//                {
//                    Console.WriteLine("Enter Salary of Day {0}",(j+1));
//                    Emp[i][j] = int.Parse(Console.ReadLine());
//                    total += Emp[i][j];
//                }
//                Emp[i][j] = total;
//            }

//            Console.WriteLine("\n\n\n");
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("Employee {0} : ",(i+1));
//                for (j = 0; j < Emp[i].Length-1; j++)
//                {
//                    Console.WriteLine("Day {0} Salary = {1}",(j+1),Emp[i][j]);
//                }
//                Console.WriteLine("Total Salary of Employee {0} = {1}",(i+1),Emp[i][Emp[i].Length-1]);
//            }
//            Console.ReadKey();
                
//        }
//    }
//}
