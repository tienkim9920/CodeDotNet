using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Book
    {
        public string maSach;
        public string tenSach;
        public int giaSach;
        public int giamGia;

        public string Error;
        public bool flag = true;

        public string MaSach
        {
            get
            {
                return maSach;
            }
            set
            {
                if (value == "")
                {
                    Error = "Vui Long Kiem Tra Lai Ma Sach!";
                    flag = false;
                }
                else
                {
                    maSach = value;
                }
            }
        }

        public int GiaSach
        {
            get
            {
                return giaSach;
            }
            set
            {
                if (value > 0)
                    giaSach = value;
                else
                {
                    Error = "Vui Long Kiem Tra Lai Gia Sach!";
                    flag = false;
                }
            }
        }

        public int GiaGiam
        {
            get
            {
                return giamGia;
            }
            set
            {
                if (value > 0)
                    giamGia = value;
                else
                {
                    Error = "Vui Long Kiem Tra Lai Gia Giam!";
                    flag = false;
                }
            }
        }

        public Book()
        {

        }

        public Book(string maSach, string tenSach, int giaSach, int giamGia)
        {
            this.MaSach = maSach;
            this.tenSach = tenSach;
            this.GiaSach = giaSach;
            this.GiaGiam = giamGia;
        }

        public int SellBook()
        {
            return this.giaSach - this.giamGia;
        }

        public void OutPut()
        {
            if (!flag)
            {
                Console.WriteLine(Error + "\n");
            }
            else
            {
                Console.WriteLine($"- Ma So Sach: {maSach}");
                Console.WriteLine($"- Ten Sach: {tenSach}");
                Console.WriteLine($"- Gia Sach: {giaSach}");
                Console.WriteLine($"- Gia Giam: {giamGia}");
                Console.WriteLine($"\nGia Ban Cua Sach La: {SellBook()} \n");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("B1234", "Mindset", 70000, 7000);

            Console.WriteLine("Thong Tin Cua Quyen Sach Hien Tai: ");
            book.OutPut();

            book.GiaGiam = -300;
            Console.WriteLine("Thong Tin Cua Quyen Sach Sau Khi Cap Nhat: ");
            book.OutPut();
        }
    }
}
