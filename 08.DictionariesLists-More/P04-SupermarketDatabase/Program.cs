using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var productPriceQuantDict = new Dictionary<string, Dictionary<double, int>>();
            var productQuantity = new Dictionary<string, int>();
            while (input != "stocked")
            {
                var splittedInput = input.Split(' ');
                var product = splittedInput[0];
                var price = double.Parse(splittedInput[1]);
                var quantity = int.Parse(splittedInput[2]);
                if (!productPriceQuantDict.ContainsKey(product))
                {
                    productPriceQuantDict[product] = new Dictionary<double, int>();
                    productPriceQuantDict[product].Add(price, quantity);
                    productQuantity[product] = quantity;
                }
                else
                {
                    quantity += productQuantity[product];
                    productQuantity[product] = quantity;
                    productPriceQuantDict[product].Clear();
                    productPriceQuantDict[product].Add(price, quantity);
                }
                input = Console.ReadLine();
            }
            var total = 0.0;
            foreach (var product in productPriceQuantDict)
            {
                foreach (var priceQuantity in product.Value)
                {
                    var currentTotal = priceQuantity.Key * priceQuantity.Value;
                    total += currentTotal;
                    Console.WriteLine($"{product.Key}: ${priceQuantity.Key:f2} * {priceQuantity.Value} = ${currentTotal:f2}");
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${total:f2}");
        }
    }
}
