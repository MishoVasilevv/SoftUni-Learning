using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine()
                    .Split(" ");

                string name = inputArr[0];
                int age = int.Parse(inputArr[1]);

                Person currentPerson = new Person(name, age);

                family.AddMember(currentPerson);
            }

            family.OrderByName();
        }
    }
}

