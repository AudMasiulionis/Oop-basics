namespace Exercise05
{
    public class Shape
    {
        private static int ShapeCount;

        public Shape()
        {
            ShapeCount++;
        }

        public static int GetShapeCount()
        {
            return ShapeCount;
        }
    }
}
