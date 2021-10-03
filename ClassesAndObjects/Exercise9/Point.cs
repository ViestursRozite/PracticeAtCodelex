using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9
{
    public class Point
    {
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public string Status()
        {
            return ($"X=({ this.X }) Y=({this.Y}) ");
        }

    }
}
