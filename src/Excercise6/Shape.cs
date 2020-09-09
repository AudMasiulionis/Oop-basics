using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    public abstract class Shape
    {
        private static int ShapeCount;

        protected Shape()
        {
            ShapeCount++;
        }

        public static int GetShapeCount()
        {
            return ShapeCount;
        }

        public abstract double Area();

        public abstract double Perimeter();
    }
}
