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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void initContainer(Form from, SplitContainer splitContainer)
        {
            splitContainer.Panel2.Controls.Clear();
            from.TopLevel = false;
            splitContainer.Panel2.Controls.Add(from);
            from.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initContainer(new DocGia(), splitContainer1);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
