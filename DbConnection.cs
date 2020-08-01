using System;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {

        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }





}
