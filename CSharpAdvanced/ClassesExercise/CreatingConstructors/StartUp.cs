using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
        }
    }
}
