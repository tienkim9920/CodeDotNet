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
        
    }
}
