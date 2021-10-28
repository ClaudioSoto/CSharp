using System;
using System.Collections.Generic;
using System.Text;

namespace IntermidiateCSharp.EjerciciosP4
{
    public class EncodingService : IActivityWorkflow
    {
        public void Execute(Activity activity)
        {
            Console.WriteLine("Searching for the encoding service...");
        }
    }
}
