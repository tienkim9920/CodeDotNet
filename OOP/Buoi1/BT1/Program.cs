using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {

            Vector vectorAB = new Vector(1, 3);

            Vector vectorCD = new Vector(4, 6);

            Console.WriteLine("Toa do cua Vector AB = ({0}, {1})", vectorAB.getX(), vectorAB.getY());
            Console.WriteLine("Toa do cua Vector CD = ({0}, {1})", vectorCD.getX(), vectorCD.getY());
            Console.WriteLine("#######OutPut#######\n");

            Vector VectorNew = new Vector();

            VectorNew.TongHaiVector(vectorAB, vectorCD);
            Console.WriteLine("Tong cua 2 Vector = ({0}, {1})", VectorNew.getX(), VectorNew.getY());

            VectorNew.HieuHaiVecto(vectorAB, vectorCD);
            Console.WriteLine("Hieu cua 2 Vector = ({0}, {1})", VectorNew.getX(), VectorNew.getY());


        }
    }
}
