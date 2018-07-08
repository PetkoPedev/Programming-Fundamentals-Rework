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
            Console.WriteLine(thievesId);
        }
    }
}
