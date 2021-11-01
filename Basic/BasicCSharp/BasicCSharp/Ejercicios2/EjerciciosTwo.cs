using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp.Ejercicios2
{
    public class EjerciciosTwo
    {
        public void DivisibleIn3()
        {
            int l = 100;
            int cont = 0;
            for(int i =0; i<l; i++)
            {
                if((i+1) % 3 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine("Total number of elements is: {0}",cont);
        }

        public void UserSum()
        {
            int cont = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or ok to exit");
                var value = Console.ReadLine();
                if (value.Equals("ok"))
                    break;
                cont += Convert.ToInt32(value);
            }
            Console.WriteLine("The sum is {0}",cont);
        }

        public int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n-1);
        }

        public string RandomGame()
        {
            var randomNumber = new Random();
            int rndNumber = randomNumber.Next(1,10);
            int chances = 4;
            for(int i = chances; i> 0; i--)
            {
                Console.WriteLine("Enter a number:");
                var value = Console.ReadLine();
                Convert.ToInt32(value);
                if (Convert.ToInt32(value) == rndNumber)
                    return "YOU WIN";
            }
            return "YOU HAVE LOST";
        }

    }
}
