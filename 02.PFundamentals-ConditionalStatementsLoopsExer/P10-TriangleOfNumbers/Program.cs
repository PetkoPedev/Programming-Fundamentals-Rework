using System;
using System.Linq;

namespace P10_TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + string.Concat(Enumerable.Repeat(i.ToString() + " ", i - 1)));
            }
        }
    }
}
