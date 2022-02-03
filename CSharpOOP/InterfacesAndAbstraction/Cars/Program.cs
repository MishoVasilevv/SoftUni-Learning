using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Seat("Red", "Ibiza");

            Console.WriteLine(car1.Start());
            Console.WriteLine(car1.Stop());

            Car car2 = new Tesla("White", "S");

            Console.WriteLine(car2.Start());
            Console.WriteLine(car2.Stop());
        }
    }
}
