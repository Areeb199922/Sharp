//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConApp3
//{
//    public class Credentials
//    {
//        public string check()
//        {
//            string uName, pWord;
//            Console.Write("Enter UserName : ");

//            uName = Console.ReadLine();
//            Console.Write("\nEnter Password : ");
//            pWord = Console.ReadLine();

//            if (uName == "" || pWord == "")
//            {
                
//                return "Please Provide User Name and Password";
//            }

//            if (uName == "admin1256" & pWord == "admin@1256@1256") 
//            {
               
//                    return "Sign Success";
                
               
//            }
//            if (uName != "admin1256" || pWord != "admin@1256@1256")
//            {
//                return "Invalid User";
//            }

//            return "";
            
//        }
//    }
//    public class ExerciseDay3
//    {
//        public static void Main()
//        {
//            Credentials objc = new Credentials();
//            Console.WriteLine(objc.check()); 
                
//            Console.ReadKey();

//        }
//    }
//}
