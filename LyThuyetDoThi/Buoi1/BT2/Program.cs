using System;
using System.Collections.Generic;
using System.IO;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph maTranKe = new Graph();

            maTranKe.ReadData("BACVAOBACRA.INP");
            maTranKe.WriteData();

            Console.WriteLine("######OUT PUT######");

            maTranKe.WriteDoThi("BACVAOBACRA.OUT");

        }
    }
}
