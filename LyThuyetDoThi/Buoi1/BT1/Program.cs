using System;
using System.Collections.Generic;
using System.IO;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph maTranKe = new Graph();

            maTranKe.ReadData("BACDOTHIVOHUONG.INP");
            maTranKe.WriteData();

            Console.WriteLine("######OUT PUT######");

            maTranKe.WriteDoThi("BACDOTHIVOHUONG.OUT");

        }
    }
}
