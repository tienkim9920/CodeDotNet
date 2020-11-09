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
    public partial class DocGia : Form
    {
        //Controller
        ControllerDocGia controller = new ControllerDocGia();

        public DocGia()
        {
            InitializeComponent();
        }

        private Point currentPoint;

        private void DocGia_MouseDown(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
        }

        private void DocGia_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - currentPoint.X;
                int dy = e.Location.Y - currentPoint.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            controller.GetAllDocGia(dataDocGia);
        }

        private void dataDocGia_Click(object sender, EventArgs e)
        {
            try
            {
                Control[] controls = { txtMaDG, txtMaLoaiDG, txtHoten, timeNgaySinh, txtDiaChi,
                    txtEmail, txtSoSachMuon, timeNgayLapThe };
                string[] fielsName = { "MaDG", "MaLoaiDG","HoTen", "NgaySinh",
                        "DiaChi", "Email", "SoSachMuon", "NgayLapThe", "TinhTrangTraTre" };
                MSS.crud.BindingsFields(dataDocGia, controls, fielsName);

                string txtCheck = dataDocGia.CurrentRow.Cells[8].Value.ToString();

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

            string txtNgaySinh = timeNgaySinh.Value.ToString();
            string txtNgayLapThe = timeNgayLapThe.Value.ToString();

            if (controller.Update(dataDocGia, txtMaDG.Text, txtHoten.Text, txtNgaySinh, txtDiaChi.Text,
                txtEmail.Text, txtSoSachMuon.Text, txtMaLoaiDG.Text, txtCheck, txtNgayLapThe))
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

            string txtNgaySinh = timeNgaySinh.Value.ToString();
            string txtNgayLapThe = timeNgayLapThe.Value.ToString();

            if (controller.Insert(dataDocGia, txtMaDG.Text, txtMaLoaiDG.Text, txtHoten.Text, txtNgaySinh, txtDiaChi.Text,
                    txtEmail.Text, txtNgayLapThe, txtSoSachMuon.Text, txtCheck))
            {
                    MessageBox.Show("Bạn Đã Thêm Thành Công!", "Quản Lý Thư Viện",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utils.ResetControls(groupBox3);
                    txtSoSachMuon.Text = "VD: 10";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (controller.Delete(dataDocGia, txtMaDG.Text))
            {
                MessageBox.Show("Bạn Đã Xóa Thành Công!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Search(dataDocGia, txtKeyword.Text);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Utils.ResetControls(groupBox3);
            txtSoSachMuon.Text = "VD: 10";
            radioButton1.Checked = true;
        }

        private void txtSoSachMuon_Enter(object sender, EventArgs e)
        {
            Utils.Enter(txtSoSachMuon, "VD: 10");
        }

        private void txtSoSachMuon_Leave(object sender, EventArgs e)
        {
            Utils.Leave(txtSoSachMuon, "VD: 10");
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                controller.Search(dataDocGia, txtKeyword.Text);
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

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
