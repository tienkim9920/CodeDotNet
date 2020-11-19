using Bunifu.Framework.UI;
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
        DataQLTVDataContext db = new DataQLTVDataContext();

        public void GetAllDocGia(DataGridView dataGrid)
        {
            try
            {
                string[] fields = { "MaDG", "MaLoaiDG", "LoaiDG", "HoTen", "NgaySinh", "DiaChi", "Email",
                    "NgayLapThe", "SoSachMuon", "TinhTrangTraTre" };
                MSS.crud.LoadDataGridViewDataSet("vDocGia", dataGrid, fields);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        public void GetAllLoaiDG(DataGridView dataGrid)
        {
            try
            {
                var dsLoaiDG = db.LOAIDGs.Select(value => value);
                dataGrid.DataSource = dsLoaiDG.ToList();
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        public void GetAllDataWhere(string tableName, DataGridView dataGridView,
            string[] where, string[] whereValues, string[] fields)
        {
            try
            {
                MSS.crud.LoadDataGridViewDataSet(tableName, dataGridView, where, whereValues, fields, "and");
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        public void GetAllComboBox(ComboBox comboBox, string table, string fieldShow, string fieldID)
        {
            try
            {
                MSS.crud.LoadComboBoxDataSet(comboBox, table, fieldShow, fieldID, true);
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
                    MaDG = MaDG.Trim(),
                    MaLoaiDG = MaLoaiDG,
                    HoTen = HoTen.Trim(),
                    NgaySinh = slitNgaySinh[0],
                    DiaChi = DiaChi.Trim(),
                    Email = Email.Trim(),
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
                    MaDG = MaDG.Trim(),
                    MaLoaiDG = MaLoaiDG.Trim(),
                    HoTen = HoTen.Trim(),
                    NgaySinh = NgaySinh.Trim(),
                    DiaChi = DiaChi.Trim(),
                    Email = Email.Trim(),
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

        public void ThemLoaiDG(DataGridView dataGrid, string txtMaLoaiDG, string txtLoaiDG)
        {
            try
            {
                LOAIDG loaiDG = new LOAIDG();
                loaiDG.MaLoaiDG = txtMaLoaiDG;
                loaiDG.LoaiDG = txtLoaiDG;

                db.LOAIDGs.InsertOnSubmit(loaiDG);
                db.SubmitChanges();

                var dsLoaiDG = db.LOAIDGs.Select(value => value);
                dataGrid.DataSource = dsLoaiDG.ToList();
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
            }
        }

        public void CapNhatLoaiDG(DataGridView dataGrid, string txtMaLoaiDG, string txtLoaiDG)
        {
            try
            {
                LOAIDG loaiDG = db.LOAIDGs.Single(value => value.MaLoaiDG.Equals(txtMaLoaiDG));
                loaiDG.LoaiDG = txtLoaiDG;
                db.SubmitChanges();

                var dsLoaiDG = db.LOAIDGs.Select(value => value);
                dataGrid.DataSource = dsLoaiDG.ToList();
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
            }
        }

        public void SearchLoaiDG(DataGridView dataGrid, string txtMaLoaiDG)
        {
            try
            {
                string[] where = { "MaLoaiDG", "LoaiDG" };
                string[] whereValues = { txtMaLoaiDG, txtMaLoaiDG };
                MSS.crud.Search(dataGrid, "LOAIDG", where, whereValues);
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
            }
        }


    }
}
