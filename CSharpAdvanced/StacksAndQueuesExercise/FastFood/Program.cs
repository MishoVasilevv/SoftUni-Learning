using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            int biggestOrder = int.MinValue;

            for (int i = 0; i < queue.Count; i++)
            {
                int currentNumber = queue.Dequeue();

                if (currentNumber > biggestOrder)
                {
                    biggestOrder = currentNumber;
                }

                queue.Enqueue(currentNumber);
            }

            Console.WriteLine(biggestOrder);

            while (queue.Count > 0)
            {
                int currentOrder = queue.Peek();

                if (foodQuantity >= currentOrder)
                {
                    foodQuantity -= currentOrder;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("Orders left: ");

                sb.Append(String.Join(" ", queue));

                Console.WriteLine(sb.ToString().TrimEnd());
            }
        }
    }
}
