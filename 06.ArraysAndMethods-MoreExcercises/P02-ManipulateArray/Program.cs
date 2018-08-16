using System;
using System.Linq;

namespace P03_SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                
                switch (command)
                {
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(tokens[1]);
                        string elementToReplace = tokens[2];
                        if (index < 0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        arr[index] = elementToReplace;
                        break;
                    
                }
            }
            
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
