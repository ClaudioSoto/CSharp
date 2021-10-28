using System;

namespace IntermidiateCSharp.Polymorphism
{
    public class Circulo : Forma
    {
        public override void Area()
        {
            Console.WriteLine("PI * R^2 ES EL AREA DEL CIRUCLO");
        }

        public override void Draw()
        {
            Console.WriteLine("Asi se pinta un circulo");
        }
    }
}
