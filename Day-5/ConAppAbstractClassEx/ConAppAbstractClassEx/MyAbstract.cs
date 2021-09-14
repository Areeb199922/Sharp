using System;
namespace ConAppAbstractClassEx
{
    public abstract class MyAbstract
    {
        int myfield;
        public MyAbstract()
        {
            Console.WriteLine("Abstract Consructor");
            myfield = 1;
        }
        public void Display()
        {
            Console.WriteLine("Display Method Of Abstract Class");
        }
        public abstract string Welcome(string name);//Abstract Method No body, implementation in child class
        public int MyProperty { get {return myfield; } set {myfield = value; } }
        public abstract string MyAbProp { get; set; }//implementation in child class
    }
}
