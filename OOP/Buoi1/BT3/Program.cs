using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("B1234", "Mindset", 70000, 7000);

            Console.WriteLine("Thong Tin Cua Quyen Sach Hien Tai: ");
            book.OutPut();
            Console.WriteLine($"\nGia Ban Cua Sach La: {book.SellBook()} \n");

            book.SetGiamGia(24000);
            Console.WriteLine("Thong Tin Cua Quyen Sach Sau Khi Cap Nhat: ");
            book.OutPut();
            Console.WriteLine($"\nGia Ban Cua Sach La: {book.SellBook()} \n");
        }
    }
}
