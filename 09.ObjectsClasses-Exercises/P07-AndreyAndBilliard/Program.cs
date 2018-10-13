using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_AndreyAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public double Bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> shopList = new Dictionary<string, double>();

            int entities = int.Parse(Console.ReadLine());

            for (int i = 0; i < entities; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                if (!shopList.ContainsKey(input[0]))
                {
                    shopList.Add(input[0], double.Parse(input[1]));
                }
                else
                {
                    shopList[input[0]] = double.Parse(input[1]);
                }
            }

            List<Customer> allCustomers = new List<Customer>();
            while (true)
            {
                string info = Console.ReadLine();
                if (info == "end of clients")
                {
                    break;
                }
                string[] clientInfo = info.Split('-', ',');
                string customerName = clientInfo[0];
                string product = clientInfo[1];
                double quantity = double.Parse(clientInfo[2]);

                if (!shopList.ContainsKey(product))
                {
                    continue;
                }

                Customer client = new Customer();
                client.ShopList = new Dictionary<string, double>();
                client.Name = clientInfo[0];
                client.ShopList.Add(product, quantity);

                if (allCustomers.Any(c => c.Name == customerName))
                {
                    Customer existingCustomer = allCustomers.First(c => c.Name == customerName);
                    if (existingCustomer.ShopList.ContainsKey(product))
                    {
                        existingCustomer.ShopList[product] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[product] = quantity;
                    }
                }
                else
                {
                    allCustomers.Add(client);
                }
            }
            foreach (var customer in allCustomers)
            {
                foreach (var item in customer.ShopList)
                {

                    foreach (var prod in shopList)
                    {
                        if (item.Key == prod.Key)
                        {
                            customer.Bill += item.Value * prod.Value;
                        }
                    }
                }
            }
            var ordered = allCustomers
                            .OrderBy(x => x.Name)
                            .ThenBy(x => x.Bill)
                            .ToList();
            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, double> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);

            }
            Console.WriteLine("Total bill: {0:F2}", allCustomers.Sum(c => c.Bill));
        }
    }
}
