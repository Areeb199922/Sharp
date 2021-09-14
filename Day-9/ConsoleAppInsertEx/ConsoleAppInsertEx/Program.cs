using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleAppInsertEx
{
    class Program
    {
        static SqlConnection connection;
        static SqlCommand command;
        static void Main(string[] args)
        {
            try
            {
                connection = new SqlConnection("server =DESKTOP-IFH8EL7\\SQLEXPRESS;database=OurDb;trusted_connection = true;");
                command = new SqlCommand()
                {
                    Connection = connection,
                    CommandText = "insert into Emp(EmpId,EmpName,EmpSalary,EmpDOJ)values(@id,@name,@salary,@doj)"
                };
                Console.WriteLine("Enter Employee ID : ");
                command.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter Employee Name : ");
                command.Parameters.AddWithValue("@name", Console.ReadLine());
                Console.WriteLine("Enter Employee Salary : ");
                command.Parameters.AddWithValue("@salary", double.Parse(Console.ReadLine()));
                Console.WriteLine("Enter Employee DOJ : ");
                command.Parameters.AddWithValue("@doj", DateTime.Parse(Console.ReadLine()));
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("-----------------------Record Inserted------------------------------");
            }
            catch(SqlException se)
            {
                Console.WriteLine("Error !!!"+se.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error !!!" + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.ReadKey();
                
            }
        }
    }
}
