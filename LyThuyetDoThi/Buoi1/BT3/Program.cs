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
            DanhSachKe danhSachKe = new DanhSachKe();

            danhSachKe.ReadData("DANHSACHKE.INP");
            danhSachKe.WriteData();
            danhSachKe.WriteDoThi("DANHSACHKE.OUT");
        }
    }
}
