using System;
using System.Linq;

namespace P05_CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            var array2 = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            if (array1 == array2)
            {
                Console.WriteLine(array1);
                Console.WriteLine(array2);
                return;
            }

            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i] == array2[i])
                {
                    continue;
                }

                if (array1[i] < array2[i])
                {
                    Console.WriteLine(array1);
                    Console.WriteLine(array2);
                    return;
                }
                else
                {
                    Console.WriteLine(array2);
                    Console.WriteLine(array1);
                    return;
                }
            }

            Console.WriteLine(
                array1.Length < array2.Length ?
                string.Join(string.Empty, array1) :
                string.Join(string.Empty, array2)
                );
            Console.WriteLine(
                array1.Length > array2.Length ?
                string.Join(string.Empty, array1) :
                string.Join(string.Empty, array2)
                );
        }
    }
}
