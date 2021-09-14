using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class MyClass : IMyInterface,IOurInterface
    {
        int id;
        public int MyProperty 
        {
            get { return id; }//get => id; is same
            set { id = value; } // set => id = value; is same
        }

        public void Display()
        {
            Console.WriteLine("Welcome To Display");
        }

        public void Welcome(string name)
        {
            Console.WriteLine("Welcome to interfaces {0}",name);
        }
    }
}
