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

        public static bool flag = true;

        public static string maSach;
        public static string maLoaiSach;

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
            controllerSach.GetAllComboBox(cbMaTacGia, "TACGIA", "MaTacGia", "MaTacGia");
            controllerSach.GetAllComboBox(cbMaLoaiSach, "LOAISACH", "MaLoaiSach", "MaLoaiSach");

            controllerSach.GetAllLoaiSach(dataLoaiSach);
            LoadMaLoaiSach();
        }

        private void dataSach_Click(object sender, EventArgs e)
        {
            try
            {
                flag = false;

                Control[] controls = { txtMaSach, cbMaLoaiSach, cbMaTacGia, txtTenSach, timeNgayNhap,
                    txtNhaXB, txtNamXB, txtGiaSach };
                string[] fielsName = { "MaSach", "MaLoaiSach","MaTacGia", "TenSach",
                        "NgayNhap", "NhaXB", "NamXB", "GiaSach", "TinhTrangMuon" };
                MSS.crud.BindingsFields(dataSach, controls, fielsName);

                maSach = txtMaSach.Text.Trim();
                maLoaiSach = cbMaLoaiSach.Text + "";

                string txtCheck = dataSach.CurrentRow.Cells[8].Value.ToString();

                if (txtCheck == "True")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                flag = true;
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
            radioButton2.Checked = true;
            maSach = "";
            maLoaiSach = "";
            controllerSach.GetAllComboBox(cbMaTacGia, "TACGIA", "MaTacGia", "MaTacGia");
            controllerSach.GetAllComboBox(cbMaLoaiSach, "LOAISACH", "MaLoaiSach", "MaLoaiSach");
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

            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Tên Sách Không Được Để Trống!", "Quản Lý Thư Viện",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNhaXB.Text == "")
            {
                MessageBox.Show("Nhà Xuất Bản Không Được Để Trống!", "Quản Lý Thư Viện",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNamXB.Text == "")
            {
                MessageBox.Show("Năm Xuất Bản Không Được Để Trống!", "Quản Lý Thư Viện",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtGiaSach.Text == "")
            {
                MessageBox.Show("Giá Sách Không Được Để Trống!", "Quản Lý Thư Viện",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtGiaSach.Text) < 0)
            {
                MessageBox.Show("Giá Sách Phải Là Số Dương!", "Quản Lý Thư Viện",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string txtNgayNhap = timeNgayNhap.Value.ToString();

            if (controllerSach.Insert(dataSach, txtMaSach.Text, cbMaLoaiSach.Text,
                    cbMaTacGia.Text, txtTenSach.Text, txtNgayNhap, txtNhaXB.Text,
                    txtNamXB.Text, txtGiaSach.Text, txtCheck))
                {
                    MessageBox.Show("Bạn Đã Thêm Thành Công!", "Quản Lý Thư Viện",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utils.ResetControls(groupBox3);
                    radioButton2.Checked = true;
                    maSach = "";
                    maLoaiSach = "";
                    controllerSach.GetAllComboBox(cbMaTacGia, "TACGIA", "MaTacGia", "MaTacGia");
                    controllerSach.GetAllComboBox(cbMaLoaiSach, "LOAISACH", "MaLoaiSach", "MaLoaiSach");
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

            if (controllerSach.Update(dataSach, txtMaSach.Text, cbMaLoaiSach.Text,
                cbMaTacGia.Text, txtTenSach.Text, txtNgayNhap, txtNhaXB.Text,
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
                Utils.ResetControls(groupBox3);
                radioButton2.Checked = true;
                maSach = "";
                maLoaiSach = "";
                controllerSach.GetAllComboBox(cbMaTacGia, "TACGIA", "MaTacGia", "MaTacGia");
                controllerSach.GetAllComboBox(cbMaLoaiSach, "LOAISACH", "MaLoaiSach", "MaLoaiSach");
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


        private void cbMaLoaiSach_TextChanged(object sender, EventArgs e)
        {
            if (!flag)
            {
                return;
            }

            string MLSach = cbMaLoaiSach.Text + "";
            if (MLSach == maLoaiSach)
            {
                txtMaSach.Text = maSach;
                return;
            }
            else
            {
                flag = true;
            }

            CheckFlag(flag);
        }

        public void CheckFlag(bool flag)
        {
            if (flag)
            {
                string MLSach = cbMaLoaiSach.Text.Trim();
                Random random = new Random();
                string strRand = "S" + MLSach + random.Next(1000, 9999);
                txtMaSach.Text = strRand.Trim();
                txtMaSach.ReadOnly = true;
            }
        }

        public void LoadMaLoaiSach()
        {
            Random random = new Random();
            string strRand = "MLS" + DateTime.Now.ToString("HHmmss") + random.Next(10, 100);
            txtMaLoaiSach.Text = strRand.Trim();
        }

        private void btnRefreshLoaiSach_Click(object sender, EventArgs e)
        {
            Utils.ResetControls(groupBox5);
            LoadMaLoaiSach();
        }

        private void ThemLoaiSach_Click(object sender, EventArgs e)
        {
            if (txtLoaiSach.Text == "")
            {
                MessageBox.Show("LoaiSach Không Được Để Trống!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controllerSach.ThemLoaiSach(dataLoaiSach, txtMaLoaiSach.Text.Trim(), txtLoaiSach.Text.Trim());
            MessageBox.Show("Thêm Loại Sách Thành Công!", "Quản Lý Thư Viện",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Utils.ResetControls(groupBox5);
            LoadMaLoaiSach();
            controllerSach.GetAllComboBox(cbMaLoaiSach, "LOAISACH", "MaLoaiSach", "MaLoaiSach");
        }

        private void dataLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Control[] controls = { txtMaLoaiSach, txtLoaiSach };
            string[] fields = { "MaLoaiSach", "LoaiSach" };
            MSS.crud.BindingsFields(dataLoaiSach, controls, fields);
        }

        private void btnUpdateLoaiSach_Click(object sender, EventArgs e)
        {
            if (txtLoaiSach.Text == "")
            {
                MessageBox.Show("LoaiSach Không Được Để Trống!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controllerSach.CapNhatLoaiSach(dataLoaiSach, txtMaLoaiSach.Text.Trim(), txtLoaiSach.Text.Trim());
            MessageBox.Show("Thêm Loại Sách Thành Công!", "Quản Lý Thư Viện",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Utils.ResetControls(groupBox5);
            LoadMaLoaiSach();
            controllerSach.GetAllComboBox(cbMaLoaiSach, "LOAISACH", "MaLoaiSach", "MaLoaiSach");
        }

        private void txtSearchLoaiSach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                controllerSach.SearchLoaiSACH(dataLoaiSach, txtSearchLoaiSach.Text);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
            }
        }


    }
}
