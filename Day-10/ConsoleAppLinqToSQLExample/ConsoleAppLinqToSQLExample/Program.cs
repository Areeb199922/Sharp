using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqToSQLExample
{
    class Program
    {
        static OurEmpDbDataContext db;
        static void Main(string[] args)
        {
            //OurEmpDbDataContext dataContext = new OurEmpDbDataContext();
            //var empsList = dataContext.Emps;
            //Console.WriteLine("ID \t Name \t Salary \t DOJ");
            //foreach (Emp e in empsList)
            //{
            //    Console.Write(e.EmpId+" \t ");
            //    Console.Write(e.EmpName + " \t ");
            //    Console.Write(e.EmpSalary + " \t ");
            //    Console.WriteLine(e.EmpDOJ);
            //}
            //Console.ReadKey();

            
            try
            {
                db = new OurEmpDbDataContext();
                Console.WriteLine("Enter EID to findout employee Record");
                int id = int.Parse(Console.ReadLine());
                Emp obj = db.Emps.SingleOrDefault(e => e.EmpId == id);//here we can also use var obj = ---------
                if (obj != null)
                {
                    Console.WriteLine("Employee Record Found Details as follows : ");
                    Console.WriteLine("ID : " + obj.EmpId);
                    Console.WriteLine("Name : " + obj.EmpName);
                    Console.WriteLine("Salary : " + obj.EmpSalary);
                    Console.WriteLine("DOJ : " + obj.EmpDOJ);
                }
                else
                {
                    Console.WriteLine("No such Record Found");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error !!! "+ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
