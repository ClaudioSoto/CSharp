using System;

namespace IntermidiateCSharp.Polymorphism
{
    public class Cuadrado : Forma
    {
        public override void Area()
        {
            Console.WriteLine("LXL ES EL AREA DEL CIRCULO");
        }

        public override void Draw()
        {
            Console.WriteLine("Asi se pinta un cuadrado");
        }

        
    }
}
