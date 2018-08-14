using System;
using System.Linq;

namespace P06_ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < nums.Length / 2; i++)
            {
                SwapElements(nums, i, nums.Length - 1 - i);
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        static void SwapElements(string[] nums, int i, int j)
        {
            var oldElement = nums[i];
            nums[i] = nums[j];
            nums[j] = oldElement;
        }
    }
}
