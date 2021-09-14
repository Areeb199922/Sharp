using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Choose Account Type : \n1. Saving\n2. Current\n");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BankAccount obj = new BankAccount();
                ISavingAccount obj1 = obj;

                Console.WriteLine("Balance = "+obj1.Balance);
                obj1.deposit();
                Console.WriteLine("\n\n After Deposit Method Balance = "+obj1.Balance);
                obj1.withdraw();
                Console.WriteLine("\n\nAfter Withdraw Method Balance = "+obj1.Balance);
                //Console.WriteLine(obj1.Balance); 

            }

            if (choice == 2)
            {
                BankAccount obj = new BankAccount();
                ICurrentAccount obj2 = obj;

                obj2.deposit();
                obj2.withdraw();

            }

            Console.ReadKey();
        }
    }
}
