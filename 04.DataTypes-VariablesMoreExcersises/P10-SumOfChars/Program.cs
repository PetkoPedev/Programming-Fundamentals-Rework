using System;

namespace P10_SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long total = 0;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                total += letter;
            }
            Console.WriteLine($"The sum equals: {total}");
        }
    }
}
