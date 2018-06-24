using System;

namespace P02_AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
        }
    }
}
