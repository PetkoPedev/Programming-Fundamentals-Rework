using System;

namespace P14_IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var hex = Convert.ToString(number, 16).ToUpper();
            var binary = Convert.ToString(number, 2);
            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
