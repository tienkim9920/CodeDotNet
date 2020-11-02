using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UtilsBasic2020
{
    public class Utils
    {
        /// <summary>
        /// Điểm chuột hiện tại (x, y)
        /// </summary>
        public static Point currentPoint;

        /// <summary>
        /// Lấy toạ độ MouseDown (x, y)
        /// </summary>
        public static void MouseDown(MouseEventArgs e)
        {
            currentPoint = e.Location;
        }

        /// <summary>
        /// Lấy toạ độ MouseMove (x, y)
        /// </summary>
        public static void MouseMove(Form form, Point point, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - point.X;
                int dy = e.Location.Y - point.Y;
                form.Location = new Point(form.Location.X + dx, form.Location.Y + dy);
            }
        }

        /// <summary>
        /// Reset Controls
        /// </summary>
        public static void ResetControls(Control container)
        {
            foreach(Control control in container.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now; // or null 
                }
                else
                {
                    ResetControls(control);
                }
            }
        }

        #region Orther

        /// <summary>
        /// Giống MessageBox.Show
        /// </summary>
        public static DialogResult MSG(string msg, string title = "Error",
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK,
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error)
        {
            return MessageBox.Show(msg, title, messageBoxButtons, messageBoxIcon);
        }

        /// <summary>
        /// Thay thế Process.Start(...);
        /// </summary>
        public static void CMD(string input)
        {
            Process.Start(input);
        }

        /// <summary>
        /// Kiểm tra DateTime
        /// </summary>
        public static bool CheckIsDateTime(string input)
        {
            DateTime result;
            return DateTime.TryParse(input, out result);
        }

        /// <summary>
        /// Kiểm tra chuổi rỗng
        /// </summary>
        public static bool CheckIsBlank(string input)
        {
            return !(input.Trim().Length == 0);
        }

        #endregion

        #region MaskedTextBox

        /// <summary>
        /// Kiểm tra MaskedTextBox đúng định dạng DateTime hay không có hỗ trợ MessageBox
        /// </summary>
        public static bool MaskedTextBoxDateTimeMSG(MaskedTextBox input, string msg, string title = "Error",
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK,
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error)
        {
            if (!CheckIsDateTime(input.Text))
            {
                MSG(msg, title, messageBoxButtons, messageBoxIcon);
                input.Focus();
                return false; // Ngăn chăn xử lý trong if
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra MaskedTextBox có dữ liệu nhập vào hay không có hỗ trợ MessageBox
        /// <code>
        /// <paramref name="format"/> Có thể là 1 pattern: VD: @"^[\w]{3}[-][\w]{7}$" (điền đúng, nhập sai)
        /// </code>
        /// <code>
        /// VD: Utils.MaskedTextBoxMSG(MaskedTextBox, @"^[\w]{3}[-][\w]{7}$", "Phone is invalid.", "Error");
        /// </code>
        /// <code>
        /// Cách dùng: if(Utils.MaskedTextBoxMSG(...)) { return; }
        /// </code>
        /// </summary>
        public static bool MaskedTextBoxMSG(MaskedTextBox input, string format, string msg, string title = "Error",
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK,
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error)
        {
            string strInput = input.Text;
            bool flag = false;

            if (format.Contains("^") && format.Contains("$"))
            {
                if (!Regex.IsMatch(strInput, format))
                {
                    flag = true;
                }
            }
            else
            {
                if (format.Equals(strInput))
                {
                    flag = true;
                }
            }

            if (flag)
            {
                MSG(msg, title, messageBoxButtons, messageBoxIcon);
                input.Focus();
                return flag;
                //return false; // Ngăn chăn xử lý trong if
            }

            return flag;
        }

        #endregion

        #region TextBox

        /// <summary>
        /// Kiểm tra TextBox có dữ liệu nhập vào hay không có hỗ trợ MessageBox
        /// <code>
        /// <paramref name="format"/> Có thể là 1 pattern: VD: @"^[\w]{3,}@[\w]{2,}(.[/\w]{2,}){1,2}$" (điền đúng, nhập sai)
        /// </code>
        /// <code>
        /// VD: Utils.TextBoxMSG(TextBox, @"^[\w]{3,}@[\w]{2,}(.[/\w]{2,}){1,2}$", "Email is invalid.", "Error");
        /// </code>
        /// <code>
        /// Cách dùng: if(Utils.TextBoxMSG(...)) { return; }
        /// </code>
        /// </summary>
        public static bool TextBoxMSG(TextBox input, string format, string msg, string title = "Error",
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK,
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error)
        {

            string strInput = input.Text.Trim();
            bool flag = false;

            if (format.Contains("^") && format.Contains("$"))
            {
                if (!Regex.IsMatch(strInput, format))
                {
                    flag = true;
                }
            }
            else
            {
                if (format.Equals(strInput))
                {
                    flag = true;
                }
            }

            if (flag)
            {
                MSG(msg, title, messageBoxButtons, messageBoxIcon);
                input.Focus();
                return flag;
                //return false; // Ngăn chăn xử lý trong if
            }

            return flag;
        }

        #endregion

        #region Lable

        /// <summary>
        /// Kiểm tra TextBox có dữ liệu nhập vào hay không có hỗ trợ MessageBox
        /// <code>
        /// <paramref name="format"/> Có thể là 1 pattern: VD: @"^[\w]{3,}@[\w]{2,}(.[/\w]{2,}){1,2}$" (điền đúng, nhập sai)
        /// </code>
        /// <code>
        /// VD: Utils.TextBoxMSG(TextBox, @"^[\w]{3,}@[\w]{2,}(.[/\w]{2,}){1,2}$", "Email is invalid.", "Error");
        /// </code>
        /// <code>
        /// Cách dùng: if(Utils.TextBoxMSG(...)) { return; }
        /// </code>
        /// </summary>
        public static bool LabelMSG(Label input, string format, string msg, string title = "Error",
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK,
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error)
        {

            string strInput = input.Text.Trim();
            bool flag = false;

            if (format.Contains("^") && format.Contains("$"))
            {
                if (!Regex.IsMatch(strInput, format))
                {
                    flag = true;
                }
            }
            else
            {
                if (format.Equals(strInput))
                {
                    flag = true;
                }
            }

            if (flag)
            {
                MSG(msg, title, messageBoxButtons, messageBoxIcon);
                input.Focus();
                return flag;
                //return false; // Ngăn chăn xử lý trong if
            }

            return flag;
        }

        #endregion

    }

}
