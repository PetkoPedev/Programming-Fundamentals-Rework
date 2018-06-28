using System;

namespace _08_RefactorVolumePiramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //double length, width, volume = 0;
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double volume = double.Parse(Console.ReadLine());
            volume = (length * width * volume) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
