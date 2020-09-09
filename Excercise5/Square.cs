using System;

namespace Exercise05
{
    public class Square : Shape
    {
        public Square(double side)
        {
            Side = side;
        }

        public double Side { get; }

        public virtual double Perimeter()
        {
            return 4 * this.Side;
        }

        public virtual double Area()
        {
            return Math.Pow(this.Side, 2);
        }
    }
}
