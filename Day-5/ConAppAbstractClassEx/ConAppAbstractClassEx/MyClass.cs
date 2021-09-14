using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAbstractClassEx
{
    public class MyClass : MyAbstract
    {
        string mycFiled;
        public MyClass()
        {
            Console.WriteLine("Constructor Of Derived My Class");
            mycFiled = "this is derived field";
        }
        public override string MyAbProp { get => mycFiled; set => mycFiled = value; }

        public override string Welcome(string name)
        {
            return "Welcome to Abstract Classes mr.\\Ms. " + name;
        }
    }
}
