using System;

namespace Exercise06
{
    public class Square : Shape
    {
        public Square(double side)
        {
            Side = side;
        }

        public double Side { get; }

        public override double Perimeter()
        {
            return 4 * this.Side;
        }

        public override double Area()
        {
            return Math.Pow(this.Side, 2);
        }
    }
}
