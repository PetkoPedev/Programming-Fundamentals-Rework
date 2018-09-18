using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_PopulationCounter_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countryInfo = new Dictionary<string, Dictionary<string, long>>();

            string command = Console.ReadLine();
            while (command != "report")
            {
                var input = command.Split('|');
                var city = input[0];
                var country = input[1];
                long population = long.Parse(input[2]);

                if (!countryInfo.ContainsKey(country))
                {
                    countryInfo[country] = new Dictionary<string, long>();
                }
                if (!countryInfo[country].ContainsKey(city))
                {
                    countryInfo[country].Add(city, population);
                }

                command = Console.ReadLine();
            }

            var orderOfCountries = countryInfo.OrderByDescending(c => c.Value.Values.Sum());

            foreach (var country in orderOfCountries)
            {
                var orderOfCities = country.Value.OrderByDescending(a => a.Value);
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(a => a.Value)})");
                foreach (var city in orderOfCities)
                {
                    Console.WriteLine("=>" + city.Key + ": " + city.Value);
                }
            }
        }
    }
}
