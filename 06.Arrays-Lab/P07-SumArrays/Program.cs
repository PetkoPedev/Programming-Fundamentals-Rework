using System;
using System.Linq;

namespace P07_SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            int[] sumOfNumbers = new int[Math.Max(numbers1.Length, numbers2.Length)];
            for (int i = 0; i < sumOfNumbers.Length; i++)
            {
                sumOfNumbers[i] = numbers1[i % numbers1.Length] + numbers2[i % numbers2.Length];
            }

            Console.WriteLine(string.Join(" ", sumOfNumbers));
        }
    }
}
