using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] inputArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                matrix[row] = inputArr;
            }

            string command = Console.ReadLine().ToUpper();

            while (command != "END")
            {
                var splitted = command.Split(" ");

                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                if (splitted[0] == "ADD")
                {

                    if (row < 0 || row >= matrix.Length || col < 0 || col >= matrix[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                        command = Console.ReadLine().ToUpper();
                        continue;
                    }

                    matrix[row][col] += value; 
                }
                else
                {
                    if (row < 0 || row >= matrix.Length || col < 0 || col >= matrix[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                        command = Console.ReadLine().ToUpper();
                        continue;
                    }

                    matrix[row][col] -= value;
                }

                command = Console.ReadLine().ToUpper();
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }
    }
}
