using System;
using System.Linq;

namespace P08_CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (numbers.Length > 1)
            {
                int[] condensedNumber = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensedNumber[i] = numbers[i] + numbers[i + 1];
                }
                numbers = condensedNumber;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
