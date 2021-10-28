using System;
using System.Collections.Generic;
using System.Text;

namespace IntermidiateCSharp.EjerciciosP3
{
    public class DbCommand
    {
        public string Command;
        public DbConnection Connection;
        public DbCommand(DbConnection connection, string command)
        {
            if(connection == null || (command == null || command == ""))
            {
                throw new Exception();
            }
            this.Command = command;
            this.Connection = connection;
        }

        public void Execute()
        {
            Connection.Connect();
            Console.WriteLine("Run the instruction -> {0}", this.Command);
            Connection.Disconnect();
        }
    }
}
