using System;
using System.Collections.Generic;
using System.Text;

namespace IntermidiateCSharp.EjerciciosP4
{
    public class Upload : IActivityWorkflow
    {
        public void Execute(Activity activity)
        {
            Console.WriteLine("Upload file to the cload...");
        }
    }
}
