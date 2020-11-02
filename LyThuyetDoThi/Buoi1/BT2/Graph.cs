using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BT2
{
    class Graph
    {
        //Ma Tran Ke
        public int[,] a;

        public int n;


        public void ReadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);

            n = int.Parse(sr.ReadLine());
            a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = sr.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    a[i, j] = int.Parse(s[j]);
            }
            sr.Close();
        }

        public void WriteData()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{a[i, j]} ");
                Console.WriteLine();
            }
        }

        public void WriteDoThi(string fName)
        {
            using (StreamWriter sWriter = new StreamWriter(fName))
            {
                sWriter.WriteLine(n);
                for (int i = 0; i < n; i++)
                {
                    int bacRa = 0;
                    int bacVao = 0;
                    for (int j = 0; j < n; j++)
                    {
                        bacVao += a[j, i];
                        bacRa += a[i, j];
                    }
                    sWriter.Write($"{bacVao} {bacRa}\n");
                }
            }
        }

    }
}
