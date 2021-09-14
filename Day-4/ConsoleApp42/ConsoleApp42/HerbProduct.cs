//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp42
//{
//    public class HerbProduct:Product
//    {
//        string herbsUsed;
//        DateTime mfDate;
//        DateTime expDate;

//        public override void setInfo()
//        {
//            base.setInfo();
//            Console.WriteLine("Enter herbs used : ");
//            herbsUsed = Console.ReadLine();
//            Console.WriteLine("Enter Manufacturing Date : ");
//            mfDate = DateTime.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Expiry Date : ");
//            expDate = DateTime.Parse(Console.ReadLine());
//        }

//        public override void Display()
//        {
//            base.Display();
//            Console.WriteLine("Herbs Used : {0}\nManufacturing Date : {1}\nExpiry Date : {2}",herbsUsed,mfDate.ToShortDateString(),expDate.ToShortDateString());
//        }
//    }
//}
