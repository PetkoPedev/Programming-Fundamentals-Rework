using System;

namespace P06_CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            long maxValue = 0L;

            switch (numeralType)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                case "long":
                    maxValue = long.MaxValue;
                    break;
            }

            int idCount = int.Parse(Console.ReadLine());
            long thievesId = long.MinValue;
            for (int i = 0; i < idCount; i++)
            {
                long tempId = long.Parse(Console.ReadLine());
                if (tempId > thievesId && tempId <= maxValue)
                {
                    thievesId = tempId;
                }
            }
            sbyte num = 0;
            if (thievesId < 0)
            {
                num = sbyte.MinValue;
            }
            else
                num = sbyte.MaxValue;
            decimal sentence = Math.Abs((decimal)thievesId / num);
            if (sentence > 1)
            {
                Console.WriteLine($"Prisoner with id {thievesId} is sentenced to {Math.Ceiling(sentence)} years");
            }
            else
                Console.WriteLine($"Prisoner with id {thievesId} is sentenced to {Math.Ceiling(sentence)} year");
        }
    }
}
