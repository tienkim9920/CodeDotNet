using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Account
    {
        public string maSoTaiKhoan;
        public int soTien;

        public string Error;
        public bool flag = true;

        public string MaSoTaiKhoan
        {
            get => maSoTaiKhoan;
            set => maSoTaiKhoan = value;
        }
        public int SoTien
        {
            get
            {
                return soTien;
            }
            set
            {
                if (value > 0)
                {
                    soTien = value;
                }
                else
                {
                    Error = "Vui Long Kiem Tra Lai So Tien!";
                    flag = false;
                }
            }
        }

        public Account()
        {

        }

        public Account(string maSoTaiKhoan, int soTien)
        {
            this.MaSoTaiKhoan = maSoTaiKhoan;
            this.SoTien = soTien;
        }

        public void OutPut()
        {
            if (!flag)
            {
                Console.WriteLine(Error);
            }
            else
            {
                Console.WriteLine($"- Ma So Tai Khoan: {MaSoTaiKhoan}");
                Console.WriteLine($"- So Tien: {SoTien}");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Account taikhoan = new Account("18DH110638", 1000000);

            Console.WriteLine("Thong Tin Tai Khoan Hien Tai: ");
            taikhoan.OutPut();

            taikhoan.SoTien = -60000;
            Console.WriteLine("\nThong Tin Tai Khoan Sau Khi Cap Nhat: ");
            taikhoan.OutPut();
        }
    }
}
