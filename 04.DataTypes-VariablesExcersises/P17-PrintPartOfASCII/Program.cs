using System;

namespace P17_PrintPartOfASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            var startIndex = int.Parse(Console.ReadLine());
            var endIndex = int.Parse(Console.ReadLine());

            for (char character = (char)startIndex; character <= endIndex; character++)
            {
                Console.Write(character + " ");
            }
        }
    }
}
