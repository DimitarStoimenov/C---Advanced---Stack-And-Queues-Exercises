using System;
using System.Linq;
using System.Collections.Generic;

namespace SongsQueue_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            string command = Console.ReadLine();
            Queue<string> songs = new Queue<string>(input);

            while (songs.Count > 0)
            {
                string[] rawCommand = command.Split();
                if (rawCommand[0] == "Play" )
                {
                    songs.Dequeue();
                    
                }
                if (command.Contains("Add"))
                {
                    string song = string.Join(" ", rawCommand.Skip(1));
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                       
                        songs.Enqueue(song);
                    }
                    

                }
                if (rawCommand[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));

                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");

        }
    }
}
