using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Account
    {
        private string maSoTaiKhoan;
        private int soTien;

        public void setMaSoTaiKhoan(string maSoTaiKhoan)
        {
            this.maSoTaiKhoan = maSoTaiKhoan;
        }

        public string getMaSoTaiKhoan()
        {
            return this.maSoTaiKhoan;
        }

        public void setSoTien(int soTien)
        {
            this.soTien = soTien;
        }

        public int getSoTien()
        {
            return this.soTien;
        }

        public Account()
        {

        }

        public Account(string maSoTaiKhoan, int soTien)
        {
            this.maSoTaiKhoan = maSoTaiKhoan;
            this.soTien = soTien;
        }

        public void OutPut()
        {
            Console.WriteLine($"- Ma So Tai Khoan: {maSoTaiKhoan}");
            Console.WriteLine($"- So Tien: {soTien}");
        }
    }
}
