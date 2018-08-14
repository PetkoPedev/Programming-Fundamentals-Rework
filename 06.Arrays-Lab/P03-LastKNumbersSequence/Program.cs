using System;

namespace P03_LastKNumbersSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var seq = new long[n];
            seq[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int previous = i - k; previous <= i - 1; previous++)
                {
                    if (previous >= 0)
                    {
                        sum += seq[previous];
                    }
                    seq[i] = sum;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(seq[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
