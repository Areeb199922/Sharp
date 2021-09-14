//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConApp3
//{
//    public class SalaryCalc
//    {
//        public void Increment(double sal)
//        {
//            Console.WriteLine("Salary Before Increment In Method is : " + sal);
//            sal += sal * 0.10;//sal = sal+sal*0.10
//            Console.WriteLine("Salary After Increment is : " + sal);
//        }
//    }

//    public class Program
//    {
//        static void Main(string[] args)
//        {//---------------------------------CALL BY VALUE--------------------------------------
//            double empSal = 90000.90;
//            Console.WriteLine("Salary in main before calling increment is = " + empSal);
//            SalaryCalc objc = new SalaryCalc();
//            objc.Increment(empSal);
//            Console.WriteLine("After Calling Increment Salary in main = " + empSal);
//            Console.ReadKey();
//        }

//    }
//}
