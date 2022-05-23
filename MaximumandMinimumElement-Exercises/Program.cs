using System;
using System.Linq;
using System.Collections.Generic;

namespace MaximumandMinimumElement_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> output = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] queries = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (queries[0] == 1)
                {
                    output.Push(queries[1]);
                }
                else if (queries[0] == 2)
                {
                    if (output.Count == 0 )
                    {
                        continue;
                    }
                    else
                    {
                        output.Pop();
                    }
                    
                }
                else if (queries[0] == 3)
                {
                    if (output.Count == 0)
                    {
                        continue;
                    }
                    else
                    {


                        Console.WriteLine(output.Max());
                    }
                }
                else if (queries[0] == 4)
                {
                    if (output.Count == 0)
                    {
                        continue;
                    }
                    else
                    {


                        Console.WriteLine(output.Min());
                    }
                }

            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
