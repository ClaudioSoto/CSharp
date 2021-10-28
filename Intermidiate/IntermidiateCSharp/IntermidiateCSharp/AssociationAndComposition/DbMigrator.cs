using IntermidiateCSharp.Interfaces;

namespace IntermidiateCSharp
{
    partial class Program
    {
        public class DbMigrator
        {
            private readonly Logger logger;
            private ConsoleLogger consoleLogger;

            public DbMigrator(Logger logger)
            {
                this.logger = logger;
            }

            public DbMigrator(ConsoleLogger consoleLogger)
            {
                this.consoleLogger = consoleLogger;
            }

            public void Migrate()
            {
                logger.Log("The migrations is in progress");
            }
        }
    }
}
