using System;
using System.Linq;

namespace P04_GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberToSearch = int.Parse(Console.ReadLine());
            int index = 0;
            bool isFound = false;
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (numbers[i] == numberToSearch)
                {
                    index = i;
                    isFound = true;
                    break;
                }
            }
            long sum = 0;
            if (isFound)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
