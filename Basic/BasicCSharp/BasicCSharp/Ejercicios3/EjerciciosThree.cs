using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCSharp.Ejercicios3
{
    public class EjerciciosThree
    {


        public void FacebookFriends()
        {
            var friends = new List<string>();
            while (true)
            {
                Console.WriteLine("ENTER A FRIEND OR EMPTY STRING TO EXIT");
                var friend = Console.ReadLine();
                if (friend.Length == 0 || friend == "")
                    break;
                friends.Add(friend);
            }

            switch (friends.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Friend {0} likes your post", friends[0]);
                    break;
                case 2:
                    Console.WriteLine("Friend {0} and {1} likes your post", friends[0], friends[1]);
                    break;
                default:
                    Console.WriteLine("Friend {0} and {1} others {2} likes your post", friends[0], friends[1], friends.Count - 2);
                    break;
            }
        }

        public void ReverseName(string name)
        {
            int l = name.Length - 1;
            char [] reversedName = new char[l+1];
            int index = 0;
            for (int i = l; i >= 0; i--)
            {
                reversedName[index] = name[i];
                index++;
            }
            string result = string.Join("",reversedName);
            Console.WriteLine(result);
        }

        public void UniqueNumbers()
        {
            int l = 5;
            var numbers = new List<int>();
            while(l > 0)
            {
                Console.WriteLine("WRITE 5 UNIQUE NUMBERS");
                var number = Int32.Parse(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("ERROR:The element already exists");
                }
                else
                {
                    numbers.Add(number);
                    l--;
                }
            }
            numbers.Sort();
            foreach(var number in numbers)
                Console.WriteLine(number);
        }

        public void CommaList(string list)
        {
            var numbers = list.Split(',').ToList();
            if (numbers.Count < 5)
            {
                Console.WriteLine("INVALID LIST");
            }
            else
            {
                numbers.Sort();
                for(int i=0; i< 3; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
