using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachCanh danhSachCanh = new DanhSachCanh();

            danhSachCanh.ReadData("DANHSACHCANH.INP");
            danhSachCanh.WriteData();

            //danhSachCanh.WriteDoThi("DANHSACHCANH.OUT");
        }
    }
}
