using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsBasic2020;

namespace UI.Controller
{
    class ControllerSach
    {
        public void GetAllSach(DataGridView dataGridView)
        {
            try
            {
                MSS.crud.LoadDataGridViewDataSet("SACH", dataGridView);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        public bool Insert(DataGridView dataGrid, string MaSach, string MaLoaiSach, string MaTacGia, string TenSach, string NgayNhap,
        string NhaXB, string NamXB, string GiaSach, string TinhTrang)
        {
            try
            {
                Models.Sach sach = new Models.Sach()
                {
                    MaSach = MaSach,
                    MaLoaiSach = MaLoaiSach,
                    MaTacGia = MaTacGia,
                    TenSach = TenSach,
                    NgayNhap = NgayNhap,
                    NhaXB = NhaXB,
                    NamXB = NamXB,
                    GiaSach = int.Parse(GiaSach),
                    TinhTrangMuon = TinhTrang,
                };

                string[] parameters = { "MaSach", "MaLoaiSach", "MaTacGia", "TenSach", "NgayNhap",
                    "NhaXB", "NamXB", "GiaSach", "TinhTrangMuon" };
                string[] values = { sach.MaSach, sach.MaLoaiSach, sach.MaTacGia, sach.TenSach, sach.NgayNhap, sach.NhaXB,
                         sach.NamXB, sach.GiaSach.ToString(), sach.TinhTrangMuon };
                MSS.crud.Insert("SACH", parameters, values);
                GetAllSach(dataGrid);
                return true;
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return false;
            }
        }

        public bool Delete(DataGridView dataGrid, string MaSach)
        {
            try
            {
                Models.Sach sach = new Models.Sach()
                {
                    MaSach = MaSach,
                };
                string[] where = { "MaSach" };
                string[] whereValues = { sach.MaSach };
                MSS.crud.Delete("SACH", where, whereValues);
                GetAllSach(dataGrid);
                return true;
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return false;
            }
        }

        public bool Update(DataGridView dataGrid, string MaSach, string MaLoaiSach, string MaTacGia, string TenSach, string NgayNhap,
            string NhaXB, string NamXB, string GiaSach, string TinhTrang)
        {
            try
            {
                string[] slitNgayNhap = NgayNhap.Split(' ');

                Models.Sach sach = new Models.Sach()
                {
                    MaSach = MaSach,
                    MaLoaiSach = MaLoaiSach,
                    MaTacGia = MaTacGia,
                    TenSach = TenSach,
                    NgayNhap = slitNgayNhap[0],
                    NhaXB = NhaXB,
                    NamXB = NamXB,
                    GiaSach = int.Parse(GiaSach),
                    TinhTrangMuon = TinhTrang,
                };

                string[] parameters = { "MaLoaiSach", "MaTacGia", "TenSach", "NgayNhap",
                    "NhaXB", "NamXB", "GiaSach", "TinhTrangMuon" };
                string[] values = { sach.MaLoaiSach, sach.MaTacGia, sach.TenSach, sach.NgayNhap, sach.NhaXB,
                         sach.NamXB, sach.GiaSach.ToString(), sach.TinhTrangMuon };
                string[] where = { "MaSach" };
                string[] whereValues = { sach.MaSach };
                MSS.crud.Update("SACH", parameters, values, where, whereValues);
                GetAllSach(dataGrid);
                return true;
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return false;
            }
        }

        public void Search(DataGridView dataGrid, string MaSach)
        {
            try
            {
                string[] where = { "MaSach", "TenSach" };
                string[] whereValues = { MaSach, MaSach };
                MSS.crud.Search(dataGrid, "SACH", where, whereValues);
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
            }
        }


    }
}
