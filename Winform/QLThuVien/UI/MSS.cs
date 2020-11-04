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
        public static CRUD crud = new CRUD(@"Data Source=DESKTOP-KSVV6FR\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True");

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

        private void MSS_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            Utils.Enter(txtUsername, "Enter Username!");
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Utils.Enter(txtPassword, "Enter Password!");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            Utils.Leave(txtUsername, "Enter Username!");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Utils.Leave(txtPassword, "Enter Password!");
        }
    }
}
