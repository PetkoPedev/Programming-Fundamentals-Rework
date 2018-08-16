using System;
using System.Linq;

namespace P06_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lootPrice = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var jewelPrice = lootPrice[0];
            var goldPrice = lootPrice[1];
            double totalMoney = 0;
            var commands = Console.ReadLine();
            while (commands != "Jail Time")
            {
                var heistElements = commands.Split().ToArray();
                var lootType = heistElements[0];
                var expences = heistElements[1];
                int jewelsQuantity = lootType.Where(ch => ch == '%').Count();
                int goldQuantity = lootType.Where(ch => ch == '$').Count();
                var currentHeistCost = double.Parse(expences);
                totalMoney +=
                    (jewelsQuantity * jewelPrice) +
                    (goldQuantity * goldPrice) -
                    currentHeistCost;
                commands = Console.ReadLine();
            }
            Console.WriteLine(
                totalMoney < 0 ?
                $"Have to find another job. Lost: {Math.Abs(totalMoney)}." :
                $"Heists will continue. Total earnings: {totalMoney}."
                );
        }
    }
}
