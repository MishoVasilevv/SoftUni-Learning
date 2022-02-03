using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model, string speed, string power, string weight, string type, string tire1Pressure, string tire1Age, string tire2Pressure, string tire2Age, string tire3Pressure, string tire3Age, string tire4Pressure, string tire4Age)
        {
            Model = model;
            Engine = new Engine(int.Parse(speed), int.Parse(power));
            Cargo = new Cargo(int.Parse(weight), type);
            Tyres = new Tire[4];

            Tyres[0] = new Tire(double.Parse(tire1Pressure), int.Parse(tire1Age));
            Tyres[1] = new Tire(double.Parse(tire2Pressure), int.Parse(tire2Age));
            Tyres[2] = new Tire(double.Parse(tire3Pressure), int.Parse(tire3Age));
            Tyres[3] = new Tire(double.Parse(tire4Pressure), int.Parse(tire4Age));
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tyres { get; set; }
    }
}
