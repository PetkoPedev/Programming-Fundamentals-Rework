using System;

namespace P11_OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            while (true)
            {
                if (number % 2 == 1)
                    break;
                Console.WriteLine("Please write an odd number.");
                number = Math.Abs(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"The number is: {number}");
        }
    }
}
