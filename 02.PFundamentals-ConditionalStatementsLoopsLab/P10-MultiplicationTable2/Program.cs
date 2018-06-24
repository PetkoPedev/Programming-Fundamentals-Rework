using System;

namespace P09_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            if (times > 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
            }
            else
            {
                while (times <= 10)
                {
                    Console.WriteLine($"{number} X {times} = {number * times}");
                    times++;
                }
            }
        }
    }
}
