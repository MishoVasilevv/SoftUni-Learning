using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> allFiles = new Dictionary<string, Dictionary<string, double>>();

            string[] directoryFiles = Directory.GetFiles("../../../", ".");

            foreach (var file in directoryFiles)
            {
                FileInfo fileInfo = new FileInfo(file);

                string currentFileExtension = fileInfo.Extension;
                string currentFileName = fileInfo.Name;
                double currentFileLength = (double)fileInfo.Length / 1024.0;


                if (!allFiles.ContainsKey(fileInfo.Extension))
                {
                    allFiles.Add(fileInfo.Extension, new Dictionary<string, double>());
                }

                if (currentFileName.Contains(currentFileExtension))
                {
                    if (!allFiles[currentFileExtension].ContainsKey(currentFileName))
                    {
                        allFiles[currentFileExtension].Add(currentFileName, currentFileLength);
                    }
                }
            }

            List<string> lines = new List<string>();

            foreach (var fileExtension in allFiles.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                lines.Add(fileExtension.Key);

                foreach (var file in fileExtension.Value.OrderBy(file => file.Value))
                {
                    lines.Add($"--{file.Key} - {file.Value:F3}kb");
                }
            }
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";

            File.WriteAllLines(path, lines);
        }
    }
}
