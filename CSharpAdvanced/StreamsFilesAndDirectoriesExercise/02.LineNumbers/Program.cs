using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                int totalChars = lines[i]
                    .Count(symbol => char.IsLetter(symbol));

                int totalPunct = lines[i]
                    .Count(symbol => char.IsPunctuation(symbol));

                File.AppendAllText("output.txt", $"Line {i + 1}: {lines[i]} ({totalChars})({totalPunct}){Environment.NewLine}");
            }
        }
    }
}
