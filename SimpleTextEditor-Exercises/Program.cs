using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder output = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            string command = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                string[] rawCommand = command.Split();

                if (rawCommand[0] == "1")
                {
                    stack.Push(output.ToString());
                    string someString = rawCommand[1];
                    output.Append(someString);
                    
                }
                else if (rawCommand[0] == "2")
                {stack.Push(output.ToString());
                    int countErase = int.Parse(rawCommand[1]);
                    output.Length = output.Length - countErase;
                    
                }
                else if (rawCommand[0] == "3")
                {
                    int index = int.Parse(rawCommand[1]);
                    string returnedIndex= output[index - 1].ToString();
                    Console.WriteLine(returnedIndex);
                }
                else if (rawCommand[0] == "4")
                {
                    string last = stack.Pop();
                    output.Clear();
                    output.Append(last);
                }

                command = Console.ReadLine();
            }

        }
    }
}
