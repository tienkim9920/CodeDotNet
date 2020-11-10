using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;
using UtilsBasic2020;

namespace UI
{
    public delegate void SendInfor(Account account);

    public partial class Main : Form
    {

        private Account account;

        private SendInfor sendInfor;

        public Main()
        {
            InitializeComponent();
            sendInfor = new SendInfor(SendInforAccept);
        }

        public void SendInforAccept(Account oblAccount)
        {
            account = oblAccount;
            txtName.Text = "Xin Chào " + account.Name;
            txtXinChao.Text = "Xin Chào " + account.Name;
        }

        //public Main(string Username) : this()
        //{
        //    this.txtUsername = Username;
        //    txtName.Text = "Xin Chào " + txtUsername;
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            var result = Utils.MSG("Bạn có chắc chắn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private Point currentPoint;

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - currentPoint.X;
                int dy = e.Location.Y - currentPoint.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - currentPoint.X;
                int dy = e.Location.Y - currentPoint.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MSS form1 = new MSS();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.InitContainer(new DocGia(), splitContainer1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utils.InitContainer(new CTTraSach(), splitContainer1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utils.InitContainer(new Sach(), splitContainer1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Utils.InitContainer(new CTMuonSach(), splitContainer1);
        }

    }
}
