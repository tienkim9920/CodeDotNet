namespace QLLOPHOC
{
    partial class frmLopHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(125, 27);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(367, 23);
            this.txtMaLop.TabIndex = 1;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(125, 117);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(87, 27);
            this.btnThemLop.TabIndex = 2;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Location = new System.Drawing.Point(43, 169);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.Size = new System.Drawing.Size(607, 190);
            this.dgvLopHoc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(125, 70);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(367, 23);
            this.txtTenLop.TabIndex = 5;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(267, 117);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(87, 27);
            this.btnXoaLop.TabIndex = 6;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Location = new System.Drawing.Point(405, 117);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(87, 27);
            this.btnSuaLop.TabIndex = 7;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(523, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 117);
            this.button4.TabIndex = 8;
            this.button4.Text = "Quản Lý Sinh Viên";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 390);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSuaLop);
            this.Controls.Add(this.btnXoaLop);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button button4;
    }
}

