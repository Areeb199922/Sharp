using System;
namespace EmpLib
{
    public class Emp
    {
        int id;
        string name;
        double salary;

        public Emp()
        {
            id = 1;
            name = "not given";
            salary = 0.0;
        }

        public void Register()
        {
            Console.WriteLine("Enter ID : ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
            salary = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Employee Details are as follows-:");
            Console.WriteLine("ID : {0}\nName : {1}\nSalary : {2}",id,name,salary);
        }

        public string Name { get { return name; } }
        public double Salary { get { return salary; } }
    }
}
