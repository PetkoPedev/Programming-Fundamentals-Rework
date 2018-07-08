using System;

namespace P13_DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = String.Empty;
            while (n > 0)
            {
                message += ((char)(char.Parse(Console.ReadLine()) + key)).ToString();
                n--;
            }
            Console.WriteLine(message);
        }
    }
}
