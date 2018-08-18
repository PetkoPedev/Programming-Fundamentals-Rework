using System;
using System.Linq;

namespace P06_SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                var currentNum = arr[i];
                var currentNumToString = currentNum.ToString();
                var reversedNumArray = currentNumToString.Reverse().ToArray();
                var reversedNum = new string(reversedNumArray);

                arr[i] = int.Parse(reversedNum);
            }
            Console.WriteLine(arr.Sum());
        }
    }
}
