using System;

namespace P01_SoftuniReceprion
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal employeeEfficiencyOne = decimal.Parse(Console.ReadLine());
            decimal employeeEfficiencyTwo = decimal.Parse(Console.ReadLine());
            decimal employeeEfficiencyThree = decimal.Parse(Console.ReadLine());
            decimal studentsCount = decimal.Parse(Console.ReadLine());

            decimal totalDeskEfficiencyPerHour = employeeEfficiencyOne + employeeEfficiencyTwo + employeeEfficiencyThree;
            int hoursCounter = 0;

            while (studentsCount > 0)
            {
                studentsCount -= totalDeskEfficiencyPerHour;
                hoursCounter++;
                if (hoursCounter % 4 == 0)
                {
                    hoursCounter++;
                }
            }

            Console.WriteLine($"Time needed: {hoursCounter}h.");
        }
    }
}
