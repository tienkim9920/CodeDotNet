using System;
using System.ComponentModel;

namespace Buoi4
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
            int[] a = { 1, 2, 3 };
            XuatMang(a, "a");

            int[] b = { 3, 1, 2};
            XuatMang(b, "b");

            int j = b.Length - 1;

            bool flag = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[j])
                {
                    flag = false;
                    continue;
                }
                else
                {
                    flag = true;
                    i = -1;
                    j--;
                    if (j == 0)
                        break;
                }
            }
            if (flag)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Fasle");
            }

        }
    }
}
