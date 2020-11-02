using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BT1
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
                    int count = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (a[i, j] == 1)
                            count++;
                    }
                    sWriter.Write($"{count} ");
                }
            }
        }

        public void xuLy(List<int> list)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int tong = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == 1)
                    {
                        tong = tong + a[i, j];
                    }
                }
                list.Add(tong);
            }
        }

        public void outPut(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(" " + list[i]);
            }
            Console.WriteLine();
        }

    }
}
