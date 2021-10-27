using System;

namespace IntermidiateCSharp
{
    partial class Program
    {
        public class Car : Vehicle
        {
            //BASE ES PARA HACERLE SABER QUE CONSTRUCTOR PADRE VA A EJECUTAR Y SI NECESITA PARAMETROS
            public Car(string registrationNumber)
                : base(registrationNumber)
            {
                Console.WriteLine("The car has been initialized with the register number: {0}",registrationNumber);
            }
        }
    }
}
