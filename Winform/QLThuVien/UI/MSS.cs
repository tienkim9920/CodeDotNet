using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;
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

        private Account CheckLogin(Account account)
        {
            Account newAccount = new Account();
            try
            {
                var sql = "select * from ACCOUNT where Username=@Username and Password=@Password";
                var cmd = new SqlCommand(sql, crud.Connection);
                string[] parameters = { "Username", "Password" };
                object[] values = { account.Username, account.Password };
                crud.ParamsAndValues(cmd, parameters, values);
                var adapter = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                adapter.Fill(ds, "ACCOUNT");

                if(ds.Tables["ACCOUNT"].Rows.Count > 0)
                {
                    newAccount.id = int.Parse(ds.Tables["ACCOUNT"].Rows[0]["id"].ToString());
                    newAccount.Name = ds.Tables["ACCOUNT"].Rows[0]["Name"].ToString();
                    newAccount.Username = ds.Tables["ACCOUNT"].Rows[0]["Username"].ToString();
                    newAccount.Password = ds.Tables["ACCOUNT"].Rows[0]["Password"].ToString();
                    return newAccount;
                }

                return null;
            }
            catch (Exception ex)
            {
                Utils.MSG(ex.Message);
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Utils.TextBoxMSG(txtUsername, "Enter Username!", "Vui lòng nhập tài khoản!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error))
            {
                return;
            }

            if (Utils.TextBoxMSG(txtPassword, "Enter Password!", "Vui lòng nhập mật khẩu!!", "Quản Lý Thư Viện",
                MessageBoxButtons.OK, MessageBoxIcon.Error))
            {
                return;
            }

            Account account = new Account()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            Account info = CheckLogin(account);

            if (info != null)
            {
                this.Hide();
                Main main = new Main();
                main.SendInforAccept(info);
                main.ShowDialog();
            }
            else
            {
                Utils.MSG("Tài khoản hoặc mật khẩu sai??");
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
