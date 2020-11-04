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

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            controller.GetAllDocGia(dataDocGia);
        }

        private void dataDocGia_Click(object sender, EventArgs e)
        {
            try
            {
                Control[] controls = { txtMaDG, txtMaLoaiDG, txtHoten, txtNgaySinh, txtDiaChi,
                    txtEmail, txtSoSachMuon, txtNgayLapThe, txtTinhTrang };
                string[] fielsName = { "MaDG", "MaLoaiDG","HoTen", "NgaySinh",
                        "DiaChi", "Email", "SoSachMuon", "NgayLapThe", "TinhTrangTraTre" };
                MSS.crud.BindingsFields(dataDocGia, controls, fielsName);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (controller.Update(dataDocGia, txtMaDG.Text, txtHoten.Text, txtNgaySinh.Text, txtDiaChi.Text,
                txtEmail.Text, txtSoSachMuon.Text, txtMaLoaiDG.Text, txtTinhTrang.Text, txtNgayLapThe.Text))
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
            string[] checkStatus = { "True", "False" };

            if (!Utils.CheckIsDateTime(txtNgaySinh.Text)) 
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Ngày Sinh!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgaySinh.Focus();
                return;
            }
            if (!Utils.CheckIsDateTime(txtNgayLapThe.Text))
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Ngày Lap The!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgayLapThe.Focus();
                return;
            }

            bool check = false;
            for (int i = 0; i < checkStatus.Length; i++)
            {
                if (txtTinhTrang.Text == checkStatus[i])
                {
                    check = true;
                }
            }

            if (!check)
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Tình Trạng!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTinhTrang.Focus();
                return;
            }

            if (controller.Insert(dataDocGia, txtMaDG.Text, txtMaLoaiDG.Text, txtHoten.Text, txtNgaySinh.Text, txtDiaChi.Text,
                txtEmail.Text, txtNgayLapThe.Text, txtSoSachMuon.Text, txtTinhTrang.Text))
            {
                MessageBox.Show("Bạn Đã Thêm Thành Công!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtMaDG.Text = "";
            txtHoten.Text = "";
            txtNgaySinh.Text = "yyyy/mm/dd";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSoSachMuon.Text = "VD: 10";
            txtMaLoaiDG.Text = "";
            txtTinhTrang.Text = "True or False";
            txtNgayLapThe.Text = "yyyy/mm/dd";
            controller.GetAllDocGia(dataDocGia);
        }

        private void txtNgaySinh_Enter(object sender, EventArgs e)
        {
            Utils.Enter(txtNgaySinh, "yyyy/mm/dd");
        }

        private void txtNgaySinh_Leave(object sender, EventArgs e)
        {
            Utils.Leave(txtNgaySinh, "yyyy/mm/dd");
        }

        private void txtNgayLapThe_Enter(object sender, EventArgs e)
        {
            Utils.Enter(txtNgayLapThe, "yyyy/mm/dd");
        }

        private void txtNgayLapThe_Leave(object sender, EventArgs e)
        {
            Utils.Leave(txtNgayLapThe, "yyyy/mm/dd");
        }

        private void txtTinhTrang_Enter(object sender, EventArgs e)
        {
            Utils.Enter(txtTinhTrang, "True or False");
        }

        private void txtTinhTrang_Leave(object sender, EventArgs e)
        {
            Utils.Leave(txtTinhTrang, "True or False");
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
    }
}
