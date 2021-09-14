//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstConApp
//{
//    public class SwitchEx
//    {
//        public static void Main()
//        {
//            string lang, cCode;
//            Console.WriteLine("Enter Your Country Code e.g uk");
//            cCode = Console.ReadLine();
//            switch (cCode.ToLower())
//            {
//                case "uk":
//                case "us":
//                    {
//                        lang = "English";
//                        break;
//                    }
//                case "in":
//                    {
//                        lang = "English,Hindi,Urdu,Punjabi,Tamil,Telugu";
//                        break;
//                    }
//                case "af":
//                    {
//                        lang = "Dari,Pashtoo";
//                        break;
//                    }
//                case "ksa":
//                case "om":
//                case "uae":
//                    {
//                        lang = "Arabic";
//                        break;
//                    }
//                default:
//                    {
//                        Console.WriteLine("Sorry!! Your Country is not registered");
//                        lang = "Not Found";
//                        break;
//                    }
//            }
//            Console.WriteLine("Country Code : "+cCode+"\nLanguage :"+lang);
//            Console.ReadKey();
//        }
//    }
//}
