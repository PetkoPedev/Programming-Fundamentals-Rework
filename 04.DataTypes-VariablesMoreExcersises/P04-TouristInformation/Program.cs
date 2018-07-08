using System;

namespace P04_TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine().ToLower();
            double value = double.Parse(Console.ReadLine());
            double convertedValue = 0;

            switch (unit)
            {
                case "miles":
                    //to kilometers
                    convertedValue = value * 1.6;
                    Console.WriteLine($"{value} {unit} = {convertedValue:F2} kilometers");
                    break;
                case "inches":
                    //to cantimeters
                    convertedValue = value * 2.54;
                    Console.WriteLine($"{value} {unit} = {convertedValue:F2} centimeters");
                    break;
                case "feet":
                    //to centimeters
                    convertedValue = value * 30;
                    Console.WriteLine($"{value} {unit} = {convertedValue:F2} centimeters");
                    break;
                case "yards":
                    //to meters
                    convertedValue = value * 0.91;
                    Console.WriteLine($"{value} {unit} = {convertedValue:F2} meters");
                    break;
                case "gallons":
                    //to liters
                    convertedValue = value * 3.8;
                    Console.WriteLine($"{value} {unit} = {convertedValue:F2} liters");
                    break;
            }
        }
    }
}
