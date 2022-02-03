using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person Peter = new Person();

            Peter.Name = "Peter";
            Peter.Age = 20;
        }
    }
}
