using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputArr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); 

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputArr[col];

                    sum += inputArr[col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
