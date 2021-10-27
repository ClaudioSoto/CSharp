using System.Collections.Generic;

namespace IntermidiateCSharp
{
    partial class Program
    {
        public class Person
        {
            //crear setters y getters
            private string _name;

            //usar propiedades creadas y automaticas
            public int Age { get; set; }

            //usar propiedades y definirlas uno mismo
            public string Voice
            {
                get
                {
                    return "My voice is beautiful";
                }
            }

            //usar index para acceder a las propiedades
            private Dictionary<string, string> _dict = new Dictionary<string, string>();
            public string this[string key] { set { _dict[key] = value; } get { return _dict[key]; } }


            public void SetName(string name)
            {
                this._name = name;
            }

            public string GetName()
            {
                return _name;
            }
        }
    }
}
