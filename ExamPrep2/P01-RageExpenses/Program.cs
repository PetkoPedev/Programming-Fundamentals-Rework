using System;

namespace P01_RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetsLost = lostGamesCount / 2;
            double miceLost = lostGamesCount / 3;
            int keyboardsLost = lostGamesCount / 3 / 2;
            int displaysLost = keyboardsLost / 2;
            double expenses = headsetsLost * headsetPrice + miceLost * mousePrice + keyboardsLost * keyboardPrice + displaysLost * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
