using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public static void CanMoveDistance(Dictionary<string, Car> cars, string model, int distance)
        {
            if (cars.ContainsKey(model))
            {
                if (cars[model].FuelAmount - (cars[model].FuelConsumptionPerKilometer * distance) > 0)
                {
                    cars[model].FuelAmount -= cars[model].FuelConsumptionPerKilometer * distance;

                    cars[model].TravelledDistance += distance;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }
    }
}
