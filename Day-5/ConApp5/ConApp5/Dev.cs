//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConApp5
//{
//    public class Dev:Emp
//    {
//        string domain;

//        public Dev(int id,string name,string domain):base(id,name)
//        {
//            this.domain = domain;
//        }

//        //-------------------METHOD HIDING------------------------//

//        //public new void Display()
//        //{
//        //    Console.WriteLine("Display Method of Dev Class");
//        //}

//        public override void Display()
//        {
//            base.Display();
//            Console.WriteLine("Domain : "+domain);
//        }
//    }
//}
