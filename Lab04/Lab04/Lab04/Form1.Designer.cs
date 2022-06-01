namespace Lab04
{
    partial class frmQuanLySV
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
            this.components = new System.ComponentModel.Container();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.gbThongTinSV = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.lvDanhSachSV = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SĐT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxtmLvSV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdChonHinh = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.gbThongTinSV.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            this.ctxtmLvSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHinh
            // 
            this.pbHinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(3, 3);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(148, 189);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 0;
            this.pbHinh.TabStop = false;
            // 
            // gbThongTinSV
            // 
            this.gbThongTinSV.Controls.Add(this.btnThoat);
            this.gbThongTinSV.Controls.Add(this.btnLuu);
            this.gbThongTinSV.Controls.Add(this.btnMacDinh);
            this.gbThongTinSV.Controls.Add(this.btnChon);
            this.gbThongTinSV.Controls.Add(this.rdNu);
            this.gbThongTinSV.Controls.Add(this.rdNam);
            this.gbThongTinSV.Controls.Add(this.dtpNgSinh);
            this.gbThongTinSV.Controls.Add(this.cbLop);
            this.gbThongTinSV.Controls.Add(this.txtEmail);
            this.gbThongTinSV.Controls.Add(this.txtHinh);
            this.gbThongTinSV.Controls.Add(this.txtDiaChi);
            this.gbThongTinSV.Controls.Add(this.txtHoTen);
            this.gbThongTinSV.Controls.Add(this.mtxtSDT);
            this.gbThongTinSV.Controls.Add(this.mtxtMSSV);
            this.gbThongTinSV.Controls.Add(this.label5);
            this.gbThongTinSV.Controls.Add(this.label4);
            this.gbThongTinSV.Controls.Add(this.label3);
            this.gbThongTinSV.Controls.Add(this.label2);
            this.gbThongTinSV.Controls.Add(this.label9);
            this.gbThongTinSV.Controls.Add(this.label8);
            this.gbThongTinSV.Controls.Add(this.label7);
            this.gbThongTinSV.Controls.Add(this.label6);
            this.gbThongTinSV.Controls.Add(this.label1);
            this.gbThongTinSV.Location = new System.Drawing.Point(158, 3);
            this.gbThongTinSV.Name = "gbThongTinSV";
            this.gbThongTinSV.Size = new System.Drawing.Size(574, 189);
            this.gbThongTinSV.TabIndex = 1;
            this.gbThongTinSV.TabStop = false;
            this.gbThongTinSV.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(447, 151);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 21);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(347, 151);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 21);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(247, 151);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(94, 21);
            this.btnMacDinh.TabIndex = 10;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(447, 124);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(94, 21);
            this.btnChon.TabIndex = 9;
            this.btnChon.Text = "Chọn hình";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(419, 50);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 6;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(356, 50);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgSinh.Location = new System.Drawing.Point(356, 24);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(185, 20);
            this.dtpNgSinh.TabIndex = 4;
            this.dtpNgSinh.Tag = "";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
            this.cbLop.Location = new System.Drawing.Point(356, 72);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(185, 21);
            this.cbLop.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(74, 125);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(367, 20);
            this.txtHinh.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(74, 99);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(185, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(74, 47);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(185, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(356, 99);
            this.mtxtSDT.Mask = "0000.000.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(185, 20);
            this.mtxtSDT.TabIndex = 8;
            // 
            // mtxtMSSV
            // 
            this.mtxtMSSV.Location = new System.Drawing.Point(74, 21);
            this.mtxtMSSV.Mask = "0000000";
            this.mtxtMSSV.Name = "mtxtMSSV";
            this.mtxtMSSV.Size = new System.Drawing.Size(185, 20);
            this.mtxtMSSV.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hình";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số diện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Controls.Add(this.lvDanhSachSV);
            this.gbDanhSach.Location = new System.Drawing.Point(6, 198);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(725, 188);
            this.gbDanhSach.TabIndex = 0;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh sách sinh viên";
            // 
            // lvDanhSachSV
            // 
            this.lvDanhSachSV.CheckBoxes = true;
            this.lvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.HoTen,
            this.GT,
            this.NgSinh,
            this.Lop,
            this.SĐT,
            this.Email,
            this.DiaChi,
            this.hinh});
            this.lvDanhSachSV.ContextMenuStrip = this.ctxtmLvSV;
            this.lvDanhSachSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachSV.GridLines = true;
            this.lvDanhSachSV.HideSelection = false;
            this.lvDanhSachSV.Location = new System.Drawing.Point(3, 16);
            this.lvDanhSachSV.Name = "lvDanhSachSV";
            this.lvDanhSachSV.Size = new System.Drawing.Size(719, 169);
            this.lvDanhSachSV.TabIndex = 0;
            this.lvDanhSachSV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachSV.View = System.Windows.Forms.View.Details;
            this.lvDanhSachSV.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachSV_SelectedIndexChanged);
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            this.MSSV.Width = 69;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ và tên";
            this.HoTen.Width = 126;
            // 
            // GT
            // 
            this.GT.Text = "Phái";
            this.GT.Width = 59;
            // 
            // NgSinh
            // 
            this.NgSinh.Text = "Ngày sinh";
            this.NgSinh.Width = 86;
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            // 
            // SĐT
            // 
            this.SĐT.Text = "Số điện thoại";
            this.SĐT.Width = 83;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 72;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 99;
            // 
            // hinh
            // 
            this.hinh.Text = "Hình";
            // 
            // ctxtmLvSV
            // 
            this.ctxtmLvSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.ctxtmLvSV.Name = "ctxtmLvSV";
            this.ctxtmLvSV.Size = new System.Drawing.Size(212, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItem1.Text = "Xóa các sinh viên đã chọn";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ofdChonHinh
            // 
            this.ofdChonHinh.FileName = "openFileDialog1";
            this.ofdChonHinh.Filter = "File JPEG |*.jpg";
            // 
            // frmQuanLySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 412);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbThongTinSV);
            this.Controls.Add(this.pbHinh);
            this.Name = "frmQuanLySV";
            this.Text = "Quản lý thông tin sinh viên khoa CNTT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.gbThongTinSV.ResumeLayout(false);
            this.gbThongTinSV.PerformLayout();
            this.gbDanhSach.ResumeLayout(false);
            this.ctxtmLvSV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.GroupBox gbThongTinSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtMSSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.ListView lvDanhSachSV;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader GT;
        private System.Windows.Forms.ColumnHeader NgSinh;
        private System.Windows.Forms.ColumnHeader Lop;
        private System.Windows.Forms.ColumnHeader SĐT;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader hinh;
        private System.Windows.Forms.ContextMenuStrip ctxtmLvSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog ofdChonHinh;
    }
}

