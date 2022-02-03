using System;
using System.Collections.Generic;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            List<Robot> robots = new List<Robot>();

            string command = Console.ReadLine();

            while (command.ToUpper() != "END")
            {
                string[] input = command.Split(" ");

                if (input.Length == 2)
                {
                    Robot currentRobot = new Robot(input[0], input[1]);

                    robots.Add(currentRobot);
                }
                else
                {
                    Citizen currentCitizen = new Citizen(input[0], int.Parse(input[1]), input[2]);

                    citizens.Add(currentCitizen);
                }

                command = Console.ReadLine();
            }

            string detainableNumber = Console.ReadLine();

            foreach (var citizen in citizens)
            {
                citizen.CanDetain(detainableNumber);
            }

            foreach (var robot in robots)
            {
                robot.CanDetain(detainableNumber);
            }
        }
    }
}
