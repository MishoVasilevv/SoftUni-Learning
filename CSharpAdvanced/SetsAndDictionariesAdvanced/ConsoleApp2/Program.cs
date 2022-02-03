using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> numbers = new Dictionary<double, int>();

            double[] array = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                double currentNumber = array[i];

                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(currentNumber, 0);
                }

                numbers[currentNumber] += 1;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
