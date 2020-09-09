using System;

namespace Exercise01
{
    public class Point
    {
        public Point()
        {

        }
        public Point(string color)
        {
            Color = color;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(int x, int y, string color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        public double GetDistanceToZero()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public int GetCartesian()
        {
            if (X > 0 && Y > 0)
            {
                return 1;
            }
            if (X < 0 && Y > 0)
            {
                return 2;
            }
            if (X < 0 && Y < 0)
            {
                return 3;
            }
            if (X > 0 && Y < 0)
            {
                return 4;
            }
            return 0;
        }

        public bool SameCartesian(Point other)
        {
            return GetCartesian() == other.GetCartesian();
        }
    }
}
