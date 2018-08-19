using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();
            var input = Console.ReadLine().Split().ToArray();
            while (input[0] != "END")
            {
                string name = input[1].ToString();
                if (input[0] == "A")
                {
                    string phoneNumber = input[2].ToString();
                    phoneBook[name] = phoneNumber;
                }
                else if (input[0] == "S")
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " -> " + phoneBook[name]);
                    }
                    else Console.WriteLine($"Contact {name} does not exist.");
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
