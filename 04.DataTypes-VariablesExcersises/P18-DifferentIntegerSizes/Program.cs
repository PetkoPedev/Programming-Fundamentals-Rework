using System;

namespace P18_DifferentIntegerSizes
{
    class Program
    {
        static void Main(string[] args)
        {
            long num;
            var line = Console.ReadLine();
            var canFitInBigLong = long.TryParse(line, out num);

            if (!canFitInBigLong)
            {
                Console.WriteLine($"{line} can't fit in any type");
                return;
            }

            Console.WriteLine("{0} can fit in: ", num);

            if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
            {
                Console.WriteLine("* sbyte");
            }

            if (num >= byte.MinValue && num <= byte.MaxValue)
            {
                Console.WriteLine("* byte");
            }

            if (num >= short.MinValue && num <= short.MaxValue)
            {
                Console.WriteLine("* short");
            }

            if (num >= ushort.MinValue && num <= ushort.MaxValue)
            {
                Console.WriteLine("* ushort");
            }

            if (num >= int.MinValue && num <= int.MaxValue)
            {
                Console.WriteLine("* int");
            }

            if (num >= uint.MinValue && num <= uint.MaxValue)
            {
                Console.WriteLine("* uint");
            }

            if (num >= long.MinValue && num <= long.MaxValue)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
