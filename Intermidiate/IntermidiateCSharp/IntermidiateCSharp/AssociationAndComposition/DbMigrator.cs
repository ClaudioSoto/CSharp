namespace IntermidiateCSharp
{
    partial class Program
    {
        public class DbMigrator
        {
            private readonly Logger logger;

            public DbMigrator(Logger logger)
            {
                this.logger = logger;
            }
            public void Migrate()
            {
                logger.Log("The migrations is in progress");
            }
        }
    }
}
