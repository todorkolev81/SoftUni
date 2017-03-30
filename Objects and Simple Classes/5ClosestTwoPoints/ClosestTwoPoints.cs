using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main()
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }
        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

        }
        static void PrintDistance(Point[] points)
        {
            double distance = CalcDistance(points[0], points[1]);
            Console.WriteLine("{0:f3}", distance);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            var minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            }
            return closestTwoPoints;
        }


        static Point[] ReadPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
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
