using System;

namespace P11_StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string condition = Console.ReadLine().ToLower().Trim();
            int n = int.Parse(Console.ReadLine());
            string message = String.Empty;
            int result = 1;
            if (condition == "odd")
            {
                result = 0;
            }
            for (int i = 0; i < n; i++)
            {
                string tempString = Console.ReadLine();
                if (i%2 == result)
                {
                    message += tempString + delimiter;
                }
            }
            Console.WriteLine(message.Substring(0, message.Length - 1));
        }
    }
}
