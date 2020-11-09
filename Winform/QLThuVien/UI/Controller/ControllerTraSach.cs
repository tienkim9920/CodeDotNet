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

            //try
            //{
            //    MSS.crud.LoadDataGridViewDataSet(tableName, dataGridView);
            //}
            //catch (Exception ex)
            //{
            //    Utils.MSG(ex.Message);
            //    return;
            //}
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

    }
}
