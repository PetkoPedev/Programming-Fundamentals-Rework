using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var listOfNumbers = input.Split('|').ToList();
            List<string> result = new List<string>();
            for (int i = listOfNumbers.Count - 1; i >= 0; i--)
            {
                result.Add(string.Join(" ", listOfNumbers[i]));
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
