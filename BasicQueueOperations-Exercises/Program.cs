using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> output = new Queue<int>();

            for (int i = 0; i < input[0]; i++)
            {
                output.Enqueue(numbers[i]);
            }
            for (int i = 0; i < input[1]; i++)
            {
                output.Dequeue();
            }
            if (output.Count == 0)
            {
                Console.WriteLine(0);

            }
            else
            {
                if (output.Contains(input[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(output.Min());
                }
            }

        }
    }
}