using System;
using System.Collections.Generic;
using System.Globalization;

namespace Buoi1
{
    class Program
    {
        static bool SoNguyenTo(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {


        }
    }
}
