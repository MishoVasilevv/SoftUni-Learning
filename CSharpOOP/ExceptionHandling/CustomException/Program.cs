using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            string personName = Console.ReadLine();

            foreach (char character in personName)
            {
                if (char.IsDigit(character))
                {
                    throw new InvalidPersonNameException("The Person Name should not contain digits!");
                }
            }
        }
    }
}
