using System;

namespace P04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double studioPerNight = 0;
            double doublePerNight = 0;
            double suitePerNight = 0;

            switch (month)
            {
                case "may":
                case "october":
                    studioPerNight = 50;
                    doublePerNight = 65;
                    suitePerNight = 75;
                    if (nights > 7)
                    {
                        studioPerNight *= 0.95;
                    }
                    break;
                case "june":
                case "september":
                    studioPerNight = 60;
                    doublePerNight = 72;
                    suitePerNight = 82;
                    if (nights > 14)
                    {
                        doublePerNight *= 0.90;
                    }
                    break;
                case "july":
                case "august":
                case "december":
                    studioPerNight = 68;
                    doublePerNight = 77;
                    suitePerNight = 89;
                    if (nights > 14)
                    {
                        suitePerNight *= 0.85;
                    }
                    break;
            }

            double totalStudioPrice = studioPerNight * nights;
            double totalDoublePrice = doublePerNight * nights;
            double totalSuitePrice = suitePerNight * nights;

            if ((month == "september" || month == "october") && nights > 7)
            {
                totalStudioPrice -= studioPerNight;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:F2} lv.");
        }
    }
}
