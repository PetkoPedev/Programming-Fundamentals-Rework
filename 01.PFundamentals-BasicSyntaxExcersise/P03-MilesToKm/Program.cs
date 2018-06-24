using System;

namespace P03_MilesToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());
            double kilometer = mile * 1.60934;
            Console.WriteLine("{0:F2}", kilometer);
        }
    }
}
