using System;
using System.Linq;

namespace P01_ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine($"Min = {array.Min()}");
            Console.WriteLine($"Max = {array.Max()}");
            Console.WriteLine($"Sum = {array.Sum()}");
            Console.WriteLine($"Average = {array.Average()}");
        }
    }
}
