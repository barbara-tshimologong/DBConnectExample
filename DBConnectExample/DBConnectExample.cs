using System;
using System.Data;
using System.Data.SqlClient;

namespace DBConnectExample
{
    class DBConnectExample
    {
        static void Main(string[] args)
        {
            using SqlConnection cn = new(@"Server=(localdb)\MSSQLLocalDB;Database=AppFactory;Integrated Security=True;");
            
            using SqlCommand cmd = new();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT year,isActive FROM Cohort";
            cn.Open();

            Console.WriteLine(cmd.ExecuteScalar());
        }
    }
}
