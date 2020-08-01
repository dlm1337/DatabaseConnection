using System;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {

       


        public override void OpenConnection()
        {
            Console.WriteLine("SqlConnection is now open.");
            
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SqlConnection is now closed.");
        }
    }





}
