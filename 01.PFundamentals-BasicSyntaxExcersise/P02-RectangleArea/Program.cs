using System;

namespace P02_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double result = sideA * sideB;
            Console.WriteLine("{0:F2}", result);
        }
    }
}
