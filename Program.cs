using System;


namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var startConnection = new DbCommand();
            startConnection.Execute(new SqlConnection("Connection String", TimeSpan.FromSeconds(20)));
            startConnection.Execute(new OracleConnection("Connection String", TimeSpan.FromSeconds(20)));
            Console.ReadLine();
        }
    }
}
