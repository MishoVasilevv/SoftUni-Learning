using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tiresList = new List<Tire[]>();

            List<Car> cars = new List<Car>();

            string command = Console.ReadLine();

            int counter = 0;

            while (command != "No more tires")
            {
                string[] inputArr = command.Split(" ");

                Tire tire1 = new Tire(int.Parse(inputArr[0]), double.Parse(inputArr[1]));
                Tire tire2 = new Tire(int.Parse(inputArr[2]), double.Parse(inputArr[3]));
                Tire tire3 = new Tire(int.Parse(inputArr[4]), double.Parse(inputArr[5]));
                Tire tire4 = new Tire(int.Parse(inputArr[6]), double.Parse(inputArr[7]));

                Tire[] currentTires = { tire1, tire2, tire3, tire4 };

                tiresList.Add(currentTires);

                counter++;

                command = Console.ReadLine();
            }

            Tire[][] tires = new Tire[counter][];
            Engine[] engines = new Engine[counter];

            int j = 0;

            foreach (var item in tiresList)
            {
                tires[j] = item;

                j++;
            }

            command = Console.ReadLine();

            int y = 0;

            while (command != "Engines done")
            {

                string[] inputArr = command.Split(" ");

                Engine currentEngine = new Engine(int.Parse(inputArr[0]), double.Parse(inputArr[1]));

                engines[y] = currentEngine;

                y++;

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "Show special")
            {
                string[] inputArr = command.Split(" ");

                Car currentCar = new Car(inputArr[0], inputArr[1], int.Parse(inputArr[2]), int.Parse(inputArr[3]), int.Parse(inputArr[4]), engines[int.Parse(inputArr[5])], tires[int.Parse(inputArr[6])]);

                cars.Add(currentCar);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                car.FuelQuantity -= car.FuelConsumption * 0.2;

                double sumOfTirePressure = 0;

                for (int i = 0; i < 4; i++)
                {
                    sumOfTirePressure += car.Tires[i].Pressure;
                }

                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && sumOfTirePressure > 9.0 && sumOfTirePressure < 10.0)
                {
                    Console.WriteLine($@"Make: {car.Make}
Model: {car.Model}
Year: {car.Year}
HorsePowers: {car.Engine.HorsePower}
FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}
