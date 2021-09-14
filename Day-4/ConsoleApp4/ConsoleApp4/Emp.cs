////using System;
////[A.S] DataType PropertyName {get;set;}
////get is used for reading
////set is used for writing
////Read Only Property Type (get)
////Write Only Property (set)
////ReadWrite Property(get,set)
////Static Proeprty(For Complete Class)
////Abstract
////namespace ConsoleApp4
////{
////    public class Emp
////    {
////        int id;
////        string name;
////        DateTime doj;

////        public int Id 
////        { 
////            get 
////            {
////                if (id == -1)
////                {
////                    Console.WriteLine("Invalid ID");
////                }
////                return id; 
////            } 
////            set 
////            { 
////                if (value >= 0)
////                {
////                    id = value; 
////                }
////                else 
////                {
////                    id = -1; 
////                }
////             } 
////        }
////        public string Name 
////        { 
////            get 
////            {
////                if (name == "invalid")
////                {
////                    Console.WriteLine("Name Value not Stored, Invalid Name");
////                }
////                return name; 
////            }
////            set
////            {
////                if (value.Length >= 5)
////                {
////                    name = value;
////                }
////                else
////                {
////                    name = "Invalid";
////                }
////            }
////        }
////        public DateTime DOJ { get { return doj; } set { doj = value; } }

////    }
////}


////--------------------------------READ ONLY------------------------------------------//
////namespace ConsoleApp4
////{
////    public class Emp
////    {
////        readonly int id;
////        readonly string name;
////        readonly DateTime doj;
////        static double tax;


////        public Emp(int id, string name, DateTime doj)
////        {
////            this.id = id;
////            this.name = name;
////            this.doj = doj;
////            //tax = 12.45;

////        }
////        public int Id
////        {
////            get
////            {
               
////                return id;
////            }
            
////        }
////        public string Name
////        {
////            get
////            {
                
////                return name;
////            }
            
////        }
////        public DateTime DOJ 
////        {
////            get 
////            { 
////                return doj; 
////            }
////        }
////        public static double Tax
////        {
////            get 
////            {
////                return tax;
////            }
////            set 
////            {
////                tax = value;
////            }
////        }

////    }
////}
