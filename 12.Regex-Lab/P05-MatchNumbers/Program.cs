﻿using System;
using System.Text.RegularExpressions;

namespace P05_MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numberStrings = Console.ReadLine();

            var numbers = Regex.Matches(numberStrings, regex);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
