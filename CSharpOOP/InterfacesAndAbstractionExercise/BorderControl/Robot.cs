using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }

        public string Id { get; set; }

        public void CanDetain(string number)
        {
            if (this.Id.Substring(this.Id.Length - number.Length) == number)
            {
                Console.WriteLine(this.Id);
            }
        }
    }
}
