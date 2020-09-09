namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point();
            point.X = 5;
            point.Y = 99;

            var point1 = new Point();
            point1.X = 15;
            point1.Y = 199;

            var point3 = new Point("Green");

            var point4 = new Point(1, 2);

            var point5 = new Point(-4, 5, "Red");

            var catesian = point.GetCartesian();

            var distanceToZero = point.GetDistanceToZero();

            var same = point.SameCartesian(point5);
        }
    }
}
