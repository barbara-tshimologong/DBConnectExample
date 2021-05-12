using System;
using System.Data;
using System.Data.SqlClient;

namespace DBConnectExample
{
    class DBConnectExample
    {
        static void Main(string[] args)
        {

            //Connection
            //-------------------------------------------------------------------------------------------------

            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=AppFactory;Integrated Security=True;";
            

            //Command
            //-------------------------------------------------------------------------------------------------
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = cn;
            
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "SELECT year FROM Cohort WHERE ID = 1";

            cn.Open();

            var result = cmd.ExecuteScalar();
            
            Console.WriteLine(result);

            cn.Close();

            cn.Dispose();
        }
    }
}
