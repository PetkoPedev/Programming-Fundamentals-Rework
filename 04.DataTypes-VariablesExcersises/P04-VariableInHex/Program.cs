using System;

namespace P04_VariableInHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            var converted = Convert.ToInt32(num, 16);
            Console.WriteLine(converted);
        }
    }
}
