using System;

namespace P01_ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price;
            double total;
            switch (profession)
            {
                case "Athlete":
                    price = 0.70;
                    total = price * quantity;
                    Console.WriteLine($"The {profession} has to pay {total:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = 1;
                    total = price * quantity;
                    Console.WriteLine($"The {profession} has to pay {total:F2}.");
                    break;
                    
                case "SoftUni Student":
                    price = 1.70;
                    total = price * quantity;
                    Console.WriteLine($"The {profession} has to pay {total:F2}.");
                    break;

                default:
                    price = 1.20;
                    total = price * quantity;
                    Console.WriteLine($"The {profession} has to pay {total:F2}.");
                    break;
            }
        }
    }
}
