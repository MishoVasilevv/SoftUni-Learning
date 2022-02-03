using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine().Split(" ").ToArray();

                string model = inputArr[0];
                string speed = inputArr[1];
                string power = inputArr[2];
                string weight = inputArr[3];
                string type = inputArr[4];
                string pressure1 = inputArr[5];
                string age1 = inputArr[6];
                string pressure2 = inputArr[7];
                string age2 = inputArr[8];
                string pressure3 = inputArr[9];
                string age3 = inputArr[10];
                string pressure4 = inputArr[11];
                string age4 = inputArr[12];

                Car currentCar = new Car(model, speed, power, weight, type, pressure1, age1, pressure2, age2, pressure3, age3, pressure4, age4);

                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            if (command.ToUpper() == "FRAGILE")
            {
                foreach (var car in cars)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (car.Tyres[i].Pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (var car in cars)
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
