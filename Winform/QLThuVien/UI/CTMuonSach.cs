using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Controller;
using UtilsBasic2020;

namespace UI
{
    public partial class CTMuonSach : Form
    {
        ControllerMuonSach muonSach = new ControllerMuonSach();

        DataQLTVDataContext db = new DataQLTVDataContext();

        public CTMuonSach()
        {
            InitializeComponent();
            LoadAllData();
        }

        private static string MaMuonSach;
        private static string MaCTPMS;

        //private void LoadComBoDGMuon()
        //{
        //    string[] whereDGMuon = { "MaDG" };
        //    string[] whereValuesDGMuon = { cbMaDGMuon.SelectedValue.ToString() };
        //    string[] fieldsDGMuon = { "MaDG", "HoTen", "NgayMuon", "TenSach", "GiaSach", "TinhTrangMuon" };
        //    muonSach.GetAllDataWhere("vDGMuonSach", dataDocGiaMuon, whereDGMuon, whereValuesDGMuon,
        //        fieldsDGMuon);
        //}

        private void LoadAllData()
        {
            //muonSach.GetAllComboBox(cbMaDG, "DOCGIA", "MaDG", "MaDG");
            //muonSach.GetAllComboBox(cbMaDGMuon, "DOCGIA", "MaDG", "MaDG");

            //List Các Phiếu Mượn
            muonSach.GetAllMuonSach(dataMuonSach, "vPhieuSach");

            string[] fieldsDG = { "MaDG", "HoTen" };
            muonSach.GetDataFields(dataDocGia, "DOCGIA", fieldsDG);

            //List Các Loại Sách Mà 1 Độc Giả Đã Mượn
            //LoadComBoDGMuon();

            //Các Sách Chưa Mượn
            string[] where = { "TinhTrangMuon" };
            string[] whereValues = { "False" };
            string[] fields = { "MaSach", "TenSach", "NhaXB", "TinhTrangMuon" };
            muonSach.GetAllDataWhere("SACH", dataSachChuaMuon, where, whereValues, fields);

        }

        //Insert Phiếu Mượn Sách
        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            DOCGIA docGia1 = db.DOCGIAs.Single(dg => dg.MaDG.Equals(txtMaDG.Text.Trim()));

            if (docGia1.SoSachMuon > 3)
            {
                MessageBox.Show("Mỗi Độc Giả Chỉ Có Thể Mượn Tối Đa 4 Quyển Sách!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Utils.TextBoxMSG(txtMaSach, "", "Mã Sách Không Được Để Trống!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error))
            {
                txtMaSach.Focus();
                return;
            }

            string txtCheck = "";
            if (tinhTrangMuon.Checked)
            {
                txtCheck = "True";
            }
            else
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Tình Trạng Mượn!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Utils.TextBoxMSG(txtMaMuonSach, "", "Mã Mượn Sách Không Được Để Trống!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error))
            {
                txtMaMuonSach.Focus();
                return;
            }

            if (Utils.TextBoxMSG(txtMaCTPMS, "", "Mã CTPMS Không Được Để Trống!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error))
            {
                txtMaCTPMS.Focus();
                return;
            }

            string txtNgayMuon = timeNgayMuon.Value.ToString();

            muonSach.Insert(dataMuonSach, dataDocGia, txtMaSach.Text, txtCheck, txtMaMuonSach.Text,
                txtMaCTPMS.Text, txtMaDG.Text, txtNgayMuon);
            MessageBox.Show("Bạn Đã Mượn Sách Thành Công!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            string temp = txtMaDG.Text.Trim();
            Utils.ResetControls(groupBox3);
            tinhTrangMuon.Checked = false;
            txtMaDG.Text = temp;

            //Các Sách Chưa Mượn
            string[] where = { "TinhTrangMuon" };
            string[] whereValues = { "False" };
            string[] fields = { "MaSach", "TenSach", "NhaXB", "TinhTrangMuon" };
            muonSach.GetAllDataWhere("SACH", dataSachChuaMuon, where, whereValues, fields);

            string[] whereDGMuon = { "MaDG" };
            string[] whereValuesDGMuon = { txtMaDG.Text };
            muonSach.GetAllDataWhere2("vDGMuonSach", dataDocGiaMuon, whereDGMuon, whereValuesDGMuon);

            LoadAllData();

            muonSach.GetAllMuonSach(dataMuonSach, "vPhieuSach");

            db = new DataQLTVDataContext();
        }

        //DataGridView Binding Sách Chưa Mượn 
        private void dataSachChuaMuon_Click(object sender, EventArgs e)
        {
            try
            {
                Control[] controls = { txtMaSach, txtTenSach, txtNhaXB, tinhTrangMuon };
                string[] fielsName = { "MaSach", "TenSach", "NhaXB", "TinhTrangMuon" };
                MSS.crud.BindingsFields(dataSachChuaMuon, controls, fielsName);

                Random random = new Random();
                string strRand = "MM" + DateTime.Now.ToString("HHmmss") + random.Next(1, 100);
                txtMaMuonSach.Text = strRand;
                txtMaMuonSach.ReadOnly = true;

                string strRand2 = "CTPMS" + DateTime.Now.ToString("HHmmss") + random.Next(1, 100);
                txtMaCTPMS.Text = strRand2;
                txtMaCTPMS.ReadOnly = true;

                tinhTrangMuon.Checked = true;
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        //DataGridView Search Phiếu Mượn Sách
        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                muonSach.Search(dataMuonSach, txtKeyword.Text);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        //Xóa Phiếu Mượn Sách
        private void btnXoaPhieuMuon_Click(object sender, EventArgs e)
        {
            try
            {
                if(muonSach.Delete(dataMuonSach, MaMuonSach, MaCTPMS))
                {
                    MessageBox.Show("Bạn Đã Xóa Phiếu Mượn Thành Công!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        //DataGridView Click Để Lấy Dữ Liệu Cho Việc Xóa Phiếu
        private void dataMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rw = this.dataMuonSach.Rows[e.RowIndex];
                MaMuonSach = rw.Cells[0].Value.ToString();
                MaCTPMS = rw.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Không Thể Bấm Vào Đây!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //private void cbMaDGMuon_TextChanged(object sender, EventArgs e)
        //{
        //    LoadComBoDGMuon();
        //}

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataDocGia_Click(object sender, EventArgs e)
        {
            try
            {

                Control[] controls = { txtMaDG };
                string[] fielsName = { "MaDG" };
                MSS.crud.BindingsFields(dataDocGia, controls, fielsName);

                string[] where = { "MaDG" };
                string[] whereValues = { txtMaDG.Text };
                muonSach.GetAllDataWhere2("vDGMuonSach", dataDocGiaMuon, where, whereValues);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        //Tìm Kiếm Độc Giả Cần Mượn
        private void txtSearchDG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                muonSach.SearchDG(dataDocGia, txtSearchDG.Text);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Utils.ResetControls(groupBox3);
        }
    }
}
