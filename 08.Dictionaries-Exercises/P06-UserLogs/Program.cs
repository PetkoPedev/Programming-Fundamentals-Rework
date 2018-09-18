using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                var commandLineList = command.Split(' ').ToList();
                var ipAddress = commandLineList[0].Substring(3);
                var user = commandLineList[2].Substring(5);

                if (!users.ContainsKey(user))
                {
                    users[user] = new Dictionary<string, int>();
                }
                if (!users[user].ContainsKey(ipAddress))
                {
                    users[user][ipAddress] = 0;
                }
                users[user][ipAddress]++;
                command = Console.ReadLine();
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}:");
                Console.Write(string.Join(", ", user.Value.Select(a => a.Key + " => " + a.Value)));
                Console.WriteLine(".");
            }
        }
    }
}
