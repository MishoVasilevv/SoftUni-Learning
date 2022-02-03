using System;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader(@"text.txt");
            var symbols = new[] { "-", ",", ".", "!", "?" };
            int i = 0;

            while (!sr.EndOfStream)
            {
                var currentLine = sr.ReadLine();

                if (i % 2 != 0)
                {
                    i++;
                    continue;
                }

                foreach (var symbol in symbols)
                {
                    currentLine = currentLine.Replace(symbol, "@");
                }

                Console.WriteLine(String.Join(" ", currentLine.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse()));

                i++;
            }
        }
    }
}
