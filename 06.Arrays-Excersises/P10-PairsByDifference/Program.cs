using System;
using System.Linq;

namespace P10_PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = sequence.Length - 1; j > i; j--)
                {
                    if (sequence[i] - sequence[j] == difference || sequence[j] - sequence[i] == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
