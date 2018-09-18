using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P03_StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex starRegex = new Regex(@"[sStTaArR]");
            Regex messageRegex = new Regex(@"[^@\-:!>]*@(?<name>[a-zA-Z]+)[^@\-:!>]*:(\d+)[^@\-:!>]*!(?<type>A|D)![^@\-:!>]*->(\d+)[^@\-:!>]*");
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            //decryption
            
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                MatchCollection starMatches = starRegex.Matches(line);
                int step = starMatches.Count;
                StringBuilder decriptedMessage = new StringBuilder();
                for (int j = 0; j < line.Length; j++)
                {
                    char current = (char)(line[j] - step);
                    decriptedMessage.Append(current);
                }

                if (messageRegex.IsMatch(decriptedMessage.ToString()))
                {
                    Match match = messageRegex.Match(decriptedMessage.ToString());
                    string type = match.Groups["type"].Value;
                    string name = match.Groups["name"].Value;

                    if (type == "D")
                    {
                        destroyed.Add(name);
                    }
                    else if (type == "A")
                    {
                        attacked.Add(name);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (string planet in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (string planet in destroyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
