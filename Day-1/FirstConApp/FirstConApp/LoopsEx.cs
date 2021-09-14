using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConApp
{
    class LoopsEx
    {
        public static void Main()
        {
            //for (int num = 1; num <= 100; num++)
            //{
            //    Console.WriteLine(num);
            //}


            //For Loop

            //int number;
            //Console.WriteLine("Enter number to find out table");
            //number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Table of Number : "+number+" is as follows ");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("{0} * {1} = {2}",number,i,(number*i));   
            //}

            //Console.ReadKey();


                    //Do While Loop


            int number;
            string choice;
            do { 
            Console.WriteLine("Enter number to find out table");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Table of Number : " + number + " is as follows ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, (number * i));
            }
            Console.WriteLine("Continue Y or N");
            choice = Console.ReadLine().ToLower();

        }while(choice == "y");
            Console.ReadKey();
        }
    }
}
