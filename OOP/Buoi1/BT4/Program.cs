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
            Student sinhVien = new Student("18DH110638", "Nguyen Kim Tien", 2000, "299 Phan Huy Ich, " +
                "P13, Quan Go Vap, TP.HCM");
            sinhVien.OutPut();
            Console.WriteLine($"\nTuoi Cua Sinh Vien: {sinhVien.TinhTuoiSinhVien()}");
        }
    }
}
