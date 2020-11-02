using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class Student
    {
        public string maSinhVien;
        public string hoTen;
        public int namSinh;
        public string diaChi;

        //Get va Set Ma Sinh Vien
        public void SetMaSinhVien(string maSinhVien)
        {
            this.maSinhVien = maSinhVien;
        }
        public string GetMaSinhVien()
        {
            return this.maSinhVien;
        }

        //Get va Set Ho Ten
        public void SetHoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public string GetHoTen()
        {
            return this.hoTen;
        }

        //Get va Set Nam Sinh
        public void SetNamSinh(int namSinh)
        {
            this.namSinh = namSinh;
        }
        public int GetNamSinh()
        {
            return this.namSinh;
        }

        //Get va Set Dia Chi
        public void SetDiaChi(string diaChi)
        {
            this.diaChi = diaChi;
        }
        public string GetGiamGia()
        {
            return this.diaChi;
        }

        public Student()
        {

        }

        public Student(string maSinhVien, string hoTen, int namSinh, string diaChi)
        {
            this.maSinhVien = maSinhVien;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
        }

        public int TinhTuoiSinhVien()
        {
            DateTime now = DateTime.Now;
            return now.Year - namSinh;
        }

        public void OutPut()
        {
            Console.WriteLine($"- Ma Sinh Vien: {maSinhVien}");
            Console.WriteLine($"- Ho Ten: {hoTen}");
            Console.WriteLine($"- Nam Sinh: {namSinh}");
            Console.WriteLine($"- Dia Chi: {diaChi}");
        }
    }
}
