using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;
using UtilsBasic2020;

namespace UI.Controller
{
    class ControllerTraSach
    {
        DataQLTVDataContext db = new DataQLTVDataContext();

        public void GetAllData(DataGridView dataGridView)
        {
            var model = db.vTraSaches.Select(vts => vts).ToList();
            dataGridView.DataSource = model;
        }

        public void GetDataFields(DataGridView dataGridView, string tableName, string[] fields)
        {
            try
            {
                MSS.crud.LoadDataGridViewDataSet(tableName, dataGridView, fields);
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

        public void GetAllDataWhere2(string tableName, DataGridView dataGridView,
            string[] where, string[] whereValues)
        {
            try
            {
                string[] fieldsDGMuon = { "MaDG", "HoTen", "MaMuonSach", "MaSach", "TenSach", "NgayMuon", "TinhTrangMuon" };
                MSS.crud.LoadDataGridViewDataSet(tableName, dataGridView, where, whereValues, fieldsDGMuon);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        public bool InsertTraSach(PHIEUTRASACH phieuTraSach, CTPHIEUTRASACH CTPhieuTraSach)
        {
            try
            {
                db.PHIEUTRASACHes.InsertOnSubmit(phieuTraSach);
                db.SubmitChanges();
                db.CTPHIEUTRASACHes.InsertOnSubmit(CTPhieuTraSach);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return true;
            }
        }

        public void SearchDG(DataGridView dataGrid, string MaDG)
        {
            try
            {
                string[] where = { "MaDG", "HoTen" };
                string[] whereValues = { MaDG, MaDG };
                string[] fields = { "MaDG", "HoTen" };
                MSS.crud.Search(dataGrid, "DOCGIA", where, whereValues, fields);
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
            }
        }

        public void SearchDGMuonSach(DataGridView dataGrid, string MaSach)
        {
            try
            {
                string[] where = { "MaSach", "TenSach" };
                string[] whereValues = { MaSach, MaSach };
                string[] fieldsDGMuon = { "MaDG", "HoTen", "MaMuonSach", "MaSach", "TenSach", "NgayMuon", "TinhTrangMuon" };
                MSS.crud.Search(dataGrid, "vDGMuonSach2", where, whereValues, fieldsDGMuon);
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
            }
        }

    }
}
