using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

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
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
