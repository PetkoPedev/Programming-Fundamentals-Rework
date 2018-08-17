using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var squares = new List<int>();
            foreach (var num in numbers)
            {
                if (Math.Sqrt(num) % 1 == 0)
                {
                    squares.Add(num);
                }
            }
            squares.Sort();
            squares.Reverse();
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
