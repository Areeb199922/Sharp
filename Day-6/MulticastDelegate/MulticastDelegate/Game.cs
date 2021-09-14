using System;
namespace MulticastDelegate
{
    
    public class Game
    {
        public delegate void OurDel();
        public static void Main()
        {
            SpinPoints obj = new SpinPoints();
            
            Console.WriteLine("-------- GAME --------");
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            OurDel del = new OurDel(obj.InitialSpin);
            

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("\nEnter Your Lucky Number from 1 to 10 : ");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        {
                            del += new OurDel(obj.FirstSpin);
                            break;
                        }
                    case 2:
                        {
                            del += new OurDel(obj.SecondSpin);
                            break;
                        }
                    case 3:
                        {
                            del += new OurDel(obj.ThirdSpin);
                            break;
                        }
                    case 4:
                        {
                            del += new OurDel(obj.FourthSpin);
                           break;
                        }
                    case 5:
                        {
                            del += new OurDel(obj.FifthSpin);
                            break;
                        }
                    case 6:
                        {
                            del += new OurDel(obj.SixthSpin);
                            break;
                        }
                    case 7:
                        {
                            del += new OurDel(obj.SeventhSpin);
                            break;
                        }
                    case 8:
                        {
                            del += new OurDel(obj.EighthSpin);
                            break;
                        }
                    case 9:
                        {
                            del += new OurDel(obj.NinthSpin);
                            break;
                        }
                    case 10:
                        {
                            del += new OurDel(obj.TenthSpin);
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid Input\nYou Lost One Chance");
                        break;
                }
            }
            Console.Clear();
            del();
            Console.WriteLine("Name : "+name);
            obj.Display();
            Console.ReadKey();



        }
    }
}
