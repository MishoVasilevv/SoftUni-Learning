using System;
using System.Collections.Generic;

namespace Stacks_And_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();

            string command = Console.ReadLine();

            while (command.ToUpper() != "END")
            {
                if (command.ToUpper() == "PAID" && people.Count >= 1)
                {
                    while (people.Count > 0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
