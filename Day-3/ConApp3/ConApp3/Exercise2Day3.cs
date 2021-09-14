//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConApp3
//{
//    public class MonthSal
//    {
//        public double calSal(double hrs, double days, double pHandles = 1, double extras = 0)
//        {

//            return (hrs * days * 100) + (pHandles * 3000) + (extras * 2000);
//        }
//    }
//    public class Exercise2Day3
//    {
//        public static void Main()
//        {
//            MonthSal obj = new MonthSal();
//            string empType;
//            Console.Write("Enter Emp Type : ");
//            empType = Console.ReadLine();

//            switch (empType.ToLower())
//            {
//                case "hr":
//                    {
//                        double hrs, days;
//                        Console.Write("Enter Number Of Working Hours : ");
//                        hrs = double.Parse(Console.ReadLine());
//                        Console.Write("\nEnter Number Of Working Days : ");
//                        days = double.Parse(Console.ReadLine());
//                        Console.WriteLine("Salary of HR : " + obj.calSal(hrs, days));
//                        break;

//                    }
//                case "admin":
//                    {
//                        double hrs, days, pHandles;
//                        Console.Write("Enter Number Of Working Hours : ");
//                        hrs = double.Parse(Console.ReadLine());
//                        Console.Write("\nEnter Number Of Working Days : ");
//                        days = double.Parse(Console.ReadLine());
//                        Console.Write("\nEnter Number Of Project Handles : ");
//                        pHandles = double.Parse(Console.ReadLine());
//                        Console.WriteLine("Salary of Admin : " + obj.calSal(hrs, days, pHandles));

//                        break;
//                    }

//                case "software developer":
//                case "softwaredeveloper":
//                    {
//                        double hrs, days, pHandles, extras;
//                        Console.Write("Enter Number Of Working Hours : ");
//                        hrs = double.Parse(Console.ReadLine());
//                        Console.Write("\nEnter Number Of Working Days : ");
//                        days = double.Parse(Console.ReadLine());
//                        Console.Write("\nEnter Number Of Project Handles : ");
//                        pHandles = double.Parse(Console.ReadLine());
//                        Console.Write("\nEnter Extras : ");
//                        extras = double.Parse(Console.ReadLine());
//                        Console.WriteLine("Salary of Software Developer : " + obj.calSal(hrs, days, pHandles, extras));

//                        break;
//                    }
//                default:
//                    {
//                        Console.WriteLine("Role Unavailable");
//                        break;
//                    }
//            }
//            Console.ReadKey();


//        }
//    }
//}

