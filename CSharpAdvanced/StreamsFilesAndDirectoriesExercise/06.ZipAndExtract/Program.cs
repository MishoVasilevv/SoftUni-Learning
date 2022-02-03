using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\Users\misho\OneDrive\Работен плот\plsZipMe";
            string targetDirectory = @"C:\Users\misho\OneDrive\Работен плот\result.rar";
            string destinationDirectory = @"C:\Users\misho\OneDrive\Работен плот\result";

            ZipFile.CreateFromDirectory(sourceDirectory, targetDirectory);
            ZipFile.ExtractToDirectory(targetDirectory, destinationDirectory);
        }
    }
}
