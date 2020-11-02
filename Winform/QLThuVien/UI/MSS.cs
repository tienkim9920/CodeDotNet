using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsBasic2020;

namespace UI
{
    public partial class MSS : Form
    {
        public static CRUD crud = new CRUD(@"Data Source=.\sqlexpress;Initial Catalog=QLThuVien;Integrated Security=True");

        public MSS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Utils.TextBoxMSG(txtUsername, "", "Vui lòng nhập tài khoản!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error))
            {
                return;
            }

            if (Utils.TextBoxMSG(txtPassword, "", "Vui lòng nhập mật khẩu!!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error))
            {
                return;
            }

            if(true)
            {
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Utils.MouseDown(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Utils.MouseMove(this, Utils.currentPoint, e);
        }
    }
}
