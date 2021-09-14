using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome To Bank Of Chicago-------------");

            Console.WriteLine("Choose Account Type:\n1. Savings\n2. Current");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
               
                case 1:
                    {

                    Console.WriteLine("--------------Savings Account-----------------");
                    Console.WriteLine("Choose operation to perform : \n1. Balance Enquiry\n2. Deposit Amount\n3. Withdraw Cash");
                    BankAccount obj = new BankAccount();
                    ISavingAccount objs = obj;
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            {
                                Console.WriteLine("Your Current Balance = " + objs.Balance);
                                break;
                            }

                        case 2:
                            {
                                objs.Deposit();
                                Console.WriteLine("Your New Balance = " + objs.Balance);
                                break;
                            }

                        case 3:
                            {
                                objs.Withdraw();
                                Console.WriteLine("Your New Balance = " + objs.Balance);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Input");
                                break;
                            }
                    }
                    break;
                }
            
                case 2:
                    {
                        Console.WriteLine("--------------Savings Account-----------------");
                        Console.WriteLine("Choose operation to perform : \n1. Balance Enquiry\n2. Deposit Amount\n3. Withdraw Cash");
                        BankAccount obj = new BankAccount();
                        ICurrentAccount objc = obj;
                        int n = int.Parse(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Your Current Balance = " + objc.Balance);
                                    break;
                                }

                            case 2:
                                {
                                    objc.Deposit();
                                    Console.WriteLine("Your New Balance = " + objc.Balance);
                                    break;
                                }

                            case 3:
                                {
                                    objc.Withdraw();
                                    Console.WriteLine("Your New Balance = " + objc.Balance);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Invalid Input");
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
