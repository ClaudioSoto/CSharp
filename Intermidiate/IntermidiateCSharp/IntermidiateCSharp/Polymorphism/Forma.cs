using System;
using System.Collections.Generic;
using System.Text;

namespace IntermidiateCSharp.Polymorphism
{
    //CLASE ABSTRACTA QUE TIENE AL MENOS UN METODO ABSTRACTO SIN IMPLEMENTACION
    //Y OBLIGA A LAS CLASES QUE LA HEREDAN A IMPLMENETARLOS
    //LAS CLASES ABSTRACTAS NO PUEDEN CREAR OBJETOS
    public abstract class Forma
    {
        public virtual void Draw()
        {
            Console.WriteLine("Se dibujo una figura");
        }

        public abstract void Area();
    }
}
