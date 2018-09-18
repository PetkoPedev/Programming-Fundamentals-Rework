using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialMessage = Console.ReadLine();
            char[] initialChars = initialMessage.ToCharArray();
            char[] letters = initialChars.Where(a => !char.IsDigit(a)).ToArray();
            int[] digits = initialChars.Where(a => char.IsDigit(a)).Select(a => int.Parse(a.ToString())).ToArray();

            List<int> take = new List<int>();
            List<int> skip = new List<int>();

            for (int i = 0; i < digits.Length; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(digits[i]);
                }
                else
                {
                    skip.Add(digits[i]);
                }
            }

            int totalSkip = 0;
            string finalMessage = "";
            for (int i = 0; i < take.Count; i++)
            {
                int takeCount = take[i];
                int skipCount = skip[i];

                finalMessage += new string(letters.Skip(totalSkip).Take(takeCount).ToArray());

                totalSkip += takeCount + skipCount;
            }

            Console.WriteLine(finalMessage);
        }
    }
}
