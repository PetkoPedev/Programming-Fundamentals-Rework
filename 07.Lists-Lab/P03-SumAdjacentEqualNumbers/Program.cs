using System;
using System.Linq;

namespace P03_SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();
            int i = 0;
            while (i < input.Count - 1)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] += input[i + 1];
                    input.RemoveAt(i + 1);
                    i--;
                    if (i < 0)
                    {
                        i = 0;
                    }
                }
                else
                    i++;
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
