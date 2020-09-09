using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    public class Cylinder : Circle
    {
        public Cylinder(double radius, double height) : base(radius)
        {
            this.Height = height;
        }

        public double Height { get; }

        public override double Area()
        {
            return this.Perimeter() * (this.Radius + this.Height);
        }

        public double AreaSide()
        {
            return base.Perimeter() * this.Height;
        }

        public override double Perimeter()
        {
            return (4 * this.Radius) + (2 * this.Height);
        }

        public double Volume()
        {
            return base.Area() * this.Height;
        }
    }
}
