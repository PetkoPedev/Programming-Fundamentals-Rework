using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> resultList = new List<int>();

            int elementsToTakeFromInput = arr[0];
            int elementsToDeleteFromInput = arr[1];
            int elementToSearch = arr[2];
            
            for (int i = 0; i < elementsToTakeFromInput; i++)
            {
                resultList.Add(inputList[i]);
            }

            resultList.RemoveRange(0, elementsToDeleteFromInput);

            if (resultList.Contains(elementToSearch))
            {
                Console.WriteLine("YES!");
            }
            else
                Console.WriteLine("NO!");
        }
    }
}
