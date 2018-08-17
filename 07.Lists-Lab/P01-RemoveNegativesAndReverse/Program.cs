using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();
            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] > 0)
                {
                    result.Add(integers[i]);
                }
                else
                    Console.WriteLine("empty");
            }
            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
