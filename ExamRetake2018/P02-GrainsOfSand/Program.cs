using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_GrainsOfSand
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputGrains = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = "";

            while ((input = Console.ReadLine()) != "Mort")
            {
                string[] commands = input.Split().ToArray();
                string command = commands[0];


                if (command == "Add")
                {
                    int element = int.Parse(commands[1]);
                    inputGrains.Add(element);
                }
                else if (command == "Remove")
                {
                    int element = int.Parse(commands[1]);
                    if (inputGrains.Contains(element))
                    {
                        inputGrains.Remove(element);
                    }
                    else if (!inputGrains.Contains(element))
                    {
                        inputGrains.RemoveAt(element);
                    }
                    else if (inputGrains.IndexOf(element) > 0 && inputGrains.IndexOf(element) <= inputGrains.Count)
                    {
                        inputGrains.Remove(element);
                    }
                }
                else if (command == "Replace")
                {
                    int value = int.Parse(commands[1]);
                    int replacementIndex = int.Parse(commands[2]);

                    //inputGrains.Remove(value);

                }
                else if (command =="Increase")
                {
                    int value = int.Parse(commands[1]);
                }
                else if (command == "Collapse")
                {
                    int value = int.Parse(commands[1]);
                }
            }

            Console.WriteLine(string.Join(" ", inputGrains));
        }
    }
}
