using System;

namespace Exercise05
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; }

        public virtual double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public virtual double Perimeter()
        {
            return Math.PI * 2 * this.Radius;
        }
    }
}
