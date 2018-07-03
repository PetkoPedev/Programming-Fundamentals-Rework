using System;

namespace P16_ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            if (Math.Abs(a - b) < eps)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
        }
    }
}
