using System;
using System.Collections.Generic;

namespace DatabaseConnection
{
    public class DbCommand
    {
        
        private readonly IList<DbConnection> connections;
        

        public DbCommand(DbConnection connection)
        {
            
                connections = new List<DbConnection>();
                connections.Add(connection);
                if (connections.Count <= 0)
                {
                throw new NullReferenceException();
                }
        }

     

        public void Execute()
        {
            foreach(var exe in connections)
            {
                exe.OpenConnection();
                exe.CloseConnection();
            }
            

        }


    }
}       
