using System;
namespace ConsoleApp4
{
    public class Dev:Employee  //------------------Inheritance Dev inherits Employee class
    {
        string domain;
        string project;
        public Dev()
        {
            Console.WriteLine("Constructor of developer class");
        }

        public override void Register()
        {
            base.Register();//this line calls base class register method
            Console.WriteLine("Enter Domain : ");
            domain = Console.ReadLine();
            Console.WriteLine("Enter Projects : ");
            project = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Domain "+domain);
            Console.WriteLine("Projects "+project);
        }
    }
}
