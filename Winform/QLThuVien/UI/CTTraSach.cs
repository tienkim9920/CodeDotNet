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
            traSach.GetAllComboBox(cbMaDGMuon, "DOCGIA", "MaDG", "MaDG");

            //Các Sách Chưa Mượn
            string[] where = { "TinhTrangMuon" };
            string[] whereValues = { "True" };
            string[] fields = { "MaSach", "TenSach", "NhaXB", "TinhTrangMuon" };
            traSach.GetAllDataWhere("SACH", dataSachDaMuon, where, whereValues, fields);

            //Load Các Phiếu Trả Sách
            traSach.GetAllData(dataTraSach);

            LoadComBoDGMuon();
        }

        private void LoadComBoDGMuon()
        {
            string[] whereDGMuon = { "MaDG" };
            string[] whereValuesDGMuon = { cbMaDGMuon.SelectedValue.ToString() };
            string[] fieldsDGMuon = { "MaDG", "HoTen", "MaMuonSach", "MaSach", "TenSach", "NgayMuon", "TinhTrangMuon" };
            traSach.GetAllDataWhere("vDGMuonSach2", dataDocGiaMuon, whereDGMuon, whereValuesDGMuon,
                fieldsDGMuon);
        }

        private void cbMaDGMuon_TextChanged(object sender, EventArgs e)
        {
            LoadComBoDGMuon();
        }

        private void dataDocGiaMuon_Click(object sender, EventArgs e)
        {
            try
            {
                Control[] controls = { txtMaDG, txtHoTen, txtMaMuonSach, txtMaSach,
                    txtTenSach, timeNgayMuon};
                string[] fielsName = { "MaDG", "HoTen", "MaMuonSach", "MaSach", "TenSach",
                    "NgayMuon", "TinhTrangMuon" };
                MSS.crud.BindingsFields(dataDocGiaMuon, controls, fielsName);

                string txtCheck = dataDocGiaMuon.CurrentRow.Cells[6].Value.ToString();

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
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        private void txtSoNgayMuon_TextChanged(object sender, EventArgs e)
        {

            string soNgayMuon = txtSoNgayMuon.Text;

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

            traSach.InsertTraSach(phieuTra, CTPhieuTra);

            SACH sach = db.SACHes.Single(s => s.MaSach.Equals(CTPhieuTra.MaSach));
            sach.TinhTrangMuon = false;
            db.SubmitChanges();

            DOCGIA docGia = db.DOCGIAs.Single(dg => dg.MaDG.Equals(txtMaDG.Text.Trim()));
            docGia.SoSachMuon -= 1;
            db.SubmitChanges();

            dataTraSach.DataSource = db.vTraSaches.Select(vts => vts);

        }
    }
}
