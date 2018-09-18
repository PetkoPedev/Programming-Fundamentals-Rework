using System;

namespace P01_Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homesToVisit = int.Parse(Console.ReadLine());
            int presentsToGive = int.Parse(Console.ReadLine());
            int numberOfChildren = 0;
            int visitedHomes = 0;
            int timesWentBackCounter = 0;
            //int numberOfPresentsToGet = 0;

            while (homesToVisit > 0)
            {
                numberOfChildren = int.Parse(Console.ReadLine());
                presentsToGive -= numberOfChildren;
                visitedHomes++;
                if (presentsToGive <= 0)
                {
                    timesWentBackCounter++;
                }

            }
        }
    }
}
