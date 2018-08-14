using System;
using System.Linq;

namespace P04_TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    int sum = inputArr[i] + inputArr[j];
                    if (inputArr.Contains(sum))
                    {
                        Console.WriteLine($"{inputArr[i]} + {inputArr[j]} == {sum}");
                        counter++;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
