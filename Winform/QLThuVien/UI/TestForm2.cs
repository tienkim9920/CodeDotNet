using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TestForm2 : Form
    {
        public TestForm2()
        {
            InitializeComponent();
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
            initContainer(new MSS(), splitContainer1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            initContainer(new DocGia(), splitContainer1);
        }
    }
}
