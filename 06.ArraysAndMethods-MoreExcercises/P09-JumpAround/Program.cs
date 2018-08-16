using System;
using System.Linq;

namespace P09_JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long sum = 0L;
            int index = 0;
            while (true)
            {
                sum += numbers[index];
                int tempIndex = index;
                index = tempIndex + numbers[index];
                if (index > numbers.Length - 1)
                {
                    index = tempIndex - numbers[tempIndex];
                    if (index < 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
