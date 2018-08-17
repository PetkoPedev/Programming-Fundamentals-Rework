﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();
            input.Sort();
            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
