using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("input.txt").ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var wordCount = new Dictionary<string, int>();
            foreach (string word in words)
                wordCount[word] = 0;
            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
            }

            File.WriteAllLines("results.txt", wordCount.OrderByDescending(x => x.Value).Select(x => $"{x.Key} - {x.Value}"));
        }
    }
}
