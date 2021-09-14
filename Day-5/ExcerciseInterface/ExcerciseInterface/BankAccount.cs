using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseInterface
{
    public class BankAccount : ISavingAccount, ICurrentAccount
    {
        double sBalance;
        double cBalance;

        public BankAccount()
        {
            sBalance = 1234;
            cBalance = 12345;
        }
        double ISavingAccount.Balance { get { return sBalance; } }

        double ICurrentAccount.Balance { get { return cBalance; } }

        void ISavingAccount.deposit()
        {
            Console.WriteLine("----------------Savings Account----------------");
            Console.WriteLine("Enter Deposit Amount : ");
            double amount = double.Parse(Console.ReadLine());
            sBalance += amount;
            //Console.WriteLine("Final Balance = {0}");
        }

        void ICurrentAccount.deposit()
        {
            Console.WriteLine("-----------------------Current Account----------------------");
            Console.WriteLine("Enter Deposit Amount : ");
            double amount = double.Parse(Console.ReadLine());
            cBalance += amount;
            Console.WriteLine("Final Balance = {0}", cBalance);
        }

        void ISavingAccount.withdraw()
        {
            Console.WriteLine("----------------Savings Account----------------");
            Console.WriteLine("\n\nInitial Balance : "+sBalance);
            Console.WriteLine("Enter Amount To Withdraw : ");
            double amount = double.Parse(Console.ReadLine());
            sBalance -= amount;
            Console.WriteLine("Final Balance = "+sBalance);
        }

        void ICurrentAccount.withdraw()
        {
            Console.WriteLine("----------------Current Account----------------");
            Console.WriteLine("\n\nInitial Balance : " + cBalance);
            Console.WriteLine("Enter Amount To Withdraw : ");
            double amount = double.Parse(Console.ReadLine());
            cBalance -= amount;
            Console.WriteLine("Final Balance = " + cBalance);
        }
    }
}
