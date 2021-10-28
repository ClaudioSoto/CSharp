using System;
using System.Collections.Generic;
using System.Text;

namespace IntermidiateCSharp.EjerciciosP4
{
    public class SendEmail : IActivityWorkflow
    {
        public void Execute(Activity activity)
        {
            Console.WriteLine("Sending Email to client...");
        }
    }
}
