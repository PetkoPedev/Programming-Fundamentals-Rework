using System;

namespace P03_WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;
            int capacityLeft = capacity;

            for (int i = 0; i < n; i++)
            {
                int litersPoured = int.Parse(Console.ReadLine());
                if (capacityLeft - litersPoured >= 0)
                {
                    capacityLeft -= litersPoured;
                }
                else
                    Console.WriteLine("Insufficient capacity!");
            }

            int fullTank = capacity - capacityLeft;
            Console.WriteLine(fullTank);
        }
    }
}
