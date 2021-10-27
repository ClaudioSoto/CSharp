using System;

namespace IntermidiateCSharp
{
    partial class Program
    {
        public class Vehicle
        {
            private readonly string registrationNumber;

            /*
            public Vehicle()
            {
                Console.WriteLine("The vehicle has been initialized");
            }
            */
            public Vehicle(string registrationNumber)
            {
                this.registrationNumber = registrationNumber;
                Console.WriteLine("The vehicle has been initialized with register number {0}", this.registrationNumber);
            }
        }
    }
}
