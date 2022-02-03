using System;
using System.IO;

namespace _05.SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream fs = new FileStream("SliceMe.txt", FileMode.OpenOrCreate);

            var allData = new byte[fs.Length]; //the legth of the whole file

            fs.Read(allData); //we read the whole file

            int bytesPerPart = (int)Math.Ceiling((fs.Length / 4.0)); //calculating the size of the four parts(hoow much bytes are they)

            for (int i = 0; i < 4; i++)
            {
                var buffer = new byte[bytesPerPart]; //creating the buffer for each part
                fs.Read(buffer); //read the current part

                using FileStream fw = new FileStream($"Part-{i + 1}.txt", FileMode.OpenOrCreate); //new file stream for writing the files

                fw.Write(buffer); //write the current part
            }
        }
    }
}
