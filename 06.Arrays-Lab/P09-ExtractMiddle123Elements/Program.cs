using System;
using System.Linq;

namespace P09_ExtractMiddle123Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int middleInteger = arrayIntegers.Length / 2;

            if (arrayIntegers.Length == 1)
            {
                Console.WriteLine($"{arrayIntegers[0]}");
            }
            else if (arrayIntegers.Length % 2 == 0)
            {
                Console.WriteLine($"{arrayIntegers[middleInteger - 1]}\n{arrayIntegers[middleInteger]}");
            }
            else if (arrayIntegers.Length % 2 == 1)
            {
                Console.WriteLine($"{arrayIntegers[middleInteger - 1]}\n{arrayIntegers[middleInteger]}\n{arrayIntegers[middleInteger + 1]}");
            }
        }
    }
}
