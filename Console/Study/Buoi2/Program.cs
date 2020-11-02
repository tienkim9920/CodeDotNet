using System;

namespace Buoi2
{
    class Program
    {

        static void XuatMang(int[] a, string name)
        {
            Console.Write(name + "[] = {");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}", a[i]);
            }
            Console.Write("}\n");

        }


        static void Main(string[] args)
        {
            int[] a = { 3, 5, 8, 10, 7 };

            int[] b = { 1, 4, 9, 12, 6 };

            XuatMang(a, "A");
            XuatMang(b, "B");

        }
    }
}
