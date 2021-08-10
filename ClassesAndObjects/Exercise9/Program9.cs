using System;

namespace Exercise9
{
    class Program9
    {
        static void Main(string[] args)
        {
            Point first = new Point(1, 4);
            Point second = new Point(-7, 5);

            Console.WriteLine("first: " + first.Status());
            Console.WriteLine("second: " + second.Status());

            SwapPoints(first, second);

            Console.WriteLine("first: " + first.Status());
            Console.WriteLine("second: " + second.Status());

            Console.ReadKey();
        }
        static void SwapPoints(Point p1, Point p2)
        {
            double pointSwapHolder = 0;
            pointSwapHolder = p2.Y;
            p2.Y = p1.Y;
            p1.Y = pointSwapHolder;

            pointSwapHolder = p2.X;
            p2.X = p1.X;
            p1.X = pointSwapHolder;

        }
    }
}
