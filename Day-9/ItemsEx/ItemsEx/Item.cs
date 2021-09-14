using System;
using System.Data;
using System.Data.SqlClient;

namespace ItemsEx
{
    class Item
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader srdr;
        static string conStr = "server = DESKTOP-IFH8EL7\\SQLEXPRESS;database = myDb;trusted_connection = true;";

        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conStr);
                cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandText = "dispDesc",
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                Console.WriteLine("Table is as follows\n");
                srdr = cmd.ExecuteReader();
                Console.WriteLine("ID \tName \tPrice \tCompany  Quantity");
                Console.WriteLine("------------------------------------------");
                
                while (srdr.Read())
                {
                    Console.Write(srdr["ItemId"]+"\t");
                    Console.Write(srdr["ItemName"] + "\t");
                    Console.Write(srdr["ItemPrice"] + "\t");
                    Console.Write(srdr["ItemCompany"] + "\t   ");
                    Console.WriteLine(srdr["ItemQuant"] + "\t");
                    
                }
                

            }
            catch (SqlException se)
            {
                Console.WriteLine("Error !!! " + se.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error !!! " + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }

        }
    }
}
