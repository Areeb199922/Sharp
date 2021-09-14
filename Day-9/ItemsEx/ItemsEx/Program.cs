//using System;
//using System.Data;
//using System.Data.SqlClient;

//namespace ItemsEx
//{
//    class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataReader srdr;
//        static string constr = "server = DESKTOP-IFH8EL7\\SQLEXPRESS; database = myDb; trusted_connection = true";

//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(constr);
//                cmd = new SqlCommand
//                {
//                    Connection = con,
//                    CommandText = "select * from items"
//                };
//                con.Open();
//                srdr = cmd.ExecuteReader();
//                Console.WriteLine("Id \t Name \t Price \t Company \t Quantity");
//                while (srdr.Read())
//                {
//                    Console.Write(srdr["ItemId"] + "\t ");
//                    Console.Write(srdr["ItemName"] + "\t ");
//                    Console.Write(srdr["ItemPrice"] + "\t ");
//                    Console.Write(srdr["ItemCompany"] + "\t\t   ");
//                    Console.WriteLine(srdr["ItemQuant"] + "\t");
//                }
//            }
//            catch(SqlException se)
//            {
//                Console.WriteLine("Error !!! "+se.Message);
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine("Error !!! "+ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}
