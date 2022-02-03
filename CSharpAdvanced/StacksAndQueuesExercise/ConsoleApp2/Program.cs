using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = tokens[0];
            int s = tokens[1];
            int x = tokens[2];

            bool contains = false;

            int[] stackArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                stack.Push(stackArr[i]);
            }

            for (int j = 0; j < s; j++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int smallestNumber = int.MaxValue;

            while (stack.Count > 0)
            {
                int currentNumber = stack.Pop();

                if (currentNumber == x)
                {
                    Console.WriteLine("true");
                    return;
                }

                if (currentNumber < smallestNumber)
                {
                    smallestNumber = currentNumber;
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
