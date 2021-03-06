﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Controller;
using UI.Models;
using UtilsBasic2020;

namespace UI
{
    public partial class CTTraSach : Form
    {
        DataQLTVDataContext db = new DataQLTVDataContext();

        public CTTraSach()
        {
            InitializeComponent();
            LoadAllData();
        }

        ControllerTraSach traSach = new ControllerTraSach();

        private void LoadAllData()
        {
            //traSach.GetAllComboBox(cbMaDGMuon, "DOCGIA", "MaDG", "MaDG");

            string[] fieldsDG = { "MaDG", "HoTen" };
            traSach.GetDataFields(dataDocGia, "DOCGIA", fieldsDG);

            //Các Sách Chưa Mượn
            string[] where = { "TinhTrangMuon" };
            string[] whereValues = { "True" };
            string[] fields = { "MaSach", "TenSach", "NhaXB", "TinhTrangMuon" };
            traSach.GetAllDataWhere("SACH", dataSachDaMuon, where, whereValues, fields);

            //Load Các Phiếu Trả Sách
            traSach.GetAllData(dataTraSach);

            //LoadComBoDGMuon();
        }

        //private void LoadComBoDGMuon()
        //{
        //    string[] whereDGMuon = { "MaDG" };
        //    string[] whereValuesDGMuon = { cbMaDGMuon.SelectedValue.ToString() };
        //    string[] fieldsDGMuon = { "MaDG", "HoTen", "MaMuonSach", "MaSach", "TenSach", "NgayMuon", "TinhTrangMuon" };
        //    traSach.GetAllDataWhere("vDGMuonSach2", dataDocGiaMuon, whereDGMuon, whereValuesDGMuon,
        //        fieldsDGMuon);
        //}

        //private void cbMaDGMuon_TextChanged(object sender, EventArgs e)
        //{
        //    LoadComBoDGMuon();
        //}

        private void dataDocGiaMuon_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Control[] controls = { txtMaDG, txtHoTen, txtMaMuonSach, txtMaSach,
            //        txtTenSach, timeNgayMuon};
            //    string[] fielsName = { "MaDG", "HoTen", "MaMuonSach", "MaSach", "TenSach",
            //        "NgayMuon", "TinhTrangMuon" };
            //    MSS.crud.BindingsFields(dataDocGiaMuon, controls, fielsName);

            //    string txtCheck = dataDocGiaMuon.CurrentRow.Cells[6].Value.ToString();

            //    if (txtCheck == "True")
            //    {
            //        tinhTrangMuon.Checked = true;
            //    }

            //    Random random = new Random();
            //    string strRand = "MT" + DateTime.Now.ToString("HHmmss") + random.Next(1, 100);
            //    txtMaTraSach.Text = strRand;
            //    txtMaTraSach.ReadOnly = true;

            //    string strRand2 = "CTPTS" + DateTime.Now.ToString("HHmmss") + random.Next(1, 100);
            //    txtMaCTPTS.Text = strRand2;
            //    txtMaCTPTS.ReadOnly = true;
            //}
            //catch (Exception ex)
            //{
            //    Utils.MSG(ex.Message);
            //    return;
            //}
        }

        private void txtSoNgayMuon_TextChanged(object sender, EventArgs e)
        {
            string soNgayMuon = txtSoNgayMuon.Text;

            if (soNgayMuon == "-")
            {
                MessageBox.Show("Số Ngày Mượn Phải Là Số Dương!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoNgayMuon.Text = "";
                txtSoNgayMuon.Focus();
                return;
            }

            if (soNgayMuon == "")
            {
                soNgayMuon = "0";
            }

            if (int.Parse(soNgayMuon) < 5)
            {
                txtTienPhat.Text = "0đ";
                txtTienPhat.ReadOnly = true;
                return;
            }

            if (soNgayMuon == "")
            {
                txtTienPhat.Text = "0đ";
                txtTienPhat.ReadOnly = true;
                return;
            }

            if (int.Parse(soNgayMuon) > 4)
            {
                int soTienPhat = (int.Parse(soNgayMuon) - 4) * 2000;
                txtTienPhat.Text = soTienPhat.ToString() + "đ";
                txtTienPhat.ReadOnly = true;
            }
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            string soNgayMuon = txtSoNgayMuon.Text;

            if (soNgayMuon == "-")
            {
                MessageBox.Show("Số Ngày Mượn Phải Là Số Dương!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoNgayMuon.Text = "";
                txtSoNgayMuon.Focus();
                return;
            }

            if (soNgayMuon == "")
            {
                MessageBox.Show("Số Ngày Mượn Không Được Để Trống!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoNgayMuon.Text = "";
                txtSoNgayMuon.Focus();
                return;
            }

            PHIEUTRASACH phieuTra = new PHIEUTRASACH();

            phieuTra.MaTraSach = txtMaTraSach.Text.Trim();
            phieuTra.MaMuonSach = txtMaMuonSach.Text.Trim();
            string[] splitNgayTra = timeNgayTra.Value.ToString().Split(' ');
            phieuTra.NgayTra = splitNgayTra[0];


            CTPHIEUTRASACH CTPhieuTra = new CTPHIEUTRASACH();
            CTPhieuTra.MaCTPTS = txtMaCTPTS.Text.Trim();
            CTPhieuTra.MaTraSach = txtMaTraSach.Text.Trim();
            CTPhieuTra.MaSach = txtMaSach.Text.Trim();
            CTPhieuTra.SoNgayMuon = int.Parse(txtSoNgayMuon.Text.Trim());
            string tienPhat = txtTienPhat.Text.Replace('đ', ' ').Trim();
            CTPhieuTra.TienPhat = int.Parse(tienPhat);


            CTPHIEUMUONSACH MaCTPMS = db.CTPHIEUMUONSACHes.Single(ct => ct.MaMuonSach.Equals(txtMaMuonSach.Text));
            db.CTPHIEUMUONSACHes.DeleteOnSubmit(MaCTPMS);
            db.SubmitChanges();

            traSach.InsertTraSach(phieuTra, CTPhieuTra);

            SACH sach = db.SACHes.Single(s => s.MaSach.Equals(CTPhieuTra.MaSach));
            sach.TinhTrangMuon = false;
            db.SubmitChanges();

            DOCGIA docGia = db.DOCGIAs.Single(dg => dg.MaDG.Equals(txtMaDG.Text.Trim()));
            docGia.SoSachMuon -= 1;
            db.SubmitChanges();

            MessageBox.Show("Bạn Đã Trả Sách Thành Công!", "Quản Lý Thư Viện",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataTraSach.DataSource = db.vTraSaches.Select(vts => vts);

            string tempMaDG = txtMaDG.Text;
            Utils.ResetControls(groupBox3);
            tinhTrangMuon.Checked = true;

            string[] whereDGMuon = { "MaDG" };
            string[] whereValuesDGMuon = { tempMaDG };
            traSach.GetAllDataWhere2("vDGMuonSach2", dataDocGiaMuon, whereDGMuon, whereValuesDGMuon);

        }

        private void dataDocGiaMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Control[] controls = { txtMaDG, txtHoTen, txtMaMuonSach, txtMaSach,
                    txtTenSach, timeNgayMuon};
                string[] fielsName = { "MaDG", "HoTen", "MaMuonSach", "MaSach", "TenSach",
                    "NgayMuon", "TinhTrangMuon" };
                MSS.crud.BindingsFields(dataDocGiaMuon, controls, fielsName);

                DataGridViewRow rw = this.dataDocGiaMuon.Rows[e.RowIndex];
                string txtCheck = rw.Cells[6].Value.ToString();

                if (txtCheck == "True")
                {
                    tinhTrangMuon.Checked = true;
                }

                Random random = new Random();
                string strRand = "MT" + DateTime.Now.ToString("HHmmss") + random.Next(1, 100);
                txtMaTraSach.Text = strRand;
                txtMaTraSach.ReadOnly = true;

                string strRand2 = "CTPTS" + DateTime.Now.ToString("HHmmss") + random.Next(1, 100);
                txtMaCTPTS.Text = strRand2;
                txtMaCTPTS.ReadOnly = true;

                string txtNgayMuon = timeNgayMuon.Text;
                string txtNgayTra = timeNgayTra.Text;

                string[] splitNgayMuon = txtNgayMuon.Split('/');
                string[] splitNgayTra = txtNgayTra.Split('/');

                int NgayMuon = int.Parse(splitNgayMuon[1]);
                int NgayTra = int.Parse(splitNgayTra[1]);

                if (NgayMuon == NgayTra)
                {
                    txtSoNgayMuon.Text = "1";
                }

                if (NgayTra > NgayMuon)
                {
                    int tongSoNgayMuon = NgayTra - NgayMuon;
                    txtSoNgayMuon.Text = tongSoNgayMuon.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thể Bấm Vào Đây!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataDocGia_Click(object sender, EventArgs e)
        {
            try
            {
                Control[] controls = { txtMaDG };
                string[] fielsName = { "MaDG" };
                MSS.crud.BindingsFields(dataDocGia, controls, fielsName);

                string[] whereDGMuon = { "MaDG" };
                string[] whereValuesDGMuon = { txtMaDG.Text };
                traSach.GetAllDataWhere2("vDGMuonSach2", dataDocGiaMuon, whereDGMuon, whereValuesDGMuon);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        private void txtSearchDG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                traSach.SearchDG(dataDocGia, txtSearchDG.Text);
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
