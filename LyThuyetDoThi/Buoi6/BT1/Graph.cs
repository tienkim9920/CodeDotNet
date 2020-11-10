using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BT1
{
    class Graph
    {

        public static int n;
        public static string[] arrStore;
        
        public void ReadData(string fileName)
        {
            StreamReader stream = new StreamReader(fileName);
            n = int.Parse(stream.ReadLine());

            arrStore = new string[n];

            for (int i = 0; i < arrStore.Length; i++)
            {
                arrStore[i] = stream.ReadLine();
            }
        }

        public void WriteData()
        {
            for (int i = 0; i < arrStore.Length; i++)
            {
                Console.WriteLine(arrStore[i]);
            }
        }

    }
}
