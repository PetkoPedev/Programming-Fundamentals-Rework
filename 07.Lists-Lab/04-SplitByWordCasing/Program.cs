using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<string> words = input.Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowercaseWords = new List<string>();
            List<string> uppercaseWords = new List<string>();
            List<string> mixedcaseWords = new List<string>();
            foreach (var word in words)
            {
                bool isAllLowerCase = true;
                bool isAllUpperCase = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllUpperCase = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLowerCase = false;
                    }
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperCase = false;
                    }
                }
                if (isAllLowerCase)
                {
                    lowercaseWords.Add(word);
                }
                else if (isAllUpperCase)
                {
                    uppercaseWords.Add(word);
                }
                else
                {
                    mixedcaseWords.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowercaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedcaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercaseWords));
        }
    }
}
