using System;
using SamSung;//{1}
namespace Retailer
{
    class Program
    {
        static void Main(string[] args)
        {
            OurClass our = new OurClass();
            our.Welcome();
            Mobile mobile = new Mobile();//Fully Qualified Name(SamSung.Mobile mobile = new SamSung.Mobile();)(From another namespace) or we cam import the namespace{1}
            mobile.Welcome();
            Console.ReadKey();
        }
    }
}

namespace SamSung
{
    public class Mobile
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to SamSung Mobile");
        }
    }
}
