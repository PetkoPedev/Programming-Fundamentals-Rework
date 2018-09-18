using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> schedule = new List<string>();
            List<string> lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var tokens = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (tokens[0] != "course apart")
            {
                var command = tokens[0];
                
                switch (command)
                {
                    case "Add":
                        
                        if (!lessons.Contains(tokens[1]))
                        {
                            lessons.Add(tokens[1]);
                        }
                        break;
                    case "Insert":
                        if (!lessons.Contains(tokens[1]) && (int.Parse(tokens[2]) > 0 && int.Parse(tokens[2]) <= lessons.Count))
                        {
                            lessons.Insert(int.Parse(tokens[2]), tokens[1]);
                        }
                        break;
                    case "Remove":
                        if (lessons.Contains(tokens[1]) || lessons.Contains("Exercise"))
                        {
                            lessons.Remove(tokens[1]);
                        }
                        break;
                    case "Swap":
                        string lesson1 = tokens[1];
                        string lesson2 = tokens[2];

                        if (lessons.Contains(lesson1) && lessons.Contains(lesson2))
                        {

                        }
                        break;
                    case "Exercise":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
