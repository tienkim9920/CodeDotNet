using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Book
    {
        public string maSach;
        public string tenSach;
        public int giaSach;
        public int giamGia;

        //Get va Set Ma Sach
        public void SetMaSach(string maSach)
        {
            this.maSach = maSach;
        }
        public string GetMaSach()
        {
            return this.maSach;
        }

        //Get va Set Ten Sach
        public void SetTenSach(string tenSach)
        {
            this.tenSach = tenSach;
        }
        public string GetTienSach()
        {
            return this.tenSach;
        }

        //Get va Set Gia Sach
        public void SetGiaSach(int giaSach)
        {
            this.giaSach = giaSach;
        }
        public int GetGiaSach()
        {
            return this.giaSach;
        }

        //Get va Set Giam Gia
        public void SetGiamGia(int giamGia)
        {
            this.giamGia = giamGia;
        }
        public int GetGiamGia()
        {
            return this.giamGia;
        }

        public Book()
        {

        }

        public Book(string maSach, string tenSach, int giaSach, int giamGia)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.giaSach = giaSach;
            this.giamGia = giamGia;
        }

        public int SellBook()
        {
            return this.giaSach - this.giamGia;
        }

        public void OutPut()
        {
            Console.WriteLine($"- Ma So Sach: {maSach}");
            Console.WriteLine($"- Ten Sach: {tenSach}");
            Console.WriteLine($"- Gia Sach: {giaSach}");
            Console.WriteLine($"- Gia Giam: {giamGia}");
        }
    }
}
