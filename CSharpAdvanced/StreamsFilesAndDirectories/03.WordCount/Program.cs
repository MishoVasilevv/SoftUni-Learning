using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> counters = new Dictionary<string, int>();

            using var sr1 = new StreamReader("words.txt");
            using var sr2 = new StreamReader("text.txt");
            using var sw = new StreamWriter("output.txt");

            var selectedWords = sr1.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var currentWords = sr2.ReadToEnd().Split(new string[] { " ", "-", "?", "!", ".", ",", "...", "\r\n"}, StringSplitOptions.RemoveEmptyEntries);

            int a = 0;

            for (int i = 0; i < selectedWords.Length; i++)
            {
                int counter = 0;
                int b = 0;

                string selectedWord = selectedWords[a];

                for (int j = 0; j < currentWords.Length; j++)
                {
                    string currentWord = currentWords[b];
                    if (currentWord.ToLower() == selectedWord.ToLower())
                    {
                        counter++;
                    }
                    b++;
                }

                a++;
                counters.Add(selectedWord, counter);
            }

            foreach (var word in counters.OrderByDescending(x => x.Value))
            {
                sw.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
