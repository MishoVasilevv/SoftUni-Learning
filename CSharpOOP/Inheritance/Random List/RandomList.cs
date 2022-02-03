using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList
        : List<string>
    {
        private List<string> list;

        public RandomList()
        {
            list = new List<string>();
        }

        public string RandomString()
        {
            Random random = new Random();

            int index = random.Next(list.Count);
            list.Remove(list[index]);
            return list[index];
        }
    }
}
