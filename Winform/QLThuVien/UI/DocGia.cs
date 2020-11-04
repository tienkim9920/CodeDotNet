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

    }
}
