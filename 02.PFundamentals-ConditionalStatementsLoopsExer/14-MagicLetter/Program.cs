using System;

namespace _14_MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            char invalidLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= lastLetter; i++)
            {
                if (i == invalidLetter)
                {
                    continue;
                }
                for (char j = firstLetter; j <= lastLetter; j++)
                {
                    if (j == invalidLetter)
                    {
                        continue;
                    }
                    for (char k = firstLetter; k <= lastLetter; k++)
                    {
                        if (k == invalidLetter)
                        {
                            continue;
                        }
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
