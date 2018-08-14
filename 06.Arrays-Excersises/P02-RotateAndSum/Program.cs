using System;
using System.Linq;

namespace P02_RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayToRotate = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationCount = int.Parse(Console.ReadLine());

            var sumArray = new int[arrayToRotate.Length];
            for (int i = 0; i < rotationCount; i++)
            {
                RotateArray(arrayToRotate);

                for (int j = 0; j < arrayToRotate.Length; j++)
                {
                    sumArray[j] += arrayToRotate[j];
                }
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }

        private static void RotateArray(int[] arrayToRotate)
        {
            var lastElement = arrayToRotate[arrayToRotate.Length - 1];

            for (int i = arrayToRotate.Length - 1; i > 0; i--)
            {
                arrayToRotate[i] = arrayToRotate[i - 1];
            }
            arrayToRotate[0] = lastElement;
        }
    }
}
