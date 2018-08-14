using System;
using System.Linq;

namespace P06_MaxSequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var startIndex = 0;
            var sequenceLength = 0;

            var bestStartIndex = 0;
            var bestSequenceLength = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] - array[i - 1] >= 1)
                {
                    sequenceLength++;
                    startIndex = i - sequenceLength;

                    if (sequenceLength > bestSequenceLength)
                    {
                        bestStartIndex = startIndex;
                        bestSequenceLength = sequenceLength;
                    }
                }
                else
                {
                    startIndex = i;
                    sequenceLength = 0;
                }
            }

            for (int i = bestStartIndex; i <= bestStartIndex + bestSequenceLength; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
