using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLOPHOC.DAL;

namespace QLLOPHOC
{
    public partial class frmLopHoc : Form
    {
        private LopHocEntities db = new LopHocEntities();
        public frmLopHoc()
        {
            InitializeComponent();
            LoadThongTinLop();
            ChangeGridViewHeaderName();
        }

        private void LoadThongTinLop()
        {
            var dsLopHoc = from lop in db.LOPHOCs
                           select new { MaLop = lop.MALOP, TenLop = lop.TENLOP };
            dgvLopHoc.DataSource = dsLopHoc.ToList();

            AddLopHocBinding();
        }

        private void AddLopHocBinding()
        {
            txtMaLop.DataBindings.Clear();
            txtTenLop.DataBindings.Clear();

            txtMaLop.DataBindings.Add("Text",dgvLopHoc.DataSource,"MaLop");
            txtTenLop.DataBindings.Add("Text", dgvLopHoc.DataSource, "TenLop");

        }

        private void ChangeGridViewHeaderName()
        {
            dgvLopHoc.Columns[0].HeaderText = "Mã Lớp";
            dgvLopHoc.Columns[1].HeaderText = "Tên Lớp";
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLop.Text;
            string TenLop = txtTenLop.Text;

            LOPHOC lop = db.LOPHOCs.Where(l => l.MALOP == MaLop).SingleOrDefault();

            if(lop!= null)
            {
                MessageBox.Show("Mã Lớp Học Đã Tồn Tại");
                return;
            }
            else if(String.IsNullOrEmpty(MaLop)|| String.IsNullOrEmpty(TenLop))
            {
                MessageBox.Show("Không Được Để Tên Lớp Trống");
                return;
            }
            else
            {
                lop = new LOPHOC();
                lop.MALOP = MaLop;
                lop.TENLOP = TenLop;
                db.LOPHOCs.Add(lop);
                db.SaveChanges();
                LoadThongTinLop();
                MessageBox.Show("Thêm Lớp Học Mới Thành Công");
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLop.Text;
            string TenLop = txtTenLop.Text;

            LOPHOC lop = db.LOPHOCs.Where(l => l.MALOP == MaLop).SingleOrDefault();

            if (lop == null)
            {
                MessageBox.Show("Mã Lớp Học Đã Tồn Tại");
                return;
            }
            else if (String.IsNullOrEmpty(MaLop))
            {
                MessageBox.Show("Mã Lớp Cần Xóa Không Được Để Trống");
                return;
            }
            else
            {
                db.LOPHOCs.Remove(lop);
                db.SaveChanges();
                LoadThongTinLop();
                MessageBox.Show("Xóa Lớp Học Thành Công");
            }

        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLop.Text;
            string TenLop = txtTenLop.Text;

            LOPHOC lop = db.LOPHOCs.Where(l => l.MALOP == MaLop).SingleOrDefault();

            if (lop == null)
            {
                MessageBox.Show("Mã Lớp Học Không Tồn Tại");
                return;
            }
            else if (String.IsNullOrEmpty(MaLop))
            {
                MessageBox.Show("Mã Lớp Học Cần Sửa Không Được Để Trống");
                return;
            }
            else
            {
                lop.TENLOP = TenLop;
                db.SaveChanges();
                LoadThongTinLop();
                MessageBox.Show("Cập Nhật Thông Tin Lớp Học Thành Công");
            }

        }
    }
}
