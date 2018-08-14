using System;
using System.Linq;

namespace P01_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split();
            var array2 = Console.ReadLine().Split();

            int leftCount = 0;
            int rightCount = 0;

            int smallerArray = Math.Min(array1.Length, array2.Length);
            for (int i = 0; i < smallerArray; i++)
            {
                if (array1[i] == array2[i])
                {
                    leftCount++;
                }
                if (array1[array1.Length-1 - i] == array2[array2.Length - 1 - i])
                {
                    rightCount++;
                }
            }
            Console.WriteLine(Math.Max(leftCount, rightCount));
        }
    }
}
