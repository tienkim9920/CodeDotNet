using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class Circle
    {
        public int banKinh;

        public string Error;
        public bool flag = true;

        public int BanKinh
        {
            get
            {
                return banKinh;
            }
            set
            {
                if (value < 0)
                {
                    Error = "Vui Long Kiem Tra Lai Ban Kinh";
                    flag = false;
                }
                else
                {
                    banKinh = value;
                }
            }
        }

        public Circle()
        {
            this.BanKinh = 1;
        }

        public Circle(int banKinh)
        {
            this.BanKinh = banKinh;
        }

        public void InPut(int i)
        {
            Console.WriteLine($"Nhap Thong Tin Hinh Tron {i}");
            Console.Write("Nhap Ban Kinh r: ");
            BanKinh = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void OutPut(int i)
        {
            if (flag)
            {
                Console.WriteLine($"Thong Tin Hinh Tron {i}");
                Console.WriteLine($"Ban Kinh r: {BanKinh}");
                Console.WriteLine($"Chu Vi Hinh Tron {i + 1}: {chuVi()}");
                Console.WriteLine($"Dien Tich Hinh Tron {i + 1}: {dienTich()} \n");
            }
            else
            {
                Console.WriteLine(Error + "\n");
            }
        }

        public double dienTich()
        {
            return 3.14 * Math.Pow(BanKinh, 2);
        }

        public double chuVi()
        {
            return 2 * 3.14 * BanKinh;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap So Duong Tron n: ");
            int n = int.Parse(Console.ReadLine());

            Circle[] circle = new Circle[n];

            Console.WriteLine("\n###In Put###");
            for (int i = 0; i < n; i++)
            {
                circle[i] = new Circle();
                circle[i].InPut(i + 1);
            }

            Console.WriteLine("###Out Put###");
            for (int i = 0; i < n; i++)
            {
                circle[i].OutPut(i + 1);
            }

            Console.Write("\nDien Tich Hinh Tron Lon Nhat: ");
            double dienTichMax = circle[0].dienTich();
            for (int i = 0; i < n; i++)
            {
                if (circle[i].dienTich() > dienTichMax)
                {
                    dienTichMax = circle[i].dienTich();
                }
            }
            Console.WriteLine(dienTichMax);

        }
    }
}
