using System;
using System.Collections.Generic;
using System.Text;

namespace BT1
{
    class Point
    {
        public double x;
        public double y;

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
