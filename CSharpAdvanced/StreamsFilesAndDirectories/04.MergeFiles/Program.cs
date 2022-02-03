using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            using var sr1 = new StreamReader(@"FileOne.txt");
            using var sr2 = new StreamReader(@"FileTwo.txt");
            using var sw = new StreamWriter(@"Output.txt");

            while (!sr1.EndOfStream)
            {
                string num = sr1.ReadLine();

                list.Add(num);
            }
            while (!sr2.EndOfStream)
            {
                string num = sr2.ReadLine();

                list.Add(num);
            }

            foreach (var number in list.OrderBy(x => x))
            {
                sw.WriteLine(number);
            }
        }
    }
}
