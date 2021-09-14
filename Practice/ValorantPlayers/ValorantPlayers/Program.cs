using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantPlayers
{
    class Program
    {
        static ValoDBEntities db;
        static ValoPlayer vp;
        static void Main(string[] args)
        {
            string choice = "n";
            do 
            {
                Console.WriteLine("----------------------------VALORANT PRO PLAYERS-------------------------------------");
                Console.WriteLine("\nChoose Operation from the menu below");
                Console.WriteLine("1. Display All\n2. Insert New Player\n3. Delete A Player\n4. Update Player Info");
                int n = int.Parse(Console.ReadLine());
                db = new ValoDBEntities();
                vp = new ValoPlayer();
                switch (n)
                {
                    case 1:
                        {
                           
                            foreach (ValoPlayer p in db.ValoPlayers)
                            {
                                Console.WriteLine("Player ID : "+p.PID);
                                Console.WriteLine("Name : "+p.PName);
                                Console.WriteLine("Team : "+p.PTeam);
                                Console.WriteLine("Region : "+p.PRegion);
                                Console.WriteLine("\n-----------------------------------------");
                            }
                            break;
                        }

                    case 2:
                        {
                            try
                            {
                                
                                Console.Write("Enter new player ID : ");
                                vp.PID = int.Parse(Console.ReadLine());
                                Console.Write("Enter new player Name : ");
                                vp.PName = Console.ReadLine();
                                Console.Write("Enter new player Team : ");
                                vp.PTeam = Console.ReadLine();
                                Console.Write("Enter new player region : ");
                                vp.PRegion = Console.ReadLine();
                                db.ValoPlayers.Add(vp);
                                db.SaveChanges();
                                Console.WriteLine("!!!!!!!!!!! Record Created Successfully !!!!!!!!!!!!!");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error !!! "+ex.Message);
                            }
                            finally
                            {
                                db.Dispose();
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.Write("Enter Player ID to delete his/her record : ");
                            int id = int.Parse(Console.ReadLine());
                            ValoPlayer tbr = db.ValoPlayers.Where(i => i.PID == id).FirstOrDefault();
                            if (tbr != null)
                            {
                                db.ValoPlayers.Remove(tbr);
                                db.SaveChanges();
                                Console.WriteLine("Record for Player ID {0} deleted Successfully", id);
                            }
                            else
                            {
                                Console.WriteLine("Player ID {0} does not exists",id);
                            }
                            
                            break;
                        }

                    case 4:
                        {
                            Console.Write("Enter Player ID for which you want to update records : ");
                            int id = int.Parse(Console.ReadLine());
                            vp = db.ValoPlayers.Where(i => i.PID == id).FirstOrDefault();

                            if (vp != null)
                            {
                                Console.Write("Enter new Name : ");
                                vp.PName = Console.ReadLine();
                                Console.Write("Enter New Team : ");
                                vp.PTeam = Console.ReadLine();
                                Console.Write("Enter Region : ");
                                vp.PRegion = Console.ReadLine();
                                db.SaveChanges();
                                Console.WriteLine("Record Updated Successfully");
                            }
                            else
                            {
                                Console.WriteLine("Player ID {0} does not exists",id);
                            }

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!! Invalid Entry !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            break;
                        }
                }
                Console.WriteLine("To continue press Y ...........");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
            } 
            while (choice == "y");
            db.Dispose();
            Console.ReadKey();
        }
    }
}
