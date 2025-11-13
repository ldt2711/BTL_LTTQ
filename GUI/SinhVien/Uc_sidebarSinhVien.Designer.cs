namespace BTL_LTTQ.GUI.SinhVien
{
    partial class Uc_sidebarSinhVien
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnTTCN = new FontAwesome.Sharp.IconButton();
            this.btnXemDiem = new FontAwesome.Sharp.IconButton();
            this.btnHocPhan = new FontAwesome.Sharp.IconButton();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(133, 151);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_LTTQ.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(183, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 112);
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
            this.btnMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(125, 74);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnTTCN);
            this.panelMenu.Controls.Add(this.btnXemDiem);
            this.panelMenu.Controls.Add(this.btnHocPhan);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(133, 678);
            this.panelMenu.TabIndex = 4;
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
            this.btnDangXuat.Location = new System.Drawing.Point(0, 604);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(133, 74);
            this.btnDangXuat.TabIndex = 18;
            this.btnDangXuat.Tag = "Đăng xuất";
            this.btnDangXuat.Text = "  Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTTCN
            // 
            this.btnTTCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTCN.FlatAppearance.BorderSize = 0;
            this.btnTTCN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnTTCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTCN.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTCN.ForeColor = System.Drawing.Color.White;
            this.btnTTCN.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnTTCN.IconColor = System.Drawing.Color.White;
            this.btnTTCN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTTCN.IconSize = 30;
            this.btnTTCN.Location = new System.Drawing.Point(0, 373);
            this.btnTTCN.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTTCN.Name = "btnTTCN";
            this.btnTTCN.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnTTCN.Size = new System.Drawing.Size(133, 74);
            this.btnTTCN.TabIndex = 16;
            this.btnTTCN.Tag = "Thông Tin Cá Nhân";
            this.btnTTCN.Text = "  Thông Tin Cá Nhân";
            this.btnTTCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTTCN.UseVisualStyleBackColor = true;
            this.btnTTCN.Click += new System.EventHandler(this.btnTTCN_Click);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemDiem.FlatAppearance.BorderSize = 0;
            this.btnXemDiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXemDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDiem.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.ForeColor = System.Drawing.Color.White;
            this.btnXemDiem.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnXemDiem.IconColor = System.Drawing.Color.White;
            this.btnXemDiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXemDiem.Location = new System.Drawing.Point(0, 299);
            this.btnXemDiem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnXemDiem.Size = new System.Drawing.Size(133, 74);
            this.btnXemDiem.TabIndex = 12;
            this.btnXemDiem.Tag = "Xem Điểm";
            this.btnXemDiem.Text = "  Xem Điểm";
            this.btnXemDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemDiem.UseVisualStyleBackColor = true;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
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
            this.btnHocPhan.Location = new System.Drawing.Point(0, 225);
            this.btnHocPhan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnHocPhan.Name = "btnHocPhan";
            this.btnHocPhan.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnHocPhan.Size = new System.Drawing.Size(133, 74);
            this.btnHocPhan.TabIndex = 11;
            this.btnHocPhan.Tag = "Học Phần";
            this.btnHocPhan.Text = "  Học Phần";
            this.btnHocPhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocPhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHocPhan.UseVisualStyleBackColor = true;
            this.btnHocPhan.Click += new System.EventHandler(this.btnHocPhan_Click);
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
            this.btnTrangChu.Location = new System.Drawing.Point(0, 151);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(133, 74);
            this.btnTrangChu.TabIndex = 9;
            this.btnTrangChu.Tag = "Trang Chủ";
            this.btnTrangChu.Text = "  Trang Chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // Uc_sidebarSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Uc_sidebarSinhVien";
            this.Size = new System.Drawing.Size(133, 678);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnTTCN;
        private FontAwesome.Sharp.IconButton btnXemDiem;
        private FontAwesome.Sharp.IconButton btnHocPhan;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDangXuat;
    }
}
