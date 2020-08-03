using System;
using System.Collections.Generic;

namespace DatabaseConnection
{
    public class DbCommand
    {

        private readonly IList<DbConnection> connections;

        public DbCommand()
        {
            
                connections = new List<DbConnection>();
           
        }

     

        public void Execute(DbConnection connection)
        {
            connections.Add(connection);
            if (connections.Count <= 0)
            {
                throw new NullReferenceException();
            }
        }


    }
}
