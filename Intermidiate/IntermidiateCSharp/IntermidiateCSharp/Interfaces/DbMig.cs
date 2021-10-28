using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IntermidiateCSharp.Interfaces
{
    public class DbMig
    {
        private readonly ILogger _logger;

        public DbMig(ILogger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            //Console.WriteLine("The migration started at: {0}",DateTime.Now);
            _logger.LogInfo("The migration started at: " + DateTime.Now);
            Thread.Sleep(5000);
            //Console.WriteLine("The migration finished at: {0}", DateTime.Now);
            _logger.LogInfo("The migration finished at: " + DateTime.Now);
        }
    }
}
