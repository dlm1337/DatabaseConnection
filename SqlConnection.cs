using System;
using System.Threading;


namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connected, TimeSpan start)
        {
            ConnectionString = connected;
            TimeOut = start;
            OpenConnection();
            CloseConnection();
        }



        public override void OpenConnection()
        {
            Console.WriteLine("SqlConnection is now open.");
            for (int x = 0; TimeOut >= TimeSpan.FromSeconds(x); x++)
            {

                Thread.Sleep(1000);
                TimeOut.Subtract(TimeSpan.FromSeconds(1));
            }

            Console.WriteLine("You have timed out.");
           
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SqlConnection is now closed.");
         
        }
    }





}
