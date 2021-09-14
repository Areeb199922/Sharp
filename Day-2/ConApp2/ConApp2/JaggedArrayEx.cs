//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConApp2
//{
//    public class JaggedArrayEx
//    {
//        public static void Main()
//        {
//            //string[][] myJArray = new string[3][];
//            //myJArray[0] = new string[5] { "Raj", "Ravi", "Vinaj", "Vijay", "Deep" };
//            //myJArray[1] = new string[2] { "Neha", "Aditi" };
//            //myJArray[2] = new string[3] { "Amit", "Sam","Pam" };
//            //Console.WriteLine("Nams inside array are\n\n");
//            //for (int i = 0; i < myJArray.Length; i++)
//            //{
//            //    for (int j = 0; j < myJArray[i].Length; j++)
//            //    {
//            //        Console.Write(myJArray[i][j]+"\t");
//            //    }
//            //    Console.WriteLine("\n");
//            //}
//            //Console.ReadKey();


//            //using foreach-------------------------------
//            //string[][] myJArray = new string[3][];
//            //myJArray[0] = new string[5] { "Raj", "Ravi", "Vinaj", "Vijay", "Deep" };
//            //myJArray[1] = new string[2] { "Neha", "Aditi" };
//            //myJArray[2] = new string[3] { "Amit", "Sam", "Pam" };
//            //Console.WriteLine("Nams inside array are\n\n");

//            //foreach (var e in myJArray)
//            //{
//            //    foreach (var ie in e)
//            //    {
//            //        Console.Write(ie+"\t");
//            //    }
//            //    Console.WriteLine("\n");
//            //}
//            //Console.ReadKey();

//            //dynamic decides data type at run time and have larger scope than var which can only be used for local variables

//            dynamic[][] myJArray = new dynamic[3][];
//            myJArray[0] = new dynamic[5] { "Raj", "Ravi", "Vinaj", "Vijay", "Deep" };
//            myJArray[1] = new dynamic[2] { 1,2};
//            myJArray[2] = new dynamic[3] { 1.1,1.2,1.3 };
//            Console.WriteLine("Nams inside array are\n\n");

//            foreach (var e in myJArray)
//            {
//                foreach (var ie in e)
//                {
//                    Console.Write(ie + "\t");
//                }
//                Console.WriteLine("\n");
//            }
//            Console.ReadKey();
//        }
//    }
//}
