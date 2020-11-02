using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Graph
    {
        //Ma Tran Ke

        public int[,] arrGetValue;

        public int[] numberDinh;

        public int n, m;

        public int[,] outPut;


        public string[] arrGetRecord;

        public string[] arrPoint;

        public string[] arrResult;

        public void ReadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);

            string[] str = sr.ReadLine().Split();
            n = int.Parse(str[0]);
            m = int.Parse(str[1]);

            arrPoint = new string[n];

            for (int i = 0; i < arrPoint.Length; i++)
            {
                arrPoint[i] = (i + 1).ToString();
            }

            arrGetRecord = new string[m];

            for (int i = 0; i < m; i++)
            {
                string strTemp = sr.ReadLine();

                arrGetRecord[i] = strTemp;

            }

            sr.Close();
        }

        public void XuLy()
        {
            arrResult = new string[n];
            for (int i = 0; i < n; i++)
            {
                string concatPoint = "";
                for (int j = 0; j < m; j++)
                {
                    string[] getPoint = arrGetRecord[j].Split(' ');
                    if (getPoint[0].Equals(arrPoint[i]))
                    {
                        concatPoint += getPoint[1] + " ";
                    }
                    if (getPoint[1].Equals(arrPoint[i]))
                    {
                        concatPoint += getPoint[0] + " ";
                    }
                }
                arrResult[i] = concatPoint;
            }
        }

        public void WriteData()
        {
            XuLy();
            Console.Write($"{n} {m}\n");

            for (int i = 0; i < arrResult.Length; i++)
            {
                Console.WriteLine($"{arrResult[i]} ");
            }

        }

        public void WriteDoThi(string fName)
        {
            using (StreamWriter sWriter = new StreamWriter(fName))
            {
                
            }
        }
    }
}
