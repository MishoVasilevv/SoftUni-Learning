using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IDetainable
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; set; }

        public int Age { get; set; }

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
