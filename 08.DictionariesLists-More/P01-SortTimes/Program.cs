using System;
using System.Linq;

namespace P01_SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine().Split();
            var sortedTimes = times.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", sortedTimes));
        }
    }
}
