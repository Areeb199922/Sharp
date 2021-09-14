using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqExTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> empList = new List<Emp>()
            {
                new Emp{ Id = 1,Name = "Deep",Designation="Developer",Salary = 1250000.875,DOJ = DateTime.Now},
                new Emp{ Id = 2,Name = "Rooh",Designation="Manager",Salary = 1250000.875,DOJ = new DateTime(day : 12,month : 11,year : 2012)},
                new Emp{ Id = 3,Name = "Dev",Designation="Developer",Salary = 1250000.875,DOJ = DateTime.Parse("12/12/2018")},//DateTime.Parse(12/12/2018)
                new Emp{ Id = 4,Name = "Anita",Designation="Developer",Salary = 1250000.875,DOJ = DateTime.Now},
                new Emp{ Id = 5,Name = "Dev",Designation="Tester",Salary = 1250000.875,DOJ = DateTime.Now},
                new Emp{ Id = 6,Name = "Anita",Designation="Manager",Salary = 1250000.875,DOJ = DateTime.Now}

            };
            var empListdsc = from emps in empList orderby emps.Id descending select emps;
            Console.WriteLine("List Of Emp");
            Console.WriteLine("ID \t Name \t Designation \t Salary \t DOJ");
            foreach (Emp e in empList)
            {
                Console.Write(e.Id + " \t ");
                Console.Write(e.Name + " \t ");
                Console.Write(e.Designation + " \t ");
                Console.Write(e.Salary + " \t ");
                Console.WriteLine(e.DOJ.ToShortDateString() + " \t ");
            }
            Console.WriteLine("Descending Order------------------------");
            foreach (Emp e in empListdsc)
            {
                Console.Write(e.Id + " \t ");
                Console.Write(e.Name + " \t ");
                Console.Write(e.Designation + " \t ");
                Console.Write(e.Salary + " \t ");
                Console.WriteLine(e.DOJ.ToShortDateString() + " \t ");
            }
            Console.WriteLine("--------------------------------------------");
            var empdList = empList.OrderByDescending(e=>e.Id);
            foreach (Emp e in empdList)
            {
                Console.Write(e.Id + " \t ");
                Console.Write(e.Name + " \t ");
                Console.Write(e.Designation + " \t ");
                Console.Write(e.Salary + " \t ");
                Console.WriteLine(e.DOJ.ToShortDateString() + " \t ");
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter name to find out employee : ");
            string name = Console.ReadLine();
            var sEmps = empdList.Where(e => e.Name == name);
            if (sEmps != null)
            {
                foreach (Emp e in sEmps)
                {
                    Console.Write(e.Id + " \t ");
                    Console.Write(e.Name + " \t ");
                    Console.Write(e.Designation + " \t ");
                    Console.Write(e.Salary + " \t ");
                    Console.WriteLine(e.DOJ.ToShortDateString() + " \t ");
                }
        }
            else
            {
                Console.WriteLine("No Employee With Name {0} Exists ",name);
            }
    Console.ReadKey();
        }
    }
}
