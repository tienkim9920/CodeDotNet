using System;
using System.Collections.Generic;
using System.Text;

namespace BT1
{
    class Vector
    {

        Vector vectorA;
        Vector vectorB;

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

        public Vector()
        {

        }

        public Vector(Vector A, Vector B)
        {
            this.vectorA = A;
            this.vectorB = B;
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }


        public Vector TongHaiVector(Vector A, Vector B)
        {
            
            this.vectorA = A;
            this.vectorB = B;

            x = vectorA.getX() + vectorB.getX();
            y = vectorA.getY() + vectorB.getY();

            Vector vectorC = new Vector(x, y);

            return vectorC;
        }

        public Vector HieuHaiVecto(Vector A, Vector B)
        {

            this.vectorA = A;
            this.vectorB = B;

            x = vectorA.getX() - vectorB.getX();
            y = vectorA.getY() - vectorB.getY();

            Vector vectorC = new Vector(x, y);

            return vectorC;
        }

    }
}
