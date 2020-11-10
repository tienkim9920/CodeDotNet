using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsBasic2020;

namespace UI.Controller
{
    class ControllerMuonSach
    {
        DataQLTVDataContext db = new DataQLTVDataContext();

        public void GetAllMuonSach(DataGridView dataGridView, string tableName)
        {
            try
            {
                MSS.crud.LoadDataGridViewDataSet(tableName, dataGridView);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
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

        public void GetAllDataWhere2(string tableName, DataGridView dataGridView,
            string[] where, string[] whereValues)
        {
            try
            {
                string[] fieldsDGMuon = { "MaDG", "HoTen", "NgayMuon", "TenSach", "GiaSach", "TinhTrangMuon" };
                MSS.crud.LoadDataGridViewDataSet(tableName, dataGridView, where, whereValues, fieldsDGMuon);
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

        //Insert Vào Phiếu Mượn Sách
        public bool Insert(DataGridView dataGridView, string MaSach, string TinhTrangMuon,
            string MaMuonSach, string MaCTPMS, string MaDG, string NgayMuon)
        {

            try
            {
                Models.MuonSach muonSach = new Models.MuonSach()
                {
                    MaSach = MaSach,
                    TinhTrang = TinhTrangMuon,
                    MaMuonSach = MaMuonSach,
                    MaCTPMS = MaCTPMS,
                    MaDG = MaDG,
                    NgayMuon = NgayMuon
                };

                //vPhieuSach

                //Phieu Muon Sach
                string[] parameters = { "MaMuonSach", "MaDG", "NgayMuon" };
                string[] values = { muonSach.MaMuonSach, muonSach.MaDG, muonSach.NgayMuon };
                MSS.crud.Insert("PHIEUMUONSACH", parameters, values);

                //Phieu CT Muon Sach
                string[] parameterCT = { "MaCTPMS", "MaMuonSach", "MaSach" };
                string[] valueCT = { muonSach.MaCTPMS, muonSach.MaMuonSach, muonSach.MaSach };
                MSS.crud.Insert("CTPHIEUMUONSACH", parameterCT, valueCT);

                //Update Tình Trạng Sách
                string[] parameterSach = { "TinhTrangMuon" };
                string[] valueSach = { muonSach.TinhTrang };
                string[] where = { "MaSach" };
                string[] whereValues = { muonSach.MaSach };
                MSS.crud.Update("SACH", parameterSach, valueSach, where, whereValues);

                var countRow = db.PHIEUMUONSACHes.Where(pms => pms.MaDG.Equals(muonSach.MaDG)).Count();

                //Update Số Sách Mượn
                string[] parameterSoSach = { "SoSachMuon" };
                string[] valueSoSach = { countRow.ToString() };
                string[] whereSoSach = { "MaDG" };
                string[] whereValuesSoSach = { muonSach.MaDG };
                MSS.crud.Update("DOCGIA", parameterSoSach, valueSoSach, whereSoSach, whereValuesSoSach);

                GetAllMuonSach(dataGridView, "vPhieuSach");
                return true;
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return false;
            }
        }


        //Tìm Kiếm Phiếu Mượn Sách
        public void Search(DataGridView dataGrid, string MaMuonSach)
        {
            try
            {
                string[] where = { "MaMuonSach", "TenSach" };
                string[] whereValues = { MaMuonSach, MaMuonSach };
                MSS.crud.Search(dataGrid, "vPhieuSach", where, whereValues);
            }
            catch (Exception err)
            {
                Utils.MSG(err.Message);
                return;
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


        //Xóa Phiếu Mượn Sách
        public bool Delete(DataGridView dataGrid, string MaMuonSach, string MaCTPMS)
        {
            try
            {
                string[] whereMMS = { "MaMuonSach" };
                string[] whereValueMMS = { MaMuonSach };
                MSS.crud.Delete("PHIEUMUONSACH", whereMMS, whereValueMMS);

                string[] whereCTPMS = { "MaCTPMS" };
                string[] whereValueCTPMS = { MaCTPMS };
                MSS.crud.Delete("CTPHIEUMUONSACH", whereCTPMS, whereValueCTPMS);

                GetAllMuonSach(dataGrid, "vPhieuSach");
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
