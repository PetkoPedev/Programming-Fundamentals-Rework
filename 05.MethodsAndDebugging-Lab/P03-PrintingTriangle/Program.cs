﻿using System;

namespace P03_PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            for (int line = 1; line < n; line++)
            {
                PrintLine(1, line);
            }
            PrintLine(1, n);
            for (int line = n - 1; line >= 0; line--)
            {
                PrintLine(1, line);
            }
        }
    }
}