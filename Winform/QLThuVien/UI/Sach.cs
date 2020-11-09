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
    public partial class Sach : Form
    {
        ControllerSach controllerSach = new ControllerSach();

        public Sach()
        {
            InitializeComponent();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            controllerSach.GetAllSach(dataSach);
        }

        private void dataSach_Click(object sender, EventArgs e)
        {
            try
            {
                Control[] controls = { txtMaSach, txtMaLoaiSach, txtMaTacGia, txtTenSach, timeNgayNhap,
                    txtNhaXB, txtNamXB, txtGiaSach };
                string[] fielsName = { "MaSach", "MaLoaiSach","MaTacGia", "TenSach",
                        "NgayNhap", "NhaXB", "NamXB", "GiaSach", "TinhTrangMuon" };
                MSS.crud.BindingsFields(dataSach, controls, fielsName);

                string txtCheck = dataSach.CurrentRow.Cells[8].Value.ToString();

                if (txtCheck == "True")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
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
            radioButton1.Checked = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string txtCheck = "";
            if (radioButton1.Checked)
            {
                txtCheck = "True";
            }
            else
            {
                txtCheck = "False";
            }

            string txtNgayNhap = timeNgayNhap.Value.ToString();

            if (controllerSach.Insert(dataSach, txtMaSach.Text, txtMaLoaiSach.Text,
                    txtMaTacGia.Text, txtTenSach.Text, txtNgayNhap, txtNhaXB.Text,
                    txtNamXB.Text, txtGiaSach.Text, txtCheck))
                {
                    MessageBox.Show("Bạn Đã Thêm Thành Công!", "Quản Lý Thư Viện",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utils.ResetControls(groupBox3);
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string txtCheck = "";
            if (radioButton1.Checked)
            {
                txtCheck = "True";
            }
            else
            {
                txtCheck = "False";
            }

            string txtNgayNhap = timeNgayNhap.Value.ToString();

            if (controllerSach.Update(dataSach, txtMaSach.Text, txtMaLoaiSach.Text,
                txtMaTacGia.Text, txtTenSach.Text, txtNgayNhap, txtNhaXB.Text,
                txtNamXB.Text, txtGiaSach.Text, txtCheck))
            {
                MessageBox.Show("Bạn Đã Update Thành Công!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (controllerSach.Delete(dataSach, txtMaSach.Text))
            {
                MessageBox.Show("Bạn Đã Xóa Thành Công!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                controllerSach.Search(dataSach, txtKeyword.Text);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
            }
        }

        private void txtKeyword_Enter(object sender, EventArgs e)
        {
            Utils.Enter(txtKeyword, "Enter Here!");
        }

        private void txtKeyword_Leave(object sender, EventArgs e)
        {
            Utils.Leave(txtKeyword, "Enter Here!");
        }
    }
}
