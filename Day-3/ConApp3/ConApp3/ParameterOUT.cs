//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////----------------------------------CALL BY OUT PARAMTER TYPE-----------------------------------
//namespace ConApp3
//{
//    public class SalaryCalc
//    {
//        public void FindBonus(out double bonus, double basic)
//        {
//            bonus = basic * 0.15;


//        }
//    }
//    //----------------with OUT parameter we can send UN-INITIALISED variable , but this is not possible with REF
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            double empBonus, empBasic;
//            Console.WriteLine("Enter Basic Salary Of Employee");
//            empBasic = double.Parse(Console.ReadLine());
//            SalaryCalc cal = new SalaryCalc();
//            cal.FindBonus(out empBonus, empBasic);
//            Console.WriteLine("Basic \t " + empBasic + " Bonus " + empBonus);
//            Console.WriteLine("Bonus Value = " + empBonus);

//            Console.ReadKey();
//        }

//    }
//}
