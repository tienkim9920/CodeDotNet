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

        public static bool flag = true;

        public static string maDG;
        public static string maLoaiDG;

        //Controller
        ControllerDocGia controller = new ControllerDocGia();

        DataQLTVDataContext db = new DataQLTVDataContext();

        public DocGia()
        {
            InitializeComponent();
            maLoaiDG = cbMaLoaiDG.Text + "";
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
            controller.GetAllLoaiDG(dataLoaiDG);
            controller.GetAllComboBox(cbMaLoaiDG, "LOAIDG", "MaLoaiDG", "MaLoaiDG");
            LoadMaLoaiDG();
        }

        private void dataDocGia_Click(object sender, EventArgs e)
        {
            try
            {
                flag = false;

                Control[] controls = { txtMaDG, cbMaLoaiDG, txtHoten, timeNgaySinh, txtDiaChi,
                    txtEmail, txtSoSachMuon, timeNgayLapThe };
                string[] fielsName = { "MaDG", "MaLoaiDG","HoTen", "NgaySinh",
                        "DiaChi", "Email", "SoSachMuon", "NgayLapThe", "TinhTrangTraTre" };
                MSS.crud.BindingsFields(dataDocGia, controls, fielsName);

                maDG = txtMaDG.Text.Trim();
                maLoaiDG = cbMaLoaiDG.Text + "";

                string txtCheck = dataDocGia.CurrentRow.Cells[8].Value.ToString();

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
                txtEmail.Text, txtSoSachMuon.Text, cbMaLoaiDG.Text.Trim(), txtCheck, txtNgayLapThe))
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
            if (controller.Delete(dataDocGia, txtMaDG.Text))
            {
                MessageBox.Show("Bạn Đã Xóa Thành Công!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utils.ResetControls(groupBox3);
                txtSoSachMuon.Text = "0";
                maDG = "";
                maLoaiDG = "";
                radioButton2.Checked = true;
                controller.GetAllComboBox(cbMaLoaiDG, "LOAIDG", "MaLoaiDG", "MaLoaiDG");
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
            txtSoSachMuon.Text = "0";
            maDG = "";
            maLoaiDG = "";
            radioButton2.Checked = true;
            controller.GetAllComboBox(cbMaLoaiDG, "LOAIDG", "MaLoaiDG", "MaLoaiDG");
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

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbMaLoaiDG_TextChanged(object sender, EventArgs e)
        {
            if (!flag)
            {
                return;
            }

            string MLDocGia = cbMaLoaiDG.Text + "";
            if (MLDocGia == maLoaiDG)
            {
                txtMaDG.Text = maDG;
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
                string MLDocGia = cbMaLoaiDG.Text.Trim();
                Random random = new Random();
                string strRand = "DG" + MLDocGia + random.Next(1000, 9999);
                txtMaDG.Text = strRand.Trim();
                txtMaDG.ReadOnly = true;
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            
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

            if (controller.Insert(dataDocGia, txtMaDG.Text, cbMaLoaiDG.Text.Trim(), txtHoten.Text, txtNgaySinh, txtDiaChi.Text,
                    txtEmail.Text, txtNgayLapThe, txtSoSachMuon.Text, txtCheck))
            {
                MessageBox.Show("Bạn Đã Thêm Thành Công!", "Quản Lý Thư Viện",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utils.ResetControls(groupBox3);
                txtSoSachMuon.Text = "0";
                maDG = "";
                maLoaiDG = "";
                radioButton2.Checked = true;
                controller.GetAllComboBox(cbMaLoaiDG, "LOAIDG", "MaLoaiDG", "MaLoaiDG");
            }
        }

        private void dataLoaiDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Control[] controls = { txtMaLoaiDG, txtLoaiDG };
            string[] fields = { "MaLoaiDG", "LoaiDG" };
            MSS.crud.BindingsFields(dataLoaiDG, controls, fields);
        }

        private void btnRefreshLoaiDG_Click(object sender, EventArgs e)
        {
            Utils.ResetControls(groupBox5);
            LoadMaLoaiDG();
        }

        public void LoadMaLoaiDG()
        {
            Random random = new Random();
            string strRand = "ML" + DateTime.Now.ToString("HHmmss") + random.Next(10, 100);
            txtMaLoaiDG.Text = strRand.Trim();
        }

        private void ThemLoaiDG_Click(object sender, EventArgs e)
        {
            if (txtLoaiDG.Text == "")
            {
                MessageBox.Show("LoaiDG Không Được Để Trống!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controller.ThemLoaiDG(dataLoaiDG, txtMaLoaiDG.Text.Trim(), txtLoaiDG.Text.Trim());
            MessageBox.Show("Thêm Loại DG Thành Công!", "Quản Lý Thư Viện",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Utils.ResetControls(groupBox5);
            LoadMaLoaiDG();
            controller.GetAllComboBox(cbMaLoaiDG, "LOAIDG", "MaLoaiDG", "MaLoaiDG");
        }

        private void btnUpdateLoaiDG_Click(object sender, EventArgs e)
        {
            if (txtLoaiDG.Text == "")
            {
                MessageBox.Show("LoaiDG Không Được Để Trống!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controller.CapNhatLoaiDG(dataLoaiDG, txtMaLoaiDG.Text.Trim(), txtLoaiDG.Text.Trim());
            MessageBox.Show("Cập Nhật Loại DG Thành Công!", "Quản Lý Thư Viện",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Utils.ResetControls(groupBox5);
            LoadMaLoaiDG();
            controller.GetAllComboBox(cbMaLoaiDG, "LOAIDG", "MaLoaiDG", "MaLoaiDG");
        }

        private void txtSearchLoaiDG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                controller.SearchLoaiDG(dataLoaiDG, txtSearchLoaiDG.Text);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
            }

            //Tìm Kiếm Bằng Linq
            //var dsSearchLoaiDG = db.LOAIDGs.Where(value => value.MaLoaiDG.Contains(txtSearchLoaiDG.Text)
            //                        || value.LoaiDG.Contains(txtSearchLoaiDG.Text)).Select(value => value);
            //dataLoaiDG.DataSource = dsSearchLoaiDG.ToList();
        }
    }
}
