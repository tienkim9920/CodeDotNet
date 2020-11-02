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
        static List<string> result = new List<string>();

        public string[] arrPoint;

        public string[] arrGetRecord;

        static int n, m;

        public void ReadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);

            string[] str = sr.ReadLine().Split();
            n = int.Parse(str[0]);
            m = int.Parse(str[1]);

            arrPoint = new string[n];
            arrGetRecord = new string[n];

            for (int i = 0; i < arrPoint.Length; i++)
            {
                arrPoint[i] = (i + 1).ToString();
            }

            for (int i = 0; i < arrGetRecord.Length; i++)
            {
                string strTemp = sr.ReadLine();

                arrGetRecord[i] = strTemp;

            }

            string[] strSplit = arrGetRecord[m - 1].Split(' ');

            for (int i = 0; i < strSplit.Length; i++)
            {
                result.Add(strSplit[i]);
            }

            sr.Close();
        }

        public void xuLy()
        {
            int lengthList = result.Count;

            for (int i = 0; i < lengthList; i++)
            {
                int getDinh = Convert.ToInt32(result[i]);

                string[] strGetDinh = arrGetRecord[getDinh - 1].Split(' ');

                for (int j = 0; j < strGetDinh.Length; j++)
                {
                    if (int.Parse(strGetDinh[j]) != m)
                    {
                        result.Add(strGetDinh[j]);
                    }
                }
            }
        }

        public void WriteData()
        {
            xuLy();
            Console.WriteLine(result.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
