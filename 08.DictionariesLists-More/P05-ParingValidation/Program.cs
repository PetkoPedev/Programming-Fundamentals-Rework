using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_ParingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> carPark = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                string username = tokens[1];
                

                switch (command.ToLower())
                {
                    case "register":
                        string licensePlate = tokens[2];
                        PrintInput(Register(carPark, username, licensePlate));

                        break;
                    case "unregister":
                        PrintInput(Unregister(carPark, username));
                        break;
                }
            }

            foreach (KeyValuePair<string, string> item in carPark)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        private static string Unregister(Dictionary<string, string> carPark, string username)
        {
            if (!carPark.ContainsKey(username))
            {
                return string.Format("ERROR: user {0} not found", username);
            }
            carPark.Remove(username);
            return string.Format("user {0} unregistered successfully", username);
        }

        private static string Register(Dictionary<string, string> carPark, string username, string licensePlate)
        {
            if (carPark.ContainsKey(username))
            {
                return "ERROR: already registered with plate number " + carPark[username];
            }
            else if (!ValidatePlate(licensePlate))
            {
                return "ERROR: invalid license plate " + licensePlate;
            }
            else if (carPark.ContainsValue(licensePlate))
            {
                return string.Format("ERROR: license plate {0} is busy", licensePlate);
            }
            carPark.Add(username, licensePlate);
            return string.Format("{0} registered {1} successfully", username, licensePlate);
        }

        private static bool ValidatePlate(string licensePlate)
        {
            bool isValidNumbers = licensePlate.ToCharArray()
                .Skip(2)
                .Take(4)
                .All(d => char.IsDigit(d));
            bool isValidLetter = licensePlate.ToCharArray()
                .Take(2)
                .Concat(licensePlate.ToCharArray().Skip(6).Take(2).ToArray())
                .All(d => char.IsUpper(d));

            return licensePlate.Length == 8 && isValidLetter && isValidNumbers;
        }

        private static void PrintInput(string input)
        {
            Console.WriteLine(input);
        }
    }
}
