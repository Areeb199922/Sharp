//using System;
//namespace ConsoleApp4
//{
//    public class ExerciseProperties
//    {
//        int id;
//        string name;
//        double salary;
//        static int empcount = 0;


//        public ExerciseProperties()
//        {
//            empcount += 1;
//        }
//        public int Id
//        {
//            get
//            {
//                return id;
//            }
//            set
//            { 
//                 id = value;
                    
//            }
//        }
//        public string Name
//        {
//            get
//            {
//                if (name == "Invalid Name")
//                {
//                    Console.WriteLine("Name Value not Stored, Invalid Name");
//                }
//                return name;
//            }
//            set
//            {
//                if (value.Length > 6)
//                {
//                    name = value;
//                }
//                else
//                {
//                    name = "Invalid Name";
//                }
//            }
//        }

//        public double Salary
//        {
//            get
//            { 
//                return salary;
//            }
//            set
//            {
                
                
//                    salary = value;
                
                
//            }
//        }
//        public static int Ecount
//        {
//            get 
//            {
//                return empcount;
//            }
//        }
//    }

//    public class ExMain
//    {
//        public static void Main()
//        {
//            ExerciseProperties obj1 = new ExerciseProperties();
//            Console.WriteLine("\n\nEnter ID : ");
//            obj1.Id = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Name : ");
//            obj1.Name = Console.ReadLine();
//            Console.WriteLine("Enter Salary : ");
//            obj1.Salary = double.Parse(Console.ReadLine());
//            Console.WriteLine("\n\nID : " + obj1.Id + "\nName : " + obj1.Name + "\nSalary : " + obj1.Salary + "\nNumber Of Employees : " + ExerciseProperties.Ecount);

//            ExerciseProperties obj2 = new ExerciseProperties();
//            Console.WriteLine("\n\nEnter ID : ");
//            obj2.Id = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Name : ");
//            obj2.Name = Console.ReadLine();
//            Console.WriteLine("Enter Salary : ");
//            obj2.Salary = double.Parse(Console.ReadLine());
//            Console.WriteLine("\n\nID : " + obj2.Id + "\nName : " + obj2.Name + "\nSalary : " + obj2.Salary + "\nNumber Of Employees : " + ExerciseProperties.Ecount);

//            ExerciseProperties obj3 = new ExerciseProperties();
//            Console.WriteLine("\n\nEnter ID : ");
//            obj3.Id = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Name : ");
//            obj3.Name = Console.ReadLine();
//            Console.WriteLine("Enter Salary : ");
//            obj3.Salary = double.Parse(Console.ReadLine());
//            Console.WriteLine("\n\nID : " + obj3.Id + "\nName : " + obj3.Name + "\nSalary : " + obj3.Salary + "\nNumber Of Employees : " + ExerciseProperties.Ecount);

//            Console.ReadKey();
//        }
//    }
//}
