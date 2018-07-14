using System;

namespace P11_PriceChangeAlert
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double treshold = double.Parse(Console.ReadLine());
            double last = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double c = double.Parse(Console.ReadLine());
                double diversion = Percentage(last, c);
                bool isSignificantDifference = DifferenceCheck(diversion, treshold);
                string message = GetPercentageDifference(c, last, diversion, isSignificantDifference);
                Console.WriteLine(message);

                last = c;
            }
        }

        private static string GetPercentageDifference(double c, double last, double difference, bool eitherTrueOrFalse)
        {
            string to = "";
            if (difference == 0)
            {
                to = string.Format("NO CHANGE: {0}", c);
            }
            else if (!eitherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, difference);
            }
            else if (eitherTrueOrFalse && (difference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, difference);
            }
            else if (eitherTrueOrFalse && (difference < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, difference);
            return to;
        }

        private static bool DifferenceCheck(double tresshold, double isDifferent)
        {
            if (Math.Abs(tresshold) >= isDifferent)
            {
                return true;
            }
            return false;
        }

        private static double Percentage(double l, double c)
        {
            double r = ((c - l) / l) * 100;
            return r;
        }
    }
}
