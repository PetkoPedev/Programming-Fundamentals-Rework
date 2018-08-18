using System;
using System.Linq;

namespace P07_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombTokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bombNum = bombTokens[0];
            var bombStrength = bombTokens[1];

            for (int i = 0; i < list.Count; i++)
            {
                var currentNum = list[i];
                if (currentNum == bombNum)
                {
                    var leftIndex = Math.Max(i - bombStrength, 0);
                    var rightIndex = Math.Min(i + bombStrength, list.Count - 1);

                    var removeCount = rightIndex - leftIndex + 1;

                    list.RemoveRange(leftIndex, removeCount);
                    i = -1;
                }
            }
            Console.WriteLine(list.Sum());
        }
    }
}
