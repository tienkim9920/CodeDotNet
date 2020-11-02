using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class DanhSachKe
    {
        //Ma Tran Ke

        public int[,] a;
        public static int n;


        public void ReadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);

            n = int.Parse(sr.ReadLine());
            a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] strTemp = sr.ReadLine().Split();
                for (int j = 0; j < strTemp.Length; j++)
                {
                    a[i, j] = int.Parse(strTemp[j]);
                }
            }
            sr.Close();
        }

        public void WriteData()
        {
            Console.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == 0)
                        continue;
                    Console.Write($"{a[i, j]} ");
                }
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
                        if (a[i, j] != 0)
                            count++;
                    }
                    sWriter.Write($"{count} ");
                }
            }
        }

    }
}
