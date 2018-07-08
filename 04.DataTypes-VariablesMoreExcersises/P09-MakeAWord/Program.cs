using System;

namespace P09_MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string total = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string letter = Console.ReadLine();
                total += letter;
            }
            Console.WriteLine($"The word is: {total}");
        }
    }
}
