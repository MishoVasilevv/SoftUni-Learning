using System;
using PersonInfo;

namespace DefineAnInterfaceIPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            IPerson person = new Citizen(name, age);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            double a = 5.98;
            double b = 15.89;

            double sum = a + b;

            Console.WriteLine($"The sum is equal to: {sum:f3}");
        }
    }
}
