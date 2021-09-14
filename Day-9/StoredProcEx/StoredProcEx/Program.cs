using System;
using System.Data;
using System.Data.SqlClient;

namespace StoredProcEx
{
    class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static string conStr = "server = DESKTOP-IFH8EL7\\SQLEXPRESS;database = OurDb;trusted_connection = true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conStr);
                cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandText = "usp_iEmps",
                    CommandType = CommandType.StoredProcedure//commandn type by default is text so not required to specify explicitily,but we have to now
                };
                Console.WriteLine("Enter Id : ");
                cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));//we have declared variable in stored procedure in sql,so declaring here is not required
                Console.WriteLine("Enter Name : ");
                cmd.Parameters.AddWithValue("@name", Console.ReadLine());
                Console.WriteLine("Enter Salary : ");
                cmd.Parameters.AddWithValue("@salary", double.Parse(Console.ReadLine()));
                Console.WriteLine("Enter DOJ : ");
                cmd.Parameters.AddWithValue("@doj", DateTime.Parse(Console.ReadLine()));
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Inserted");
            }
            catch (SqlException se)
            {
                Console.WriteLine("Error !!! "+se.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error !!! "+ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
