using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_PopulationCenter_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> report = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine().Split('|');
            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var population = decimal.Parse(input[2]);

                if (!report.ContainsKey(country))
                {

                }

                input = Console.ReadLine().Split('|');
            }
        }
    }
}
