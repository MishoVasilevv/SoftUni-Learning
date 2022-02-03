using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("Input.txt");

            int n = 0;

            while (!reader.EndOfStream)
            {
                string currentLine = reader.ReadLine();

                if (!(n % 2 == 0))
                {
                    Console.WriteLine(currentLine);
                }

                n++;
            }
        }
    }
}
