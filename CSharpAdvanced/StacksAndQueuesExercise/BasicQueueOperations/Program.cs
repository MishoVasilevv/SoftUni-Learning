using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            int[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = tokens[0];
            int s = tokens[1];
            int x = tokens[2];

            int[] queueArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(queueArr[i]);
            }

            for (int j = 0; j < s; j++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }


            int minNum = int.MaxValue;

            while (queue.Count > 0)
            {
                int currentNumber = queue.Dequeue();

                if (currentNumber < minNum)
                {
                    minNum = currentNumber;
                }

                if (currentNumber == x)
                {
                    Console.WriteLine("true");
                    return;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
