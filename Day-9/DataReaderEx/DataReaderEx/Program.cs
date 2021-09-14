//--------------------EXAMPLE OF DATA READER------------------------------------//

//using System;
//using System.Data;
//using System.Data.SqlClient;
//namespace DataReaderEx
//{
//    class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataReader srdr;
//        // ----- Use two \\(back slashes) where there is only one in the server name-------//
//        //---with windows authentication write "trusted_connection = true"----//
//        //----with sql server authentication write username = "" and password = ""------//
//        static string constr = "server = DESKTOP-IFH8EL7\\SQLEXPRESS; database = OurDb; trusted_connection = true";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(constr);
//                cmd = new SqlCommand
//                {
//                    Connection = con,
//                    CommandText = "select * from Emp"
//                };
//                con.Open();
//                srdr = cmd.ExecuteReader();
//                Console.WriteLine("ID \t Name \t Salary \t Date of Joining");
//                while (srdr.Read())
//                {
//                    Console.Write(srdr["EmpId"] + "\t");
//                    Console.Write(srdr["EmpName"] + "\t");
//                    Console.Write(srdr["EmpSalary"] + "\t\t");
//                    Console.Write(srdr["EmpDOJ"] + "\t");
//                    Console.WriteLine("\n");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!" + ex.Message);
//            }
//            finally

//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}



//-----------------------------------------------EXAMPLE OF DATA ADAPTER--------------------------------------//
using System;
using System.Data;
using System.Data.SqlClient;
namespace DataReaderEx
{
    class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter sda;
        static DataSet ds;
        // ----- Use two \\ where there is only one in th server name-------//
        //---with windows authentication write "trusted_connection = true"----//
        //----with sql server authentication write username = "" and password = ""------//
        static string constr = "server = DESKTOP-IFH8EL7\\SQLEXPRESS; database = OurDb; trusted_connection = true";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "select * from Emp2 where EmpId = @id";//to select a specific id
                Console.WriteLine("Enter Employee ID to find out details : ");
                int id = int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@id",id);
                
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                con.Open();
                sda.Fill(ds);
                con.Close();

                //---------------------To display full table with command text = select * from Emp-------------------//
                //Console.WriteLine("ID \t Name \t Salary \t Date of Joining");
                //for(int i=0;i<ds.Tables[0].Rows.Count;i++)
                //{
                //    Console.Write(ds.Tables[0].Rows[i]["EmpId"]+"\t");
                //    Console.Write(ds.Tables[0].Rows[i]["EmpName"] + "\t");
                //    Console.Write(ds.Tables[0].Rows[i]["EmpSalary"] + "\t\t");
                //    Console.Write(ds.Tables[0].Rows[i]["EmpDOJ"] + "\t");
                //    Console.WriteLine("\n");
                //}

                //---------------To display specific data asked by user-----------------------------------//
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Console.WriteLine("ID \t Name \t Salary \t Date of Joining");


                    Console.Write(ds.Tables[0].Rows[0]["EmpId"] + "\t");
                    Console.Write(ds.Tables[0].Rows[0]["EmpName"] + "\t");
                    Console.Write(ds.Tables[0].Rows[0]["EmpSalary"] + "\t\t");
                    Console.Write(ds.Tables[0].Rows[0]["EmpDOJ"] + "\t");
                    Console.WriteLine("\n");

                }
                else 
                {
                    Console.WriteLine("No data exist for ID : "+id);
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
