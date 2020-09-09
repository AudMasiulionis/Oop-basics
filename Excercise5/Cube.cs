using System;

namespace Exercise05
{
    public class Cube : Square
    {
        public Cube(double side) : base(side)
        {
        }

        public override double Area()
        {
            return base.Area() * 6;
        }

        public override double Perimeter()
        {
            return base.Perimeter() * 6;
        }

        public double Volume()
        {
            return Math.Pow(this.Side, 3);
        }
    }
}
