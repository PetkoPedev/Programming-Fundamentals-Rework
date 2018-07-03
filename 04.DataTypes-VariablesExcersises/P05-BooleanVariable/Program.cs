using System;

namespace P05_BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();
            if (Convert.ToBoolean(boolean))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
