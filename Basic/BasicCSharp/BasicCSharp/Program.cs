using BasicCSharp.Ejercicios1;
using BasicCSharp.Ejercicios2;
using BasicCSharp.Ejercicios3;
using BasicCSharp.Ejercicios4;
using BasicCSharp.Ejercicios5;
using System;
using System.IO;
using System.Text;

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

            //EJERCICIOS1
            var ejercicios1 = new Ejercicios();
            Console.WriteLine(ejercicios1.ValidNumber(0));
            Console.WriteLine(ejercicios1.ValidNumber(1));
            Console.WriteLine(ejercicios1.ValidNumber(10));


            Console.WriteLine(ejercicios1.ReturnMax(1,0));
            Console.WriteLine(ejercicios1.ReturnMax(0, 1));
            Console.WriteLine(ejercicios1.ReturnMax(0, 0));

            Console.WriteLine(ejercicios1.TypeOfPhoto(1,2));
            Console.WriteLine(ejercicios1.TypeOfPhoto(2, 1));
            Console.WriteLine(ejercicios1.TypeOfPhoto(1, 1));

            Console.WriteLine(ejercicios1.SpeedCamera(50, 49));
            Console.WriteLine(ejercicios1.SpeedCamera(50, 50));
            Console.WriteLine(ejercicios1.SpeedCamera(50, 55));
            Console.WriteLine(ejercicios1.SpeedCamera(50, 300));

            //ITERATION AND LOOPS
            int [] arrayNumbers = { 1,2,3};
            int len = arrayNumbers.Length;
            for(int i = 0; i<len; i++)
            {
                Console.WriteLine(arrayNumbers[i]);
            }

            foreach(var num in arrayNumbers)
            {
                Console.WriteLine(num);
            }

            int j = 0;
            while(j < len)
            {
                Console.WriteLine(arrayNumbers[j]);
                j++;
            }

            //EJERCICIOS2
            /*
            var ejecicios2 = new EjerciciosTwo();
            ejecicios2.DivisibleIn3();
            ejecicios2.UserSum();
            Console.WriteLine(ejecicios2.Factorial(5));
            Console.WriteLine(ejecicios2.RandomGame());
            */

            //EJERCICIOS3
            /*
            var ejercicios3 = new EjerciciosThree();
            ejercicios3.FacebookFriends();
            ejercicios3.ReverseName("claudio soto ayala");
            ejercicios3.UniqueNumbers();
            ejercicios3.CommaList("1,2,3,4,5");
            */

            //DATETIME
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;

            Console.WriteLine(now.Year);
            Console.WriteLine(now.Day);
            Console.WriteLine(now.Month);

            Console.WriteLine(now.ToString("yyyy-dd-MM"));

            //TIMESPAN
            var timeSpan = new TimeSpan(1,45,20);
            Console.WriteLine("Minutos: " + timeSpan.Minutes);
            Console.WriteLine("Minutos totales: " + timeSpan.TotalMinutes);

            //FILES AND DIRECTORIES
            var pathOrigen = @"C:\Users\claudio.sotoayala\Desktop\Misc\C#\Basic\BasicCSharp\BasicCSharp\Files\entrenamiento.txt";
            var pathDestino = @"C:\Users\claudio.sotoayala\Desktop\Misc\C#\Basic\BasicCSharp\BasicCSharp\Files\destino.txt";
            
            if (File.Exists(pathDestino))
            {
                File.Delete(pathDestino);
            }
            File.Copy(pathOrigen, pathDestino);
            var content = File.ReadAllText(pathDestino);
            Console.WriteLine(content);

            //DIRECTORY
            var pathDirectoryOrigen = @"C:\Users\claudio.sotoayala\Desktop\Misc\C#\Basic\BasicCSharp\BasicCSharp\Files\Test\Test2";
            if (!Directory.Exists(pathDirectoryOrigen))
            {
                Directory.CreateDirectory(pathDirectoryOrigen);
            }
            
            for(int i=0; i<5; i++)
            {
                string name = string.Format(@"\test{0}.txt", i.ToString());
                string pathFilesDestiny = pathDirectoryOrigen + name;
                if (File.Exists(pathFilesDestiny))
                {
                    File.Delete(pathFilesDestiny);
                }
                else
                {
                    File.Create(pathFilesDestiny);
                } 
            }

            var files = Directory.GetFiles(pathDirectoryOrigen);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }

            //PATH 
            var fileName = Path.GetFileName(pathOrigen);
            var extension = Path.GetExtension(pathOrigen);
            Console.WriteLine("el nombre es {0} y la extension es {1}",fileName, extension);

            //EJERCICIOS 4
            var ejeciciosCuatro = new EjeciciosFour();
            ejeciciosCuatro.WordsCounterFromFile(pathOrigen);
            ejeciciosCuatro.LongestWordInFile(pathOrigen);

            //STRINGS
            var stringBuilder = new StringBuilder();
            stringBuilder.Append('+', 10);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Hello");
            stringBuilder.Append('+', 10);
            Console.WriteLine(stringBuilder);

            //EJERCICIOS 5
            var ejercicios5 = new EjerciciosFive();
            ejercicios5.ConsecutiveNumber("1-2-3-4-5-6");
            ejercicios5.ConsecutiveNumber("1-2-3-5-4-6");
            ejercicios5.ConsecutiveNumber("1-2-3-4-5-9");
            ejercicios5.Duplicates("1-2-3-4-5-6");
            ejercicios5.Duplicates("1-2-3-4-4-6");
            ejercicios5.Duplicates("1-6-3-4-4-6");
            ejercicios5.ValidTime("12:23");
            ejercicios5.ValidTime("00:59");
            ejercicios5.ValidTime("24:60");
            ejercicios5.ValidTime("240:600");
            ejercicios5.PascalWords("claudio soto");
            ejercicios5.PascalWords("Claudio Soto");
            ejercicios5.PascalWords("cLAUDIO sOTO");
            ejercicios5.PascalWords("cLaUdIo sOtO");

            Console.ReadKey();
        }
    }
}
