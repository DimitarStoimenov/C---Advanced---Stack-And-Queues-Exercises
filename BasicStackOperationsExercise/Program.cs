using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicStackOperationsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = nums[0];
            int S = nums[1];
            int X = nums[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> output = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                output.Push(numbers[i]);
            }
            for (int i = 0; i < S; i++)
            {
                output.Pop();
            }


          
            if (output.Count == 0)
            {
                Console.WriteLine(0);
                
            }
            else
            {
                if (output.Contains(X))
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
