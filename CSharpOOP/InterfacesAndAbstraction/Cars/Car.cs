using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car
    {
        protected Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; protected set; }

        public string Color { get; protected set; }

        public virtual string Start()
        {
            return "Vroom...Vroom";
        }

        public virtual string Stop()
        {
            return "Stooooop...";
        }
    }
}
