using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToUpper();

            HashSet<string> carNumbers = new HashSet<string>();

            while (command != "END")
            {
                string[] inputArray = command.Split(", ");

                string inOut = inputArray[0];
                string currentCarNumber = inputArray[1];

                if (inOut == "IN")
                {
                    carNumbers.Add(currentCarNumber);
                }
                else
                {
                    carNumbers.Remove(currentCarNumber);
                }

                command = Console.ReadLine().ToUpper();
            }

            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }

            foreach (var carNumber in carNumbers)
            {
                Console.WriteLine(carNumber);
            }
        }
    }
}
