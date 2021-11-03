using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BasicCSharp.Ejercicios4
{
    public class EjeciciosFour
    {
        public void WordsCounterFromFile(string pathOrigen)
        {
            if (File.Exists(pathOrigen))
            {
                var content = File.ReadAllText(pathOrigen);
                var words = content.Split();
                Console.WriteLine(words.Length);
            }
            else
            {
                Console.WriteLine("Error: No existe el archivo");
            }
        }

        public void LongestWordInFile(string pathOrigen)
        {
            if (File.Exists(pathOrigen))
            {
                var content = File.ReadAllText(pathOrigen);
                var words = content.Split();
                var longestWord = "";
                foreach(var word in words)
                {
                    if(word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
                Console.WriteLine("The longest word in the file is: {0}",longestWord);
            }
        }
    }
}
