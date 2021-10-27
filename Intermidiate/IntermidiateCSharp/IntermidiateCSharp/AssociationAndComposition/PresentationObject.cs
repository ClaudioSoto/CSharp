using System;

namespace IntermidiateCSharp
{
    partial class Program
    {
        public class PresentationObject
        {
            public int Width { get; set; }
            public int Heigth { get; set; }

            public void Copy()
            {
                Console.WriteLine("Copied in the clipboard");
            }

            public void Duplicate()
            {
                Console.WriteLine("The object has been duplicated");
            }
        }
    }
}
