using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp.Ejercicios5
{
    public class EjerciciosFive
    {
        public void ConsecutiveNumber(string numbers)
        {

            var numbersList = numbers.Split('-');
            int l = numbersList.Length;

            if (l <= 1)
            {
                Console.WriteLine("Valid");
            }

            for (int i = 1; i < l; i++)
            {
                if (!(Convert.ToInt32(numbersList[i - 1]) + 1 == Convert.ToInt32(numbersList[i])))
                {
                    Console.WriteLine("Invalid");
                    return;
                }
            }
            Console.WriteLine("Valid");
        }

        public void Duplicates(string numbers)
        {

            var numbersList = numbers.Split('-');
            var numbersSet = new HashSet<string>(numbersList);

            if (numbersList.Length == numbersSet.Count)
            {
                Console.WriteLine("Unique");
            }
            else
            {
                Console.WriteLine("Duplicates");
            }
        }

        public void ValidTime(string hour)
        {
            if(hour.Length > 5)
            {
                Console.WriteLine("Invalid");
                return;
            }
            var indexSeparator = hour.IndexOf(':');
            var prevHours = Convert.ToInt32(hour.Substring(0,indexSeparator));
            var postMinutes = Convert.ToInt32(hour.Substring(indexSeparator+1, 2));
            if((prevHours < 0 || prevHours > 23) && (postMinutes < 0 || postMinutes > 59))
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }
        }

        public void PascalWords(string text)
        {
            var words = text.Split();
            var pascalNotation = new StringBuilder();
            var character = "";
            var restOfWord = "";

            foreach(var word in words)
            {
                character = word[0].ToString().ToUpper();
                restOfWord = word.Substring(1, word.Length-1).ToLower();
                pascalNotation.Append(character)
                .Append(restOfWord);
            }
            Console.WriteLine(pascalNotation);

        }
    }
}
