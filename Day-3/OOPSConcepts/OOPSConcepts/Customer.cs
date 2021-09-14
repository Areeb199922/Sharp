using System;
namespace OOPSConcepts
{
    public class Customer
    {
        readonly int cid;
        string cname, cemail;
        public Customer(int id,string name,string email)
        {
            cid = id;
            cname = name;
            cemail = email;

        }

        public Customer(int id)
        {
            cid = id;

        }

        public void Display()
        {
            Console.WriteLine("\n\nCustomer ID : {0}\nCustomer Name : {1}\nCustomer Email : {2}",cid,cname,cemail);
        }

        public void Update()
        {
            Console.WriteLine("\nEnter New Customer Name for Cid {0} : ",cid);
            cname = Console.ReadLine();
            Console.WriteLine("Enter new Email for Cid {0} : ",cid);
            cemail = Console.ReadLine();
            Console.WriteLine("\n\nCustomer Details after update are as follows : ");
            Display();
        }


    }
}
