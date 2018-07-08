using System;

namespace P08_HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long price1 = int.Parse(Console.ReadLine());
            long price2 = int.Parse(Console.ReadLine());
            long totalPrice = price1 > price2 ? price1 * 10 + price2 * 4 : price1 * 4 + price2 * 10;
            Console.WriteLine(totalPrice);
        }
    }
}
