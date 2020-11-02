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
    public partial class DocGia : Form
    {


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
            try
            {
                MSS.crud.LoadDataGridViewDataSet("Account", dgvAccount);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }

        private void dgvAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Control[] controls = { txtDocGia, txtNgaySinh, txtEmail };
                string[] fielsName = { "id", "username", "passwrod" };
                MSS.crud.BindingsFields(dgvAccount, controls, fielsName);
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return;
            }
        }
    }
}
