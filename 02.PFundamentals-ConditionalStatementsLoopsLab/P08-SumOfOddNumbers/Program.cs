﻿using System;

namespace P08_SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int odd = 2 * i - 1;
                Console.WriteLine("{0}", odd);
                sum += 2 * i - 1;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}