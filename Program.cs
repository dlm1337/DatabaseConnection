using System;
using System.Dynamic;

namespace DatabaseConnection
{

    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection();
            connection.CloseConnection();
            var connection2 = new OracleConnection("connection string", TimeSpan.FromSeconds(20));
            connection2.OpenConnection();
            

          
            
        }
    }
}
