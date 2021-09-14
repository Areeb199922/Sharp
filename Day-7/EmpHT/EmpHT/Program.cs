using System;
using System.Collections;

namespace EmpHT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Hashtable obj = new Hashtable
            {
                { 1,new Emp{Name = "Sam", Designation = "Assistant Engineer ", Salary = 90000,DOJ = new DateTime(day:12,month:02,year:2018),Email = "sam@gmail.com"}},
                { 2,new Emp{Name = "Tim", Designation = "Associate Engineer ", Salary = 75000.90,DOJ = new DateTime(day:19,month:07,year:2019),Email = "tim@gmail.com"}},
                { 3,new Emp{Name = "Kol", Designation = "Senior Engineer ", Salary = 1250000,DOJ = new DateTime(day:12,month:02,year:2002),Email = "kol@gmail.com"}},
                { 4,new Emp{Name = "Camile", Designation = " Trainee Engineer ", Salary = 90000,DOJ = new DateTime(day:12,month:02,year:2020),Email = "cami@gmail.com"}},
                { 5,new Emp{Name = "Klaus", Designation = "Full Stack Developer", Salary = 1500000,DOJ = new DateTime(day:03,month:02,year:2001),Email = "klaus@gmail.com"}},
                { 6,new Emp{Name = "Freya", Designation = "Assistant Engineer ", Salary = 90000,DOJ = new DateTime(day:12,month:02,year:2018),Email = "freya@gmail.com"}}
            };

            Console.WriteLine("key \t Name \t Designation \t\t Salary  DOJ \t\t Email ID");
            int count = 1;
            foreach (Emp e in obj.Values)
            {
                Console.WriteLine(count + "\t" + e.Name + "\t" + e.Designation + "\t" + e.Salary + "\t" + e.DOJ.ToShortDateString() + "\t" + e.Email);
                count += 1;


            }

            //foreach (var k in obj.Keys)
            //{
            //    Console.Write(k+"\t");
            //    //foreach (Emp e in obj.Values)
            //    //{
            //        Console.WriteLine(count + "\t" + (obj[k]) + "\t" + e.Designation + "\t" + e.Salary + "\t" + e.DOJ.ToShortDateString() + "\t" + e.Email);



            //    //}



            //}


            Console.ReadKey();
        }
    }
}
