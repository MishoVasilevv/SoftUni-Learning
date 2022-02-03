using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using var sr = new StreamReader(@"Input.txt");
            using var sw = new StreamWriter(@"Output.txt");

            int rowNumber = 1;
            while (!sr.EndOfStream)
            {
                string currentLine = sr.ReadLine();

                sw.WriteLine($"{rowNumber}. {currentLine}");

                rowNumber++;
            }
        }
    }
}
