//using System;
//namespace ConApp5
//{
//    public class UGCExer
//    {
//        int cId;
//        public UGCExer(int cId)
//        {
//            this.cId = cId;
//        }

//        public virtual void Display()
//        {
//            Console.WriteLine("College ID : "+cId);
//        }
//    }

//    public class University : UGCExer
//    {
//        string uName;
//        public University(int id,string name):base(id)
//        {
//            uName = name;
//        }
//        public override void Display()
//        {
//            base.Display();
//            Console.WriteLine("University Name : "+uName);
//        }
//    }

//    public class College : University
//    {
//        string collegename;
//        string collegetype;
//        public College(int id,string name,string cname,string ctype):base(id,name)
//        {
//            collegename = cname;
//            collegetype = ctype;
//        }

//        public override void Display()
//        {
//            base.Display();
//            Console.WriteLine("College Name : " + collegename + "\nCollege Type : " + collegetype);
//        }
      
//    }
    
//    public class Detail
//    {
//        public static void Main()
//        {
//            College objdav = new College(1001, "Uttar Pradesh Technical University", "State College Of Engineering", "State University");
//            objdav.Display();
//            Console.WriteLine("\n\n");
//            College objhav = new College(1002, "India Central Technical University", "Central College Of Engineering", "Central University");
//            objdav.Display();
//            Console.ReadKey();

//        }

//    }
//}
