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
        DataQLTVDataContext db = new DataQLTVDataContext();

        public void GetAllSach(DataGridView dataGridView)
        {
            try
            {
                MSS.crud.LoadDataGridViewDataSet("vSach", dataGridView);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        public void GetAllTacGia(DataGridView dataGridView)
        {
            try
            {
                MSS.crud.LoadDataGridViewDataSet("TACGIA", dataGridView);
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

        public void GetAllLoaiSach(DataGridView dataGrid)
        {
            try
            {
                var dsLoaiDG = db.LOAISACHes.Select(value => value);
                dataGrid.DataSource = dsLoaiDG.ToList();
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        public void ThemLoaiSach(DataGridView dataGrid, string txtMaLoaiSach, string txtLoaiSach)
        {
            try
            {
                LOAISACH loaiSach = new LOAISACH();
                loaiSach.MaLoaiSach = txtMaLoaiSach;
                loaiSach.LoaiSach = txtLoaiSach;

                db.LOAISACHes.InsertOnSubmit(loaiSach);
                db.SubmitChanges();

                var dsLoaiSach = db.LOAISACHes.Select(value => value);
                dataGrid.DataSource = dsLoaiSach.ToList();
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
            }
        }

        public void CapNhatLoaiSach(DataGridView dataGrid, string txtMaLoaiSach, string txtLoaiSach)
        {
            try
            {
                LOAISACH loaiSach = db.LOAISACHes.Single(value => value.MaLoaiSach.Equals(txtMaLoaiSach));
                loaiSach.LoaiSach = txtLoaiSach;
                db.SubmitChanges();

                var dsLoaiSach = db.LOAISACHes.Select(value => value);
                dataGrid.DataSource = dsLoaiSach.ToList();
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
            }
        }

        public void SearchLoaiSACH(DataGridView dataGrid, string txtMaLoaiSach)
        {
            try
            {
                string[] where = { "MaLoaiSach", "LoaiSach" };
                string[] whereValues = { txtMaLoaiSach, txtMaLoaiSach };
                MSS.crud.Search(dataGrid, "LOAISACH", where, whereValues);
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
            }
        }
    }
}
