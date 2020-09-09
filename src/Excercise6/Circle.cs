using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; }

        public override double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * this.Radius;
        }
    }
}
