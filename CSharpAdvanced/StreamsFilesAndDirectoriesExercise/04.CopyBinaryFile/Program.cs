using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream fileReader = new FileStream("copyMe.png", FileMode.Open);
            using FileStream fileWriter = new FileStream("copyMeCopy.png", FileMode.Create);

            byte[] buffer = new byte[1024];

            while (true)
            {
                int currentBytes = fileReader.Read(buffer, 0, buffer.Length);

                if (currentBytes == 0)
                {
                    break;
                }

                fileWriter.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
