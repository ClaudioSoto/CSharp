using System;

namespace BasicCSharp
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        Registered = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //IMPLICIT TYPE CONVERSION
            byte b = 1;
            int a = b;

            //EXPLICIT TYPE CONVERSION
            int c = 1;
            byte d = (byte)c;

            //WHEN TYOES ARE NOT COMPATIBLE AND TRY TO CAST USE TRY CATCH
            try
            {
                string e = "true";
                bool f = Convert.ToBoolean(e);
                Console.WriteLine(f);
            }
            catch (Exception)
            {
                Console.WriteLine("Not possible");

            }

            //CLASSES AND OBJECTS
            var claudio = new Person();
            claudio.Name = "Claudio";
            claudio.LastName = "Soto";
            claudio.Hi();

            //ARRAY
            int[] numbers = new int[10];
            int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };
            int l = numbers2.Length;
            for(int i=0; i < l; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            //STRINGS
            //FORMAT STRINGS
            string word1 = "hello";
            string word2 = "happy";
            string phrase = string.Format("{0}, I am so {1}",word1,word2);
            Console.WriteLine(phrase);

            //ENUMS
            var shippingMethod = ShippingMethod.Express;
            Console.WriteLine(shippingMethod);
            Console.WriteLine((int)shippingMethod);

            Console.ReadKey();
        }
    }
}
