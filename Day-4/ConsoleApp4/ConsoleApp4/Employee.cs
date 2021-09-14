//using System;

//namespace ConsoleApp4
//{
//    public class Employee
//    {
//        int eid;
//        string ename;
//        DateTime doj;
//        public Employee()
//        {
//            Console.WriteLine("Constructor of Employee Class");
//        }
//        public virtual void Register()//-----------VIRTUAL keyword is used to define that this method can be overridden
//        {
//            Console.WriteLine("Enter ID");
//            eid = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Name");
//            ename = Console.ReadLine();
//            Console.WriteLine("Enter DOJ");
//            doj = DateTime.Parse(Console.ReadLine());
//        }
//        public virtual void Display()
//        {
//            Console.WriteLine("ID : \t"+eid);
//            Console.WriteLine("Name : \t" +ename);
//            Console.WriteLine("DOJ : \t" +doj.ToShortDateString());
//        }
//    }
//}
