using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Buoi5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bài Tập
            //Loại bỏ ký tự giống nhau trong chuỗi
            // Input: "arrrqrtea"
            // Output: "arqte"
            #region

            //string n = "arrrqrtea";
            //List<char> listXuLy = new List<char>();

            //List<char> listKetQua = new List<char>();

            //listXuLy.AddRange(n);

            //for (int i = 0; i < listXuLy.Count; i++)
            //{
            //    char kyTu = listXuLy[i];

            //    bool kiemTra = listKetQua.Contains(kyTu);

            //    if (kiemTra == false)
            //        listKetQua.Add(kyTu);
            //}

            //Console.Write("Chuoi moi la: ");
            //listKetQua.ForEach(e => Console.Write(e));
            #endregion

            #region
            // Game Oan Tu Ti
            //Console.WriteLine("Day La Game Oan Tu Ti");
            //Console.WriteLine("##### Bat Dau #####");
            //NhapLai:
            //Console.WriteLine("\nLua Chon: (Bao - 1) || (Bua - 2) || (Keo - 3)");
            //Console.Write("Ban Chon Gi: ");
            //int user = Convert.ToInt32(Console.ReadLine());

            //Random random = new Random();
            //int robot = random.Next(1, 4);

            //switch (robot)
            //{
            //    case 1:
            //        Console.WriteLine("RoBot chon Bao");
            //        break;
            //    case 2:
            //        Console.WriteLine("RoBot chon Bua");
            //        break;
            //    default:
            //        Console.WriteLine("RoBot chon Keo");
            //        break;
            //}

            //switch (user)
            //{
            //    case 1:
            //        if (robot == 2)
            //        {
            //            Console.WriteLine("Chuc Mung Ban Da Chien Thang!");
            //        }
            //        else if (robot == 3)
            //        {
            //            Console.WriteLine("Robot Chien Thang!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Tran Dau Hoa!");
            //        }
            //        break;
            //    case 2:
            //        if (robot == 2)
            //        {
            //            Console.WriteLine("Tran Dau Hoa!");
            //        }
            //        else if (robot == 3)
            //        {
            //            Console.WriteLine("Chuc Mung Ban Da Chien Thang!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Robot Chien Thang!");
            //        }
            //        break;
            //    default:
            //        if (robot == 2)
            //        {
            //            Console.WriteLine("Robot Chien Thang!");
            //        }
            //        else if (robot == 3)
            //        {
            //            Console.WriteLine("Tran Dau Hoa!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Chuc Mung Ban Da Chien Thang!");
            //        }
            //        break;
            //}

            //Console.WriteLine("Ban Co Muon Choi Tiep Khong! - (1 = Yes) || (0 = No)");
            //Console.Write("Moi Nhap: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n == 1)
            //    goto NhapLai;
            #endregion

            int n = 10;

            //string ketQua = (n >= 10) ? "N Lon Hoac Bang 10" : "N Be Hon 10";

            if (n >= 10)
            {
                Console.WriteLine("N Lon Hoac Bang 10");
            }
            else
            {
                Console.WriteLine("N Be Hon 10");
            }

            //Console.WriteLine(ketQua);

        }
    }
}
