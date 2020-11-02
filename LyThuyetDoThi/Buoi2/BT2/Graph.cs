using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Graph
    {

        public int n;

        public string[] arrGetRecord;

        public string[] arrPoint;

        public List<string> arrResult = new List<string>();

        public void ReadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);

            string str = sr.ReadLine();
            n = int.Parse(str);

            arrPoint = new string[n];

            for (int i = 0; i < arrPoint.Length; i++)
            {
                arrPoint[i] = (i + 1).ToString();
            }

            arrGetRecord = new string[n];

            for (int i = 0; i < n; i++)
            {
                string strTemp = sr.ReadLine();

                arrGetRecord[i] = strTemp; 
            }

            sr.Close();
        }

        public void XuLy()
        {
            for (int i = 0; i < n; i++)
            {
                string[] getPoint = arrGetRecord[i].Split(' ');
                for (int j = 0; j < getPoint.Length; j++)
                {
                    if (arrResult.Count == 0)
                    {
                        arrResult.Add((i + 1) + " " + getPoint[j]);
                    }
                    else
                    {
                        bool flag = false;
                        for (int k = 0; k < arrResult.Count; k++)
                        {
                            if (arrResult[k].Equals(getPoint[j] + " " + (i + 1)))
                            {
                                flag = true;
                            }
                        }

                        if(!flag)
                        {
                            arrResult.Add((i + 1) + " " + getPoint[j]);
                        }
                    }
                }
            }
        }

        public void WriteData()
        {
            XuLy();
            Console.Write($"{n} {arrResult.Count}\n");
            for (int i = 0; i < arrResult.Count; i++)
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
