using System;

namespace DatabaseConnection
{
    public  class DbConnection
    {

        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }

        public virtual void OpenConnection()
        { 
       
        
        
        }
        public virtual void CloseConnection()
        {
        
        
        
        }

    }





}
