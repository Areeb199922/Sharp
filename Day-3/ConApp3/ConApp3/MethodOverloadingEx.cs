//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConApp3
//{
//    public class MethodOverloadingEx
//    {
//        public void Display()
//        {
//            Console.WriteLine("Method Without Parameters");
//        }
//        public void Display(string name)
//        {
//            Console.WriteLine("Method with one parameter , Name : "+name);
//        }
//        public void Display(string fname, string lname)
//        {
//            Console.WriteLine("Method wih two parameters , Fname {0} and Lname {1}",fname,lname);
//        }
//        public void Display(double num1, double num2)
//        {
//            Console.WriteLine("Sum of Num1 {0} and Num2 {1} = {2}",num1,num2,num1+num2);
//        }

//        //------------------Overloading With value type variable and reference type variable----------------------//
//        //----------------Here we cannot have OUT and REF together----------------------------//
//        public void Increment(double sal)
//        {
//            sal = 1000;
//            Console.WriteLine("Before Increment : "+sal);
//            sal += sal * 0.10;
//            Console.WriteLine("After Increment : "+sal);
//        }
//        public void Increment(ref double sal)
//        {
//            sal = 1000;
//            Console.WriteLine("Before Increment : " + sal);
//            sal += sal * 0.10;
//            Console.WriteLine("After Increment : " + sal);
//        }

//        public static void Main()
//        {
//            MethodOverloadingEx obj = new MethodOverloadingEx();
//            obj.Display(1.2,2.3);
//            Console.ReadKey();
//        }
//    }
//}
