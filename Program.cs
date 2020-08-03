using System;


namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var startConnection = new DbCommand(new SqlConnection("Connection String", TimeSpan.FromSeconds(20)));
            startConnection.Execute();
            Console.ReadLine();
         
        }
    }
}
