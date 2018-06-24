using System;

namespace P04_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var totalVolume = volume / 100;
            var energyPerMl = double.Parse(Console.ReadLine());
            var sugarPerMl = double.Parse(Console.ReadLine());
            var totalEnergy = totalVolume * energyPerMl;
            var totalSugar = totalVolume * sugarPerMl;
            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
        }
    }
}
