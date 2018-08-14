using System;
using System.Linq;

namespace P03_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = array.Length / 4;

            var leftArr = new int[k];
            var middleArr = new int[2 * k];
            var rightArr = new int[k];

            var resultArr = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                leftArr[i] = array[i];
                rightArr[i] = array[3 * k + i];
            }
            
            for (int i = 0; i < 2 * k; i++)
            {
                middleArr[i] = array[k + i];
            }

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            for (int i = 0; i < k; i++)
            {
                resultArr[i] += middleArr[i] + leftArr[i];
                resultArr[i + k] += middleArr[i + k] + rightArr[i];
            }
            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
