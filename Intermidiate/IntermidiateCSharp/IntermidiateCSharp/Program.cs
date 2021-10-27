﻿using IntermidiateCSharp.EjerciciosP1;
using System;
using System.Collections.Generic;
using System.Threading;

namespace IntermidiateCSharp
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            Console.WriteLine(customer.Orders.Count);

            //PRIVATE FIELDS AND MODIFIERS
            var person = new Person();
            person.SetName("Claudio Soto");
            Console.WriteLine(person.GetName());

            //PROPERTIES USAGE
            person.Age = 24;
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Voice);
            person["father"] = "Fernando";
            person["mother"] = "Adriana";
            Console.WriteLine("father: {0} - mother: {1}", person["father"], person["mother"]);

            //EJERCICIOS PARTE 1
            //STOPWATCH
            /*
            Watch w = new Watch();
            w.Start();
            Thread.Sleep(5000);
            w.Stop();
            Console.WriteLine(w.time);
            */

            //POST
            /*
            var post = new Post("titulo", "descripcion");
            post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine("el titulo es {0}, la descripcion es {1}, y los votos son {2}", post.Title, post.Description, post.GetVotes());
            */

            //INHERITANCE
            var text = new Text();
            text.HyperLinkToUrl("www.google.com");
            text.Copy();
            text.Duplicate();

            //COMPOSITION
            var logger = new Logger();
            var dbMigrator = new DbMigrator(logger);
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();

            //OOP
            //BASE CONSTRUCTORS ARE ALWAYS EXECUTED FIRST
            //LOS CONSTRUCTORES LE PERTENECEN A LA CLASE Y NO SE PUEDEN HEREDAR
            //SE EJECUTA EL CONSTRUCTOR DE LA CLASE PADRE PRIMERO
            var car = new Car("SK20K");

            //UPCASTING CLASE PADRE EN CLASE HIJO
            Texto texto = new Texto();
            Shape shape = texto;

            //DOWNCASTING CASTEAR CLASE PADRE A CLASE HIJO
            Shape shape2 = new Texto();
            Texto texto2 = (Texto)shape2;

            //TYPES IN C#
            //VALUE TYPES: BYTE, INT, FLOAT, CHAR, DOUBLE , STRUCT ... STORED IN THE STACK SHORT LIFE
            //REFERENCE TYPES: OBJECT, STRING, ARRAY ... STORED IN THE HEAP LONG LIFE

            //BOXING IS THE PROCESS TO CONVERT A VALUE TYPE TO OBJECT REFERENCE
            //THE RESULT IS AN OBJECT REFERENCING A INTEGER STORED IN THE HEAP
            //EXAMPLE:
            int number = 10;
            object obj = number;

            //UNBOXING IS THE PROCESS TO CONVERT A REFERENCE OBJECT INTO A VALUE TYPE
            //THE RESULT IS AN OBJECT POINTING TO A INTEGER STORED IN THE STACK
            //EXAMPLE:
            object obj2 = 20;
            int number2 = (int)obj2;

            //EJERCICIOS PARTE 2
            //STACK
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            Console.ReadKey();
        }
    }
}