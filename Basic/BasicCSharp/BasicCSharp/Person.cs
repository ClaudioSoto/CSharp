using System;

namespace BasicCSharp
{
    public class Person
    {
        public string Name;
        public string LastName;

        public void Hi()
        {
            Console.WriteLine("Hello my name is {0} {1}",Name,LastName);
        }
    }
}
