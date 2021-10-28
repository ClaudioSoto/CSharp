using System;
using System.Collections.Generic;
using System.Text;

namespace IntermidiateCSharp.EjerciciosP3
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection)
            : base(connection)
        {
        }

        public override void Connect()
        {
            Console.WriteLine("The connection for Oracle is correct");
        }

        public override void Disconnect()
        {
            Console.WriteLine("Oracle is closed");
        }
    }
}
