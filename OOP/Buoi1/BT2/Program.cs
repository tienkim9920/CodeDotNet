using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account taikhoan = new Account("18DH110638", 1000000);

            Console.WriteLine("Thong Tin Tai Khoan Hien Tai: ");
            taikhoan.OutPut();

            taikhoan.setSoTien(800000);
            Console.WriteLine("\nThong Tin Tai Khoan Sau Khi Cap Nhat: ");
            taikhoan.OutPut();
        }
    }
}
