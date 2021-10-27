namespace IntermidiateCSharp
{
    partial class Program
    {
        public class Installer
        {
            private readonly Logger logger;

            public Installer(Logger logger)
            {
                this.logger = logger;
            }

            public void Install()
            {
                logger.Log("The installation is in process");
            }
        }
    }
}
