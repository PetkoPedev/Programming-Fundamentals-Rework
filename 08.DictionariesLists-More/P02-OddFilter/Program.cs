using System;
using System.Linq;

namespace P02_OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(a => a % 2 == 0)
                .ToArray();

            int[] finalArray = initialArray.Select(a => a > initialArray.Average() ? ++a : --a).ToArray();

            Console.WriteLine(string.Join(" ", finalArray));
        }
    }
}
