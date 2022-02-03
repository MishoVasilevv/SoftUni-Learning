using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine().Split(" ");

                string model = inputArr[0];
                int power = int.Parse(inputArr[1]);
                int displacement = int.Parse(inputArr[2]);
                string efficiency = inputArr[3];

                engines.Add(currentEngine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {

            }
        }
    }
}
