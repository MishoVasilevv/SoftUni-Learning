using System;
using System.IO;

namespace _06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"C:\Users\misho\OneDrive\Работен плот\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\06. Folder Size\TestFolder");

            long totalSum = 0;

            foreach (var file in files)
            {
                totalSum += new FileInfo(file).Length;
            }

            Console.WriteLine(totalSum / 1024 / 1024);
        }
    }
}
