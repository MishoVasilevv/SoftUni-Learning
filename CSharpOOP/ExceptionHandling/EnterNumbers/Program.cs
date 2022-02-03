using System;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            
        }

        public static void ReadNumber(int start, int end)
        {
            string n = Console.ReadLine();

            if (!int.TryParse(n, out int result))
            {
                throw new FormatException("Input is not an int32!");
            }

            if (result < start || result > end)
            {
                throw new ArgumentException("Number out of the given range!");
            }
        }
    }
}
