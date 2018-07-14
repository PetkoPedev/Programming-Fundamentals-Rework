using System;
using System.Globalization;

namespace P10_HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)

        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            holidaysCount = CalcHolidays(startDate, endDate, holidaysCount);
            Console.WriteLine(holidaysCount);
        }

        private static int CalcHolidays(
            DateTime startDate, DateTime endDate, int holidaysCount)
        {
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            return holidaysCount;
        }

    }
}
