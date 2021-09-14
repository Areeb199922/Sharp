using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class BankAccount:ISavingAccount,ICurrentAccount
    {
        double sBal;
        double cBal;
        public BankAccount()
        {
            sBal = 0;
            cBal = 0;
        }

        double ISavingAccount.Balance => sBal;

        double ICurrentAccount.Balance => cBal;

        void ISavingAccount.Deposit()
        {
            Console.Write("Enter Amount You Want To Deposit : ");
            double amount = double.Parse(Console.ReadLine());
            sBal += amount;
        }

        void ICurrentAccount.Deposit()
        {
            Console.Write("Enter Amount You Want To Deposit : ");
            double amount = double.Parse(Console.ReadLine());
            cBal += amount;
        }

        void ISavingAccount.Withdraw()
        {
            Console.Write("Enter Amount You Want To Withdarw : ");
            double amount = double.Parse(Console.ReadLine());
            if (amount > sBal)
            {
                Console.WriteLine("Insufficient Balance");

            }
            else 
            {
                sBal -= amount;
            }
        }

        void ICurrentAccount.Withdraw()
        {
            Console.Write("Enter Amount You Want To Withdarw : ");
            double amount = double.Parse(Console.ReadLine());
            if (amount > cBal)
            {
                Console.WriteLine("Insufficient Balance");

            }
            else
            {
                cBal -= amount;
            }
        }
    }
}
