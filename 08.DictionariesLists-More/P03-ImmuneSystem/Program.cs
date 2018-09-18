using System;
using System.Collections.Generic;

namespace P03_ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> viruses = new List<string>();

            int initialStrength = int.Parse(Console.ReadLine());
            int maxHealth = initialStrength;
            string virus = Console.ReadLine();
            while (virus != "end")
            {
                int virusStrength = CalculateVirusStrength(virus);
                int virusTime = virusStrength * virus.Length;
                if (viruses.Contains(virus))
                {
                    virusTime = (int)(virusTime / 3.0);
                }
                else
                {
                    viruses.Add(virus);
                }

                initialStrength -= virusTime;
                Console.WriteLine($"Virus {virus}: {virusStrength} => {virusTime} seconds");
                if (initialStrength <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    Console.WriteLine($"{virus} defeated in {CalculateTime(virusTime)}.");
                    Console.WriteLine("Remaining health: " + initialStrength);
                }
                initialStrength = Math.Min(maxHealth, (int)(initialStrength * 1.2));
                virus = Console.ReadLine();
            }
            Console.WriteLine("Final Health: " + initialStrength);
        }

        private static string CalculateTime(int time)
        {
            return time / 60 + "m " + time % 60 + "s";
        }

        private static int CalculateVirusStrength(string virus)
        {
            int totalStrength = 0;

            for (int i = 0; i < virus.Length; i++)
            {
                totalStrength += virus[i];
            }

            return (int) (totalStrength/3.0);
        }
    }
}
