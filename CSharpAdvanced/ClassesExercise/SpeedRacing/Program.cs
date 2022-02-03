using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //Input
                //"{model} {fuelAmount} {fuelConsumptionFor1km}"

                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumptionFor1km = double.Parse(tokens[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);

                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, currentCar);
                }

            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                //"Drive {carModel} {amountOfKm}"

                string[] tokens = command.Split(" ");

                string carModel = tokens[1];
                int amountOfKilometer = int.Parse(tokens[2]);

                Car.CanMoveDistance(cars, carModel, amountOfKilometer);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                //Print
                //"{model} {fuelAmount} {distanceTraveled}"

                Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:F2} {car.Value.TravelledDistance}");
            }
        }
    }
}
