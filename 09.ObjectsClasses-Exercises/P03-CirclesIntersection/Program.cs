using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection_of_Circles
{
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circleOne = ReadCircle(Console.ReadLine());
            Circle circleTwo = ReadCircle(Console.ReadLine());
            int deltaX = circleOne.Center.X - circleTwo.Center.X;
            int deltaY = circleOne.Center.Y - circleTwo.Center.Y;
            double distanceOfCenters = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (distanceOfCenters > circleOne.Radius + circleTwo.Radius)
            {
                Console.WriteLine("No");
            }
            else
                Console.WriteLine("Yes");
        }

        private static Circle ReadCircle(string input)
        {
            int[] token = input.Split(' ').Select(int.Parse).ToArray();
            return new Circle { Center = new Point { X = token[0], Y = token[1] }, Radius = token[2] };
        }
    }
}
