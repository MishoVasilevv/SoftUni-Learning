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
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            string[] text = File.ReadAllLines("text.txt");
            string[] selectedWords = File.ReadAllLines("words.txt");

            foreach (var word in selectedWords)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount.Add(word, 0);
                }
            }

            foreach (var line in text)
            {
                foreach (var word in selectedWords)
                {
                    if (line.Contains(word, StringComparison.OrdinalIgnoreCase))
                    {
                        wordsCount[word]++;
                    }
                }
            }

            foreach (var item in wordsCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("actualResults.txt", $"{item.Key} - {item.Value}{Environment.NewLine}");
            }
        }
    }
}
