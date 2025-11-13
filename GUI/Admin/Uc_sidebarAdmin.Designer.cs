namespace BTL_LTTQ.GUI.Admin
{
    partial class Uc_sidebarAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnKhoa = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnTKBC = new FontAwesome.Sharp.IconButton();
            this.btnNhapDiem = new FontAwesome.Sharp.IconButton();
            this.btnHocPhan = new FontAwesome.Sharp.IconButton();
            this.btnSinhVien = new FontAwesome.Sharp.IconButton();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnKhoa);
            this.panelMenu.Controls.Add(this.btnTaiKhoan);
            this.panelMenu.Controls.Add(this.btnTKBC);
            this.panelMenu.Controls.Add(this.btnNhapDiem);
            this.panelMenu.Controls.Add(this.btnHocPhan);
            this.panelMenu.Controls.Add(this.btnSinhVien);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(100, 600);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoa.FlatAppearance.BorderSize = 0;
            this.btnKhoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoa.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.ForeColor = System.Drawing.Color.White;
            this.btnKhoa.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnKhoa.IconColor = System.Drawing.Color.White;
            this.btnKhoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhoa.IconSize = 30;
            this.btnKhoa.Location = new System.Drawing.Point(0, 470);
            this.btnKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnKhoa.Size = new System.Drawing.Size(100, 60);
            this.btnKhoa.TabIndex = 16;
            this.btnKhoa.Tag = "Khoa";
            this.btnKhoa.Text = "  Khoa";
            this.btnKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 410);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(100, 60);
            this.btnTaiKhoan.TabIndex = 14;
            this.btnTaiKhoan.Tag = "Tài Khoản";
            this.btnTaiKhoan.Text = "  Tài Khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnTKBC
            // 
            this.btnTKBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTKBC.FlatAppearance.BorderSize = 0;
            this.btnTKBC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnTKBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKBC.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKBC.ForeColor = System.Drawing.Color.White;
            this.btnTKBC.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnTKBC.IconColor = System.Drawing.Color.White;
            this.btnTKBC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTKBC.Location = new System.Drawing.Point(0, 350);
            this.btnTKBC.Margin = new System.Windows.Forms.Padding(4);
            this.btnTKBC.Name = "btnTKBC";
            this.btnTKBC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTKBC.Size = new System.Drawing.Size(100, 60);
            this.btnTKBC.TabIndex = 13;
            this.btnTKBC.Tag = "Thống Kê Báo Cáo";
            this.btnTKBC.Text = "  Thống Kê Báo Cáo";
            this.btnTKBC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKBC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTKBC.UseVisualStyleBackColor = true;
            this.btnTKBC.Click += new System.EventHandler(this.btnTKBC_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapDiem.FlatAppearance.BorderSize = 0;
            this.btnNhapDiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnNhapDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapDiem.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDiem.ForeColor = System.Drawing.Color.White;
            this.btnNhapDiem.IconChar = FontAwesome.Sharp.IconChar.Keyboard;
            this.btnNhapDiem.IconColor = System.Drawing.Color.White;
            this.btnNhapDiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapDiem.Location = new System.Drawing.Point(0, 290);
            this.btnNhapDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhapDiem.Size = new System.Drawing.Size(100, 60);
            this.btnNhapDiem.TabIndex = 12;
            this.btnNhapDiem.Tag = "Nhập Điểm";
            this.btnNhapDiem.Text = "  Nhập Điểm";
            this.btnNhapDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnHocPhan
            // 
            this.btnHocPhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHocPhan.FlatAppearance.BorderSize = 0;
            this.btnHocPhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnHocPhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocPhan.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocPhan.ForeColor = System.Drawing.Color.White;
            this.btnHocPhan.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnHocPhan.IconColor = System.Drawing.Color.White;
            this.btnHocPhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHocPhan.Location = new System.Drawing.Point(0, 230);
            this.btnHocPhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnHocPhan.Name = "btnHocPhan";
            this.btnHocPhan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHocPhan.Size = new System.Drawing.Size(100, 60);
            this.btnHocPhan.TabIndex = 11;
            this.btnHocPhan.Tag = "Học Phần";
            this.btnHocPhan.Text = "  Học Phần";
            this.btnHocPhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocPhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHocPhan.UseVisualStyleBackColor = true;
            this.btnHocPhan.Click += new System.EventHandler(this.btnHocPhan_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinhVien.FlatAppearance.BorderSize = 0;
            this.btnSinhVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVien.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnSinhVien.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnSinhVien.IconColor = System.Drawing.Color.White;
            this.btnSinhVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 170);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSinhVien.Size = new System.Drawing.Size(100, 60);
            this.btnSinhVien.TabIndex = 10;
            this.btnSinhVien.Tag = "Sinh Viên";
            this.btnSinhVien.Text = "  Sinh Viên";
            this.btnSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnTrangChu.IconColor = System.Drawing.Color.White;
            this.btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 110);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(100, 60);
            this.btnTrangChu.TabIndex = 9;
            this.btnTrangChu.Tag = "Trang Chủ";
            this.btnTrangChu.Text = "  Trang Chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(100, 110);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_LTTQ.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(137, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(94, 110);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnDangXuat.IconColor = System.Drawing.Color.White;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.IconSize = 30;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 540);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(100, 60);
            this.btnDangXuat.TabIndex = 17;
            this.btnDangXuat.Tag = "Đăng xuất";
            this.btnDangXuat.Text = "  Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // Uc_sidebarAdmin
            // 
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_sidebarAdmin";
            this.Size = new System.Drawing.Size(100, 600);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnKhoa;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private FontAwesome.Sharp.IconButton btnTKBC;
        private FontAwesome.Sharp.IconButton btnNhapDiem;
        private FontAwesome.Sharp.IconButton btnHocPhan;
        private FontAwesome.Sharp.IconButton btnSinhVien;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnDangXuat;
    }
}
