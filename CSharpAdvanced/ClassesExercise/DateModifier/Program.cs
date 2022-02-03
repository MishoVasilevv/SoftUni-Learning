using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int result = DateModifier.DifferenceBetweenTwoDates(firstDate, secondDate);

            Console.WriteLine(result);
        }
    }
}
