using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Circle
    {
        public int banKinh;

        public void SetBanKinh(int banKinh)
        {
            this.banKinh = banKinh;
        }

        public int GetBanKinh()
        {
            return banKinh;
        }

        public Circle()
        {
            this.banKinh = 1;
        }

        public Circle(int banKinh)
        {
            this.banKinh = banKinh;
        }

        public void InPut()
        {
            Console.WriteLine("Nhap Thong Tin Hinh Tron: ");
            Console.Write("Nhap Ban Kinh r: ");
            banKinh = int.Parse(Console.ReadLine());
            SetBanKinh(banKinh);
            Console.WriteLine();
        }

        public void OutPut()
        {
            Console.WriteLine("Thong Tin Hinh Tron: ");
            Console.WriteLine($"Ban Kinh r: {banKinh} \n");
        }

        public double dienTich()
        {
            return 3.14 * Math.Pow(banKinh, 2);
        }

        public double chuVi()
        {
            return 2 * 3.14 * banKinh;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.OutPut();

            circle.InPut();
            circle.OutPut();

            Console.WriteLine($"\nDien Tich Hinh Tron: {circle.dienTich()}");
            Console.WriteLine($"\nChu Vi Hinh Tron: {circle.chuVi()}");

        }
    }
}
