//using System;
//using System.Data;
//using System.Data.SqlClient;
//namespace DeleteExample
//{
//    class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static string constr = "server = DESKTOP-IFH8EL7\\SQLEXPRESS;database = OurDb;trusted_connection = true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(constr);
//                cmd = new SqlCommand
//                {
//                    Connection = con,
//                    CommandText = "delete from Emp where EmpId = @id"
//                };
//                Console.WriteLine("Enter Employee Id to Delete Record : ");
//                int id = int.Parse(Console.ReadLine());
//                cmd.Parameters.AddWithValue("@id", id);
//                con.Open();
//                int nor = cmd.ExecuteNonQuery();
//                if (nor > 0)
//                {
//                    Console.WriteLine("Record Deleted");
//                }
//                else
//                {
//                    Console.WriteLine("There was no such ID {0} in Emp Table",id);
//                }
//            }
//            catch(SqlException se)
//            {
//                Console.WriteLine("Error !!!"+se.Message);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error !!!"+ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}




using System;
using System.Data;
using System.Data.SqlClient;
namespace DeleteExample
{
    class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static string constr = "server = DESKTOP-IFH8EL7\\SQLEXPRESS;database = OurDb;trusted_connection = true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "Update Emp set EmpName = @name,EmpSalary = @salary, EmpDOJ = @doj where EmpId = @id"
                };
                Console.WriteLine("Enter Employee Id to Update Record : ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter New Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter New Salary : ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter new DOJ");
                DateTime doj = DateTime.Parse(Console.ReadLine());

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@doj", doj);
                con.Open();
                int nor = cmd.ExecuteNonQuery();
                if (nor > 0)
                {
                    Console.WriteLine("Record Updated");
                }
                else
                {
                    Console.WriteLine("There was no such ID {0} in Emp Table", id);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Error !!!" + se.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error !!!" + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
