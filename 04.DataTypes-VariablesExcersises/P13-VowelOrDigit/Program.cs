﻿using System;

namespace P13_VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char vowelOrDigit = char.Parse(Console.ReadLine());
            switch (vowelOrDigit)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("digit");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
