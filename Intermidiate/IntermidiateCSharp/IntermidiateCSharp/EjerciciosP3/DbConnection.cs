using System;
using System.Collections.Generic;
using System.Text;

namespace IntermidiateCSharp.EjerciciosP3
{
    public abstract class DbConnection
    {
        public String Connection;
        public TimeSpan time;

        public DbConnection(string connection)
        {
            if(connection != null || connection != "")
            {
                Console.WriteLine("Valid input for connection");
                this.Connection = connection;
                this.time = TimeSpan.Zero;
            }
            else
            {
                throw new Exception();
            }
        }

        public abstract void Connect();
        public abstract void Disconnect();
    }
}
