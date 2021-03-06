﻿namespace UI
{
    partial class DocGia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataDocGia = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoSachMuon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.timeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.timeNgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.cbMaLoaiDG = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtSearchLoaiDG = new System.Windows.Forms.TextBox();
            this.btnRefreshLoaiDG = new System.Windows.Forms.Button();
            this.btnUpdateLoaiDG = new System.Windows.Forms.Button();
            this.ThemLoaiDG = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtLoaiDG = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dataLoaiDG = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaLoaiDG = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDocGia)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiDG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(206, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.RoyalBlue;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.CausesValidation = false;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label15.Location = new System.Drawing.Point(275, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 4);
            this.label15.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MaDG/HoTen:";
            // 
            // txtKeyword
            // 
            this.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKeyword.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtKeyword.Location = new System.Drawing.Point(275, 32);
            this.txtKeyword.Multiline = true;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(171, 36);
            this.txtKeyword.TabIndex = 0;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(28, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1370, 3);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(21, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quản Lý Độc Giả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataDocGia);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(513, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 655);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Độc Giả";
            // 
            // dataDocGia
            // 
            this.dataDocGia.AllowUserToAddRows = false;
            this.dataDocGia.AllowUserToResizeColumns = false;
            this.dataDocGia.AllowUserToResizeRows = false;
            this.dataDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDocGia.BackgroundColor = System.Drawing.Color.White;
            this.dataDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDocGia.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataDocGia.Location = new System.Drawing.Point(6, 171);
            this.dataDocGia.Name = "dataDocGia";
            this.dataDocGia.ReadOnly = true;
            this.dataDocGia.RowHeadersVisible = false;
            this.dataDocGia.RowHeadersWidth = 51;
            this.dataDocGia.RowTemplate.Height = 24;
            this.dataDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDocGia.Size = new System.Drawing.Size(879, 478);
            this.dataDocGia.TabIndex = 9;
            this.dataDocGia.Click += new System.EventHandler(this.dataDocGia_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnInsert);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox4.Location = new System.Drawing.Point(702, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(653, 104);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(516, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 47);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(187, 41);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 46);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(20, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 45);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(357, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 47);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Red;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.Transparent;
            this.btnHide.Location = new System.Drawing.Point(1351, 12);
            this.btnHide.Name = "btnHide";
            this.btnHide.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnHide.Size = new System.Drawing.Size(47, 41);
            this.btnHide.TabIndex = 16;
            this.btnHide.Text = "X";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // txtMaDG
            // 
            this.txtMaDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaDG.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtMaDG.Location = new System.Drawing.Point(41, 68);
            this.txtMaDG.Multiline = true;
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(171, 33);
            this.txtMaDG.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(37, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Độc Giả:";
            // 
            // txtHoten
            // 
            this.txtHoten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoten.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtHoten.Location = new System.Drawing.Point(259, 68);
            this.txtHoten.Multiline = true;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(171, 33);
            this.txtHoten.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(255, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ Tên:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtDiaChi.Location = new System.Drawing.Point(711, 72);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(171, 33);
            this.txtDiaChi.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(707, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label20.Location = new System.Drawing.Point(487, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 24);
            this.label20.TabIndex = 5;
            this.label20.Text = "MaLoaiDG:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(1141, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 24);
            this.label18.TabIndex = 5;
            this.label18.Text = "Ngày Lập Thẻ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(923, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày Sinh:";
            // 
            // txtSoSachMuon
            // 
            this.txtSoSachMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoSachMuon.Enabled = false;
            this.txtSoSachMuon.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtSoSachMuon.Location = new System.Drawing.Point(485, 170);
            this.txtSoSachMuon.Multiline = true;
            this.txtSoSachMuon.Name = "txtSoSachMuon";
            this.txtSoSachMuon.Size = new System.Drawing.Size(171, 33);
            this.txtSoSachMuon.TabIndex = 10;
            this.txtSoSachMuon.Text = "0";
            this.txtSoSachMuon.Enter += new System.EventHandler(this.txtSoSachMuon_Enter);
            this.txtSoSachMuon.Leave += new System.EventHandler(this.txtSoSachMuon_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(481, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Số Sách Đang Mượn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(40, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtEmail.Location = new System.Drawing.Point(44, 171);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 33);
            this.txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 4);
            this.label3.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.RoyalBlue;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.CausesValidation = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(260, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 4);
            this.label11.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.RoyalBlue;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.CausesValidation = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(711, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 4);
            this.label13.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.CausesValidation = false;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label21.Location = new System.Drawing.Point(486, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(170, 4);
            this.label21.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.CausesValidation = false;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label19.Location = new System.Drawing.Point(927, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 4);
            this.label19.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.RoyalBlue;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.CausesValidation = false;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Location = new System.Drawing.Point(44, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 4);
            this.label14.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label17.Location = new System.Drawing.Point(256, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 24);
            this.label17.TabIndex = 20;
            this.label17.Text = "Tình Trạng Trả Trễ:";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.RoyalBlue;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.CausesValidation = false;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label22.Location = new System.Drawing.Point(486, 199);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(170, 4);
            this.label22.TabIndex = 22;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(260, 175);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 29);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.Text = "True";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(358, 175);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 29);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "False";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // timeNgaySinh
            // 
            this.timeNgaySinh.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.timeNgaySinh.CalendarMonthBackground = System.Drawing.Color.White;
            this.timeNgaySinh.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue;
            this.timeNgaySinh.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.timeNgaySinh.CalendarTrailingForeColor = System.Drawing.Color.RoyalBlue;
            this.timeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeNgaySinh.Location = new System.Drawing.Point(927, 68);
            this.timeNgaySinh.Name = "timeNgaySinh";
            this.timeNgaySinh.Size = new System.Drawing.Size(170, 33);
            this.timeNgaySinh.TabIndex = 26;
            // 
            // timeNgayLapThe
            // 
            this.timeNgayLapThe.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.timeNgayLapThe.CalendarMonthBackground = System.Drawing.Color.White;
            this.timeNgayLapThe.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue;
            this.timeNgayLapThe.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.timeNgayLapThe.CalendarTrailingForeColor = System.Drawing.Color.RoyalBlue;
            this.timeNgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeNgayLapThe.Location = new System.Drawing.Point(1144, 68);
            this.timeNgayLapThe.Name = "timeNgayLapThe";
            this.timeNgayLapThe.Size = new System.Drawing.Size(170, 33);
            this.timeNgayLapThe.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.CausesValidation = false;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label16.Location = new System.Drawing.Point(1144, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 4);
            this.label16.TabIndex = 28;
            // 
            // cbMaLoaiDG
            // 
            this.cbMaLoaiDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLoaiDG.Enabled = false;
            this.cbMaLoaiDG.FormattingEnabled = true;
            this.cbMaLoaiDG.Location = new System.Drawing.Point(486, 65);
            this.cbMaLoaiDG.Name = "cbMaLoaiDG";
            this.cbMaLoaiDG.Size = new System.Drawing.Size(171, 33);
            this.cbMaLoaiDG.TabIndex = 29;
            this.cbMaLoaiDG.TextChanged += new System.EventHandler(this.cbMaLoaiDG_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbMaLoaiDG);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.timeNgayLapThe);
            this.groupBox3.Controls.Add(this.timeNgaySinh);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtSoSachMuon);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtHoten);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMaDG);
            this.groupBox3.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Location = new System.Drawing.Point(28, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1370, 240);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Độc Giả";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.btnRefreshLoaiDG);
            this.groupBox5.Controls.Add(this.btnUpdateLoaiDG);
            this.groupBox5.Controls.Add(this.ThemLoaiDG);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.txtLoaiDG);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.dataLoaiDG);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtMaLoaiDG);
            this.groupBox5.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox5.Location = new System.Drawing.Point(28, 335);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(479, 655);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Các Loại Độc Giả";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.txtSearchLoaiDG);
            this.groupBox6.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox6.Location = new System.Drawing.Point(37, 209);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(404, 87);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm Kiếm";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.RoyalBlue;
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.CausesValidation = false;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label26.Location = new System.Drawing.Point(207, 64);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(170, 4);
            this.label26.TabIndex = 14;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label27.Location = new System.Drawing.Point(22, 43);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(168, 25);
            this.label27.TabIndex = 1;
            this.label27.Text = "MaLoaiDG/LoaiDG:";
            // 
            // txtSearchLoaiDG
            // 
            this.txtSearchLoaiDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchLoaiDG.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLoaiDG.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtSearchLoaiDG.Location = new System.Drawing.Point(207, 32);
            this.txtSearchLoaiDG.Multiline = true;
            this.txtSearchLoaiDG.Name = "txtSearchLoaiDG";
            this.txtSearchLoaiDG.Size = new System.Drawing.Size(171, 36);
            this.txtSearchLoaiDG.TabIndex = 0;
            this.txtSearchLoaiDG.TextChanged += new System.EventHandler(this.txtSearchLoaiDG_TextChanged);
            // 
            // btnRefreshLoaiDG
            // 
            this.btnRefreshLoaiDG.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshLoaiDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshLoaiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLoaiDG.ForeColor = System.Drawing.Color.White;
            this.btnRefreshLoaiDG.Location = new System.Drawing.Point(37, 147);
            this.btnRefreshLoaiDG.Name = "btnRefreshLoaiDG";
            this.btnRefreshLoaiDG.Size = new System.Drawing.Size(122, 45);
            this.btnRefreshLoaiDG.TabIndex = 24;
            this.btnRefreshLoaiDG.Text = "Làm Mới";
            this.btnRefreshLoaiDG.UseVisualStyleBackColor = false;
            this.btnRefreshLoaiDG.Click += new System.EventHandler(this.btnRefreshLoaiDG_Click);
            // 
            // btnUpdateLoaiDG
            // 
            this.btnUpdateLoaiDG.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateLoaiDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLoaiDG.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLoaiDG.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLoaiDG.Location = new System.Drawing.Point(182, 147);
            this.btnUpdateLoaiDG.Name = "btnUpdateLoaiDG";
            this.btnUpdateLoaiDG.Size = new System.Drawing.Size(116, 47);
            this.btnUpdateLoaiDG.TabIndex = 21;
            this.btnUpdateLoaiDG.Text = "Cập Nhật";
            this.btnUpdateLoaiDG.UseVisualStyleBackColor = false;
            this.btnUpdateLoaiDG.Click += new System.EventHandler(this.btnUpdateLoaiDG_Click);
            // 
            // ThemLoaiDG
            // 
            this.ThemLoaiDG.BackColor = System.Drawing.Color.RoyalBlue;
            this.ThemLoaiDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemLoaiDG.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemLoaiDG.ForeColor = System.Drawing.Color.White;
            this.ThemLoaiDG.Location = new System.Drawing.Point(322, 148);
            this.ThemLoaiDG.Name = "ThemLoaiDG";
            this.ThemLoaiDG.Size = new System.Drawing.Size(116, 46);
            this.ThemLoaiDG.TabIndex = 20;
            this.ThemLoaiDG.Text = "Thêm";
            this.ThemLoaiDG.UseVisualStyleBackColor = false;
            this.ThemLoaiDG.Click += new System.EventHandler(this.ThemLoaiDG_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label24.Location = new System.Drawing.Point(267, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 24);
            this.label24.TabIndex = 19;
            this.label24.Text = "LoaiDG:";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.RoyalBlue;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.CausesValidation = false;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label25.Location = new System.Drawing.Point(271, 122);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(170, 4);
            this.label25.TabIndex = 18;
            // 
            // txtLoaiDG
            // 
            this.txtLoaiDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoaiDG.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiDG.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtLoaiDG.Location = new System.Drawing.Point(271, 90);
            this.txtLoaiDG.Multiline = true;
            this.txtLoaiDG.Name = "txtLoaiDG";
            this.txtLoaiDG.Size = new System.Drawing.Size(171, 36);
            this.txtLoaiDG.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label23.Location = new System.Drawing.Point(36, 63);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 24);
            this.label23.TabIndex = 16;
            this.label23.Text = "MaLoaiDG:";
            // 
            // dataLoaiDG
            // 
            this.dataLoaiDG.AllowUserToAddRows = false;
            this.dataLoaiDG.AllowUserToResizeColumns = false;
            this.dataLoaiDG.AllowUserToResizeRows = false;
            this.dataLoaiDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLoaiDG.BackgroundColor = System.Drawing.Color.White;
            this.dataLoaiDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataLoaiDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLoaiDG.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataLoaiDG.Location = new System.Drawing.Point(6, 320);
            this.dataLoaiDG.Name = "dataLoaiDG";
            this.dataLoaiDG.ReadOnly = true;
            this.dataLoaiDG.RowHeadersVisible = false;
            this.dataLoaiDG.RowHeadersWidth = 51;
            this.dataLoaiDG.RowTemplate.Height = 24;
            this.dataLoaiDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLoaiDG.Size = new System.Drawing.Size(467, 329);
            this.dataLoaiDG.TabIndex = 15;
            this.dataLoaiDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLoaiDG_CellClick);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.RoyalBlue;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.CausesValidation = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(40, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 4);
            this.label12.TabIndex = 14;
            // 
            // txtMaLoaiDG
            // 
            this.txtMaLoaiDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaLoaiDG.Enabled = false;
            this.txtMaLoaiDG.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiDG.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtMaLoaiDG.Location = new System.Drawing.Point(40, 90);
            this.txtMaLoaiDG.Multiline = true;
            this.txtMaLoaiDG.Name = "txtMaLoaiDG";
            this.txtMaLoaiDG.Size = new System.Drawing.Size(171, 36);
            this.txtMaLoaiDG.TabIndex = 0;
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1417, 1010);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DocGia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DocGia_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DocGia_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DocGia_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDocGia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataDocGia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnHide;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoSachMuon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker timeNgaySinh;
        private System.Windows.Forms.DateTimePicker timeNgayLapThe;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbMaLoaiDG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtLoaiDG;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dataLoaiDG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaLoaiDG;
        private System.Windows.Forms.Button btnUpdateLoaiDG;
        private System.Windows.Forms.Button ThemLoaiDG;
        private System.Windows.Forms.Button btnRefreshLoaiDG;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtSearchLoaiDG;
    }
}