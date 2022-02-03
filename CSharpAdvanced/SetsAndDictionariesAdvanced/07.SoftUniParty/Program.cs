using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();

            while (command?.ToUpper() != "END")
            {
                char[] charArray = command.ToCharArray();
                char currentFirstLetter = charArray[0];

                if (Char.IsLetter(currentFirstLetter))
                {
                    regular.Add(command);
                }
                else
                {
                    vip.Add(command);
                }

                if (command?.ToUpper() == "PARTY")
                {
                    break;
                }

                command = Console.ReadLine();
            }

            while (command?.ToUpper() != "END")
            {
                char[] charArray = command.ToCharArray();
                char currentFirstLetter = charArray[0];

                if (Char.IsLetter(currentFirstLetter))
                {
                    regular.Remove(command);
                }
                else
                {
                    vip.Remove(command);
                }

                command = Console.ReadLine();
            }

            int totalCount = vip.Count + regular.Count;

            Console.WriteLine(totalCount);

            foreach (var guesst in vip)
            {
                Console.WriteLine(guesst);
            }

            foreach (var guesst in regular)
            {
                Console.WriteLine(guesst);
            }
        }
    }
}
