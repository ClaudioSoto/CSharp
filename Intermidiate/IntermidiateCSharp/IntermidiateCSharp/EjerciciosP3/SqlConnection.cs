using System;
using System.Collections.Generic;
using System.Text;

namespace IntermidiateCSharp.EjerciciosP3
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection)
            : base(connection)
        {

        }
        public override void Connect()
        {
            Console.WriteLine("The connection for SQL is correct");
        }

        public override void Disconnect()
        {
            Console.WriteLine("SQL is closed");
        }
    }
}
