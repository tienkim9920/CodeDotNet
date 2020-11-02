using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Student
    {
        public string maSinhVien;
        public string hoTen;
        public int namSinh;
        public string diaChi;

        public string Error;
        public bool flag = true;

        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                if (value.Length == 0)
                {
                    Error = "Vui Long Kiem Tra Lai Ho Ten";
                    flag = false;
                }
                else
                {
                    hoTen = value;
                }
            }
        }

        public int NamSinh
        {
            get
            {
                return namSinh;
            }
            set
            {
                if (value < 0)
                {
                    Error = "Vui Long Kiem Tra Lai Nam Sinh";
                    flag = false;
                }
                else
                {
                    namSinh = value;
                }
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                if (value == "")
                {
                    Error = "Vui Long Kiem Tra Lai Dia Chi";
                    flag = false;
                }
                else
                {
                    diaChi = value;
                }
            }
        }

        public Student()
        {

        }

        public Student(string maSinhVien, string hoTen, int namSinh, string diaChi)
        {
            this.maSinhVien = maSinhVien;
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
            this.DiaChi = diaChi;
        }

        public int TinhTuoiSinhVien()
        {
            DateTime now = DateTime.Now;
            return now.Year - namSinh;
        }

        public void OutPut()
        {
            if (flag)
            {
                Console.WriteLine($"- Ma Sinh Vien: {maSinhVien}");
                Console.WriteLine($"- Ho Ten: {hoTen}");
                Console.WriteLine($"- Nam Sinh: {namSinh}");
                Console.WriteLine($"- Dia Chi: {diaChi}");

                Console.WriteLine($"\nTuoi Cua Sinh Vien: {TinhTuoiSinhVien()}");
            }
            else
            {
                Console.WriteLine(Error);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student sinhVien = new Student("18DH110638", "Nguyen Kim Tien", 2000, "299 Phan Huy Ich, " +
                "P13, Quan Go Vap, TP.HCM");
            sinhVien.OutPut();
        }
    }
}
