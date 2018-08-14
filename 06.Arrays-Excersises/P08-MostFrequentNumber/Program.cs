using System;
using System.Linq;

namespace P08_MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int mostFrequentNumber = 0;
            int repetitions = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int counter = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        counter++;
                    }
                }

                if (counter > repetitions)
                {
                    mostFrequentNumber = currentNumber;
                    repetitions = counter;
                }
            }

            Console.WriteLine($"{mostFrequentNumber}");
        }
    }
}
