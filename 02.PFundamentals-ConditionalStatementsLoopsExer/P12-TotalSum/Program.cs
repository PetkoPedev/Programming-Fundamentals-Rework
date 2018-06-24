using System;

namespace P12_TotalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maximumSum = int.Parse(Console.ReadLine());

            var totalCombinations = 0;
            var sum = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    var number = (i * j) * 3;
                    sum += number;
                    totalCombinations++;

                    if (sum >= maximumSum)
                    {
                        Console.WriteLine($"{totalCombinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maximumSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{totalCombinations} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
