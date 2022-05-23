using System;
using System.Linq;
using System.Collections.Generic;

namespace BalancedParentheses_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<char> parantheses = new Stack<char>();
            string input = Console.ReadLine();
            bool isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    parantheses.Push(input[i]);
                    continue;
                }

                if (parantheses.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                if (parantheses.Peek() == '(' && input[i] == ')')
                {
                    parantheses.Pop();
                    continue;
                }
                if (parantheses.Peek() == '[' && input[i] == ']')
                {
                    parantheses.Pop();
                    continue;
                }
                if (parantheses.Peek() == '{' && input[i] == '}')
                {
                    parantheses.Pop();
                    continue;
                }
            }

            Console.WriteLine(parantheses.Count == 0 && isBalanced == true ? "YES" : "NO");
        }
    }
}
