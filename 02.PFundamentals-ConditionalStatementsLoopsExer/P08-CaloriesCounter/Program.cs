using System;

namespace P08_CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalProductsCount = 0;
            string product = "";

            for (int i = 1; i <= n; i++)
            {
                product = Console.ReadLine().ToLower();
                if (product == "cheese")
                {
                    totalProductsCount += 500;
                }
                else if (product =="tomato sauce")
                {
                    totalProductsCount += 150;
                }
                else if (product == "salami")
                {
                    totalProductsCount += 600;
                }
                else if (product == "pepper")
                {
                    totalProductsCount += 50;
                }
            }

            Console.WriteLine($"Total calories: {totalProductsCount}");
        }
    }
}
