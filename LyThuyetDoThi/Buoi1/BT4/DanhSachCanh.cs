using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class DanhSachCanh
    {
        //Ma Tran Ke

        public int[,] a;
        public int n, m;

        public int[] outPut;


        public void ReadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);

            string[] str = sr.ReadLine().Split();
            n = int.Parse(str[0]);
            m = int.Parse(str[1]);
            a = new int[m, str.Length];

            outPut = new int[n];

            int index = 0;
            for (int i = 0; i < m; i++)
            {
                string[] strTemp = sr.ReadLine().Split();
                for (int j = 0; j < strTemp.Length; j++)
                {
                    int parse = int.Parse(strTemp[j]);
                    a[i, j] = parse;
                    index = a[i, j];
                    outPut[index - 1]++;
                }
            }
            sr.Close();
        }

        public void WriteData()
        {
            Console.Write($"{n} {m}\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
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
                for (int i = 0; i < outPut.Length; i++)
                {
                    sWriter.Write($"{outPut[i]} ");
                }
            }
        }
    }
}
