using System;
using System.Linq;
using System.Collections.Generic;

namespace Fashion_Boutique_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);

            int sum = 0;
            int racks = 1;

            while (stack.Count != 0)
            {
                int clothValue = stack.Pop();
                sum += clothValue;

                if (sum > rackCapacity)
                {
                    sum = clothValue;
                    racks++;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
