using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArray = Console.ReadLine().Split(" ");

                string currentContinent = inputArray[0];
                string currentCountry = inputArray[1];
                string currentCity = inputArray[2];

                if (!continents.ContainsKey(currentContinent))
                {
                    continents.Add(currentContinent, new Dictionary<string, List<string>>());
                }

                if (!continents[currentContinent].ContainsKey(currentCountry))
                {
                    continents[currentContinent].Add(currentCountry, new List<string>());
                }

                continents[currentContinent][currentCountry].Add(currentCity);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
