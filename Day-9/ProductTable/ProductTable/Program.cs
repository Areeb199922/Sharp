using System;
using System.Data;
using System.Data.SqlClient;
namespace DataReaderEx
{
    class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader srdr;
        
        static string constr = "server = DESKTOP-IFH8EL7\\SQLEXPRESS; database = Product; trusted_connection = true";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "select top 3 * from Products"
                };
                con.Open();
                srdr = cmd.ExecuteReader();
                Console.WriteLine("PID \t PName \t\t PPrice \t MfDate \t\t ExpDate");
                while (srdr.Read())
                {
                    Console.Write(srdr["PId"] + "\t");
                    Console.Write(srdr["PName"] + "\t");
                    Console.Write(srdr["PPrice"] + "\t\t");
                    Console.Write(srdr["MdDate"] + "\t");
                    Console.Write(srdr["ExpDate"] + "\t");
                    Console.WriteLine("\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally

            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}