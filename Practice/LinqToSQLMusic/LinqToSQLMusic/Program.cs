using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQLMusic
{
    class Program
    {
        static PlaylistDataContext playlistData = new PlaylistDataContext();
        static void Main(string[] args)
        {
            
            var songList = playlistData.Songs.OrderByDescending(p=>p.SongName);
          

            Console.WriteLine("ID \t Song Name \t\t Artist Name \t Release Date");
            foreach (var s in songList)
            {
                Console.Write(s.SerialNum+" \t ");
                Console.Write(s.SongName + " \t\t ");
                Console.Write(s.ArtistName + " \t ");
                Console.WriteLine(s.ReleaseDate + " \t ");
            }


            try
            {
                Console.WriteLine("Enter song name to search for song");
                string sName = Console.ReadLine();
                Song match = playlistData.Songs.SingleOrDefault(e => e.SongName.ToLower() == sName.ToLower());
                if (match != null)
                {
                    Console.WriteLine("ID : " + match.SerialNum + " \t ");
                    Console.WriteLine("Song Name : " + match.SongName + " \t\t ");
                    Console.WriteLine("Artist : " + match.ArtistName + " \t ");
                    Console.WriteLine("Release Date : " + match.ReleaseDate + " \t ");
                }
                else
                {
                    Console.WriteLine("Song Unavailable");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error !!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
