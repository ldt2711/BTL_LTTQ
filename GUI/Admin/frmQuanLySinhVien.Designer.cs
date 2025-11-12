namespace BTL_LTTQ.GUI.Admin
{
    partial class frmQuanLySinhVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gBInfomation = new System.Windows.Forms.GroupBox();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbNoiSinh = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.lbMaTaiKhoan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.tBLop = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tBMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rBNam = new System.Windows.Forms.RadioButton();
            this.rBNu = new System.Windows.Forms.RadioButton();
            this.cBKhoa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gBInfomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 753);
            this.panel1.TabIndex = 1;
            // 
            // gBInfomation
            // 
            this.gBInfomation.BackColor = System.Drawing.Color.AliceBlue;
            this.gBInfomation.Controls.Add(this.btnXoa);
            this.gBInfomation.Controls.Add(this.btnSua);
            this.gBInfomation.Controls.Add(this.btnThem);
            this.gBInfomation.Controls.Add(this.cBKhoa);
            this.gBInfomation.Controls.Add(this.rBNu);
            this.gBInfomation.Controls.Add(this.rBNam);
            this.gBInfomation.Controls.Add(this.dateTimePicker1);
            this.gBInfomation.Controls.Add(this.lbMatKhau);
            this.gBInfomation.Controls.Add(this.tBMaTaiKhoan);
            this.gBInfomation.Controls.Add(this.tbHoTen);
            this.gBInfomation.Controls.Add(this.textBox6);
            this.gBInfomation.Controls.Add(this.tBLop);
            this.gBInfomation.Controls.Add(this.textBox1);
            this.gBInfomation.Controls.Add(this.lbMaTaiKhoan);
            this.gBInfomation.Controls.Add(this.lbMaKhoa);
            this.gBInfomation.Controls.Add(this.lbGioiTinh);
            this.gBInfomation.Controls.Add(this.lbLop);
            this.gBInfomation.Controls.Add(this.lbNoiSinh);
            this.gBInfomation.Controls.Add(this.lbNgaySinh);
            this.gBInfomation.Controls.Add(this.lbHoTen);
            this.gBInfomation.Controls.Add(this.lbMaSV);
            this.gBInfomation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBInfomation.Location = new System.Drawing.Point(200, 0);
            this.gBInfomation.Name = "gBInfomation";
            this.gBInfomation.Size = new System.Drawing.Size(982, 215);
            this.gBInfomation.TabIndex = 2;
            this.gBInfomation.TabStop = false;
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSV.Location = new System.Drawing.Point(15, 18);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(85, 17);
            this.lbMaSV.TabIndex = 0;
            this.lbMaSV.Text = "Mã sinh viên";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(15, 58);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(68, 17);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ và tên";
            this.lbHoTen.Click += new System.EventHandler(this.lbHoTen_Click);
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(15, 92);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(69, 17);
            this.lbNgaySinh.TabIndex = 2;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbNoiSinh
            // 
            this.lbNoiSinh.AutoSize = true;
            this.lbNoiSinh.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiSinh.Location = new System.Drawing.Point(15, 132);
            this.lbNoiSinh.Name = "lbNoiSinh";
            this.lbNoiSinh.Size = new System.Drawing.Size(58, 17);
            this.lbNoiSinh.TabIndex = 3;
            this.lbNoiSinh.Text = "Nơi sinh";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(348, 60);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(30, 17);
            this.lbLop.TabIndex = 4;
            this.lbLop.Text = "Lớp";
            this.lbLop.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(348, 20);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(59, 17);
            this.lbGioiTinh.TabIndex = 5;
            this.lbGioiTinh.Text = "Giới tính";
            this.lbGioiTinh.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhoa.Location = new System.Drawing.Point(348, 94);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(61, 17);
            this.lbMaKhoa.TabIndex = 6;
            this.lbMaKhoa.Text = "Mã khoa";
            this.lbMaKhoa.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbMaTaiKhoan
            // 
            this.lbMaTaiKhoan.AutoSize = true;
            this.lbMaTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTaiKhoan.Location = new System.Drawing.Point(348, 132);
            this.lbMaTaiKhoan.Name = "lbMaTaiKhoan";
            this.lbMaTaiKhoan.Size = new System.Drawing.Size(88, 17);
            this.lbMaTaiKhoan.TabIndex = 7;
            this.lbMaTaiKhoan.Text = "Mã tài khoản";
            this.lbMaTaiKhoan.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(106, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 25);
            this.textBox1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 653);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 100);
            this.panel2.TabIndex = 9;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(200, 215);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(982, 438);
            this.dgvSinhVien.TabIndex = 10;
            // 
            // tBLop
            // 
            this.tBLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBLop.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBLop.Location = new System.Drawing.Point(442, 50);
            this.tBLop.Name = "tBLop";
            this.tBLop.Size = new System.Drawing.Size(162, 25);
            this.tBLop.TabIndex = 12;
            this.tBLop.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(106, 136);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(162, 25);
            this.textBox6.TabIndex = 13;
            // 
            // tbHoTen
            // 
            this.tbHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHoTen.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTen.Location = new System.Drawing.Point(106, 58);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(162, 25);
            this.tbHoTen.TabIndex = 14;
            this.tbHoTen.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // tBMaTaiKhoan
            // 
            this.tBMaTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBMaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBMaTaiKhoan.Location = new System.Drawing.Point(442, 130);
            this.tBMaTaiKhoan.Name = "tBMaTaiKhoan";
            this.tBMaTaiKhoan.Size = new System.Drawing.Size(162, 25);
            this.tBMaTaiKhoan.TabIndex = 15;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(348, 166);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(0, 17);
            this.lbMatKhau.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // rBNam
            // 
            this.rBNam.AutoSize = true;
            this.rBNam.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBNam.Location = new System.Drawing.Point(438, 16);
            this.rBNam.Name = "rBNam";
            this.rBNam.Size = new System.Drawing.Size(57, 21);
            this.rBNam.TabIndex = 18;
            this.rBNam.TabStop = true;
            this.rBNam.Text = "Nam";
            this.rBNam.UseVisualStyleBackColor = true;
            // 
            // rBNu
            // 
            this.rBNu.AutoSize = true;
            this.rBNu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBNu.Location = new System.Drawing.Point(510, 16);
            this.rBNu.Name = "rBNu";
            this.rBNu.Size = new System.Drawing.Size(47, 21);
            this.rBNu.TabIndex = 19;
            this.rBNu.TabStop = true;
            this.rBNu.Text = "Nữ";
            this.rBNu.UseVisualStyleBackColor = true;
            // 
            // cBKhoa
            // 
            this.cBKhoa.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBKhoa.FormattingEnabled = true;
            this.cBKhoa.Items.AddRange(new object[] {
            "CK",
            "CNTT",
            "KHMT"});
            this.cBKhoa.Location = new System.Drawing.Point(442, 94);
            this.cBKhoa.Name = "cBKhoa";
            this.cBKhoa.Size = new System.Drawing.Size(162, 25);
            this.cBKhoa.TabIndex = 20;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(752, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 41);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(752, 80);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 41);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(752, 136);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 41);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gBInfomation);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLySinhVien";
            this.Text = "frmQuanLySinhVien";
            this.gBInfomation.ResumeLayout(false);
            this.gBInfomation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gBInfomation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbMaTaiKhoan;
        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbNoiSinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tBLop;
        private System.Windows.Forms.TextBox tBMaTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.RadioButton rBNam;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cBKhoa;
        private System.Windows.Forms.RadioButton rBNu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}