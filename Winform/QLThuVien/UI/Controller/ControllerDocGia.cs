using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsBasic2020;

namespace UI.Controller
{
    class ControllerDocGia
    {
        //Load Du Lieu
        public void GetAllDocGia(DataGridView dataGrid)
        {
            try
            {
                MSS.crud.LoadDataGridViewDataSet("DOCGIA", dataGrid);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        public bool Update(DataGridView dataGrid ,string MaDG ,string HoTen, string NgaySinh, string DiaChi,
            string Email, string SoSachMuon, string MaLoaiDG, string TinhTrang, string NgayLapThe)
        {
            try
            {
                string[] slitNgaySinh = NgaySinh.Split(' ');
                string[] slitNgayLapThe = NgayLapThe.Split(' ');

                Models.DocGia docGia = new Models.DocGia()
                {
                    MaDG = MaDG,
                    MaLoaiDG = MaLoaiDG,
                    HoTen = HoTen,
                    NgaySinh = slitNgaySinh[0],
                    DiaChi = DiaChi,
                    Email = Email,
                    SoSachMuon = int.Parse(SoSachMuon),
                    TinhTrangTraTre = TinhTrang,
                    NgayLapThe = slitNgayLapThe[0]
                };

                string[] parameters = { "MaLoaiDG", "HoTen", "NgaySinh", "DiaChi", "Email", "SoSachMuon",
                    "TinhTrangTraTre", "NgayLapThe" };
                string[] values = { docGia.MaLoaiDG ,docGia.HoTen, docGia.NgaySinh, docGia.DiaChi, docGia.Email,
                        docGia.SoSachMuon.ToString(), docGia.TinhTrangTraTre, docGia.NgayLapThe };
                string[] where = { "MaDG" };
                string[] whereValues = { docGia.MaDG };
                MSS.crud.Update("DOCGIA", parameters, values, where, whereValues);
                GetAllDocGia(dataGrid);
                return true;
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return false;
            }
        }

        public bool Insert(DataGridView dataGrid, string MaDG, string MaLoaiDG, string HoTen, string NgaySinh, string DiaChi,
                string Email, string NgayLapThe, string SoSachMuon, string TinhTrang)
        {
            try
            {
                Models.DocGia docGia = new Models.DocGia()
                {
                    MaDG = MaDG,
                    MaLoaiDG = MaLoaiDG,
                    HoTen = HoTen,
                    NgaySinh = NgaySinh,
                    DiaChi = DiaChi,
                    Email = Email,
                    NgayLapThe = NgayLapThe,
                    SoSachMuon = int.Parse(SoSachMuon),
                    TinhTrangTraTre = TinhTrang,
                };



                string[] parameters = { "MaDG", "MaLoaiDG", "HoTen", "NgaySinh", "DiaChi", "Email", "NgayLapThe", "SoSachMuon",
                    "TinhTrangTraTre" };
                string[] values = { docGia.MaDG ,docGia.MaLoaiDG ,docGia.HoTen, docGia.NgaySinh, docGia.DiaChi, docGia.Email,
                         docGia.NgayLapThe, docGia.SoSachMuon.ToString(), docGia.TinhTrangTraTre };
                MSS.crud.Insert("DOCGIA", parameters, values);
                GetAllDocGia(dataGrid);
                return true;
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return false;
            }
        }

        public bool Delete(DataGridView dataGrid, string MaDG)
        {
            try
            {
                Models.DocGia docGia = new Models.DocGia()
                {
                    MaDG = MaDG,
                };
                string[] where = { "MaDG" };
                string[] whereValues = { docGia.MaDG };
                MSS.crud.Delete("DOCGIA", where, whereValues);
                GetAllDocGia(dataGrid);
                return true;
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return false;
            }
        }

        public void Search(DataGridView dataGrid, string MaDG)
        {
            try
            {
                string[] where = { "MaDG", "HoTen" };
                string[] whereValues = { MaDG, MaDG };
                MSS.crud.Search(dataGrid, "DOCGIA", where, whereValues);
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
            }
        }
    }
}
