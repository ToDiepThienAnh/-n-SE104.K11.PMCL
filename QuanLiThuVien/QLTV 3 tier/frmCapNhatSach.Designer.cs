﻿namespace QLTV
{
    partial class frmCapNhatSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatSach));
            this.dgvSach = new MetroFramework.Controls.MetroGrid();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSua = new MetroFramework.Controls.MetroButton();
            this.btnOkSua = new System.Windows.Forms.Button();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnOkThem = new System.Windows.Forms.Button();
            this.txtSoBanTon = new System.Windows.Forms.TextBox();
            this.txtSoBan = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLuaChonTim = new System.Windows.Forms.ComboBox();
            this.txtThongTinTimKiem = new System.Windows.Forms.TextBox();
            this.cboNXB = new QLTV.AutoCompleteComboBox();
            this.cboTheLoai = new QLTV.AutoCompleteComboBox();
            this.cboTacGia = new QLTV.AutoCompleteComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToResizeColumns = false;
            this.dgvSach.AllowUserToResizeRows = false;
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSach.Location = new System.Drawing.Point(40, 361);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(722, 270);
            this.dgvSach.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbInfo.Controls.Add(this.btnXoa);
            this.gbInfo.Controls.Add(this.btnCancel);
            this.gbInfo.Controls.Add(this.btnSua);
            this.gbInfo.Controls.Add(this.btnOkSua);
            this.gbInfo.Controls.Add(this.btnThem);
            this.gbInfo.Controls.Add(this.btnOkThem);
            this.gbInfo.Controls.Add(this.cboNXB);
            this.gbInfo.Controls.Add(this.cboTheLoai);
            this.gbInfo.Controls.Add(this.cboTacGia);
            this.gbInfo.Controls.Add(this.txtSoBanTon);
            this.gbInfo.Controls.Add(this.txtSoBan);
            this.gbInfo.Controls.Add(this.txtGia);
            this.gbInfo.Controls.Add(this.txtSoTrang);
            this.gbInfo.Controls.Add(this.txtNamXB);
            this.gbInfo.Controls.Add(this.txtTenSach);
            this.gbInfo.Controls.Add(this.txtMaSach);
            this.gbInfo.Controls.Add(this.label11);
            this.gbInfo.Controls.Add(this.label10);
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Location = new System.Drawing.Point(40, 99);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(722, 256);
            this.gbInfo.TabIndex = 5;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tinh sách:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnXoa.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnXoa.Highlight = true;
            this.btnXoa.Location = new System.Drawing.Point(587, 207);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnXoa.UseSelectable = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSua.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnSua.Highlight = true;
            this.btnSua.Location = new System.Drawing.Point(484, 207);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSua.UseSelectable = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnOkSua
            // 
            this.btnOkSua.Location = new System.Drawing.Point(104, 205);
            this.btnOkSua.Name = "btnOkSua";
            this.btnOkSua.Size = new System.Drawing.Size(80, 28);
            this.btnOkSua.TabIndex = 18;
            this.btnOkSua.Text = "Đồng ý";
            this.btnOkSua.UseVisualStyleBackColor = true;
            this.btnOkSua.Click += new System.EventHandler(this.btnOkSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnThem.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnThem.Highlight = true;
            this.btnThem.Location = new System.Drawing.Point(378, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm ";
            this.btnThem.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnOkThem
            // 
            this.btnOkThem.Location = new System.Drawing.Point(104, 205);
            this.btnOkThem.Name = "btnOkThem";
            this.btnOkThem.Size = new System.Drawing.Size(80, 28);
            this.btnOkThem.TabIndex = 23;
            this.btnOkThem.Text = "Đồng ý";
            this.btnOkThem.UseVisualStyleBackColor = true;
            this.btnOkThem.Click += new System.EventHandler(this.btnOkThem_Click);
            // 
            // txtSoBanTon
            // 
            this.txtSoBanTon.Enabled = false;
            this.txtSoBanTon.Location = new System.Drawing.Point(477, 155);
            this.txtSoBanTon.Name = "txtSoBanTon";
            this.txtSoBanTon.Size = new System.Drawing.Size(210, 25);
            this.txtSoBanTon.TabIndex = 16;
            this.txtSoBanTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoBanTon_KeyPress);
            // 
            // txtSoBan
            // 
            this.txtSoBan.Enabled = false;
            this.txtSoBan.Location = new System.Drawing.Point(477, 124);
            this.txtSoBan.Name = "txtSoBan";
            this.txtSoBan.Size = new System.Drawing.Size(210, 25);
            this.txtSoBan.TabIndex = 15;
            this.txtSoBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoBan_KeyPress);
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(477, 93);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(210, 25);
            this.txtGia.TabIndex = 14;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Enabled = false;
            this.txtSoTrang.Location = new System.Drawing.Point(477, 62);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(210, 25);
            this.txtSoTrang.TabIndex = 13;
            this.txtSoTrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTrang_KeyPress);
            // 
            // txtNamXB
            // 
            this.txtNamXB.Enabled = false;
            this.txtNamXB.Location = new System.Drawing.Point(477, 31);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(210, 25);
            this.txtNamXB.TabIndex = 12;
            this.txtNamXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamXB_KeyPress);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Enabled = false;
            this.txtTenSach.Location = new System.Drawing.Point(104, 62);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(222, 25);
            this.txtTenSach.TabIndex = 8;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(104, 31);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(222, 25);
            this.txtMaSach.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Số bản tồn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Thể loại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số bản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số trang:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Năm xuất bản:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tác giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách:";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTim.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnTim.Highlight = true;
            this.btnTim.Location = new System.Drawing.Point(649, 67);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(113, 26);
            this.btnTim.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm ";
            this.btnTim.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnTim.UseSelectable = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(36, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // cboLuaChonTim
            // 
            this.cboLuaChonTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLuaChonTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLuaChonTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cboLuaChonTim.FormattingEnabled = true;
            this.cboLuaChonTim.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Tên tác giả",
            "Thể loại",
            "Nhà xuất bản",
            "Năm xuất bản"});
            this.cboLuaChonTim.Location = new System.Drawing.Point(145, 67);
            this.cboLuaChonTim.Name = "cboLuaChonTim";
            this.cboLuaChonTim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboLuaChonTim.Size = new System.Drawing.Size(101, 25);
            this.cboLuaChonTim.TabIndex = 4;
            // 
            // txtThongTinTimKiem
            // 
            this.txtThongTinTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThongTinTimKiem.Location = new System.Drawing.Point(252, 67);
            this.txtThongTinTimKiem.Name = "txtThongTinTimKiem";
            this.txtThongTinTimKiem.Size = new System.Drawing.Size(391, 25);
            this.txtThongTinTimKiem.TabIndex = 5;
            this.txtThongTinTimKiem.TextChanged += new System.EventHandler(this.txtThongTinTimKiem_TextChanged);
            // 
            // cboNXB
            // 
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.Location = new System.Drawing.Point(104, 155);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(222, 25);
            this.cboNXB.TabIndex = 0;
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(104, 124);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(222, 25);
            this.cboTheLoai.TabIndex = 0;
            // 
            // cboTacGia
            // 
            this.cboTacGia.FormattingEnabled = true;
            this.cboTacGia.Location = new System.Drawing.Point(104, 93);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(222, 25);
            this.cboTacGia.TabIndex = 0;
            // 
            // frmCapNhatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 660);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.cboLuaChonTim);
            this.Controls.Add(this.txtThongTinTimKiem);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCapNhatSach";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Text = "Cập nhật sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCapNhatSach_FormClosing);
            this.Load += new System.EventHandler(this.frmCapNhatSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvSach;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkSua;
        private System.Windows.Forms.Button btnOkThem;
        //private System.Windows.Forms.ComboBox cboNXB;
        private AutoCompleteComboBox cboNXB;
        //private System.Windows.Forms.ComboBox cboTheLoai;
        private AutoCompleteComboBox cboTheLoai;
        //private System.Windows.Forms.ComboBox cboTacGia;
        private AutoCompleteComboBox cboTacGia;
        private System.Windows.Forms.TextBox txtSoBanTon;
        private System.Windows.Forms.TextBox txtSoBan;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnSua;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLuaChonTim;
        private System.Windows.Forms.TextBox txtThongTinTimKiem;
    }
}