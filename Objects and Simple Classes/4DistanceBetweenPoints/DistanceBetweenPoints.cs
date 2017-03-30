using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();


            var result = CalcDistance(p1, p2);

            Console.WriteLine($"{result:F3}");
        }
        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

        }

        static Point ReadPoint()
        {
            var pointInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var point = new Point();
            point.X = pointInput[0];
            point.Y = pointInput[1];
            return point;

        }

    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
}
