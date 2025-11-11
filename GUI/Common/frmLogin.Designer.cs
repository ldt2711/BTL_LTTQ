namespace BTL_LTTQ.Common
{
    partial class frmLogin
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbTenTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.tBTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.tBMatKhau = new System.Windows.Forms.TextBox();
            this.gBDangNhap = new System.Windows.Forms.GroupBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbGioiThieu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBookIcon = new System.Windows.Forms.PictureBox();
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.gBDangNhap.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBookIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(4, 15);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(131, 31);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Đăng nhập";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // lbTenTaiKhoan
            // 
            this.lbTenTaiKhoan.AutoSize = true;
            this.lbTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTaiKhoan.Location = new System.Drawing.Point(8, 53);
            this.lbTenTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            this.lbTenTaiKhoan.Size = new System.Drawing.Size(74, 13);
            this.lbTenTaiKhoan.TabIndex = 1;
            this.lbTenTaiKhoan.Text = "Tên tài khoản";
            this.lbTenTaiKhoan.Click += new System.EventHandler(this.lbTenTaiKhoan_Click);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(8, 110);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(54, 13);
            this.lbMatKhau.TabIndex = 2;
            this.lbMatKhau.Text = "Mật khẩu";
            this.lbMatKhau.Click += new System.EventHandler(this.lbMatKhau_Click);
            // 
            // tBTenTaiKhoan
            // 
            this.tBTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTenTaiKhoan.Location = new System.Drawing.Point(10, 77);
            this.tBTenTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBTenTaiKhoan.Name = "tBTenTaiKhoan";
            this.tBTenTaiKhoan.Size = new System.Drawing.Size(187, 22);
            this.tBTenTaiKhoan.TabIndex = 3;
            this.tBTenTaiKhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tBMatKhau
            // 
            this.tBMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBMatKhau.Location = new System.Drawing.Point(10, 136);
            this.tBMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBMatKhau.Name = "tBMatKhau";
            this.tBMatKhau.Size = new System.Drawing.Size(187, 22);
            this.tBMatKhau.TabIndex = 4;
            // 
            // gBDangNhap
            // 
            this.gBDangNhap.Controls.Add(this.btnQuenMK);
            this.gBDangNhap.Controls.Add(this.lbLogin);
            this.gBDangNhap.Controls.Add(this.btLogin);
            this.gBDangNhap.Controls.Add(this.tBMatKhau);
            this.gBDangNhap.Controls.Add(this.tBTenTaiKhoan);
            this.gBDangNhap.Controls.Add(this.lbTenTaiKhoan);
            this.gBDangNhap.Controls.Add(this.lbMatKhau);
            this.gBDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBDangNhap.Location = new System.Drawing.Point(376, 35);
            this.gBDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBDangNhap.Name = "gBDangNhap";
            this.gBDangNhap.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBDangNhap.Size = new System.Drawing.Size(207, 236);
            this.gBDangNhap.TabIndex = 5;
            this.gBDangNhap.TabStop = false;
            this.gBDangNhap.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogin.Location = new System.Drawing.Point(40, 192);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(110, 25);
            this.btLogin.TabIndex = 7;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbGioiThieu
            // 
            this.lbGioiThieu.AutoSize = true;
            this.lbGioiThieu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiThieu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbGioiThieu.Location = new System.Drawing.Point(34, 169);
            this.lbGioiThieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGioiThieu.Name = "lbGioiThieu";
            this.lbGioiThieu.Size = new System.Drawing.Size(283, 50);
            this.lbGioiThieu.TabIndex = 6;
            this.lbGioiThieu.Text = "Chào mừng đến với trang web\r\nquản lý sinh viên";
            this.lbGioiThieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pBookIcon);
            this.panel1.Controls.Add(this.lbGioiThieu);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 373);
            this.panel1.TabIndex = 7;
            // 
            // pBookIcon
            // 
            this.pBookIcon.BackColor = System.Drawing.Color.SteelBlue;
            this.pBookIcon.Image = global::BTL_LTTQ.Properties.Resources.pngwing_com;
            this.pBookIcon.Location = new System.Drawing.Point(139, 25);
            this.pBookIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBookIcon.Name = "pBookIcon";
            this.pBookIcon.Size = new System.Drawing.Size(101, 108);
            this.pBookIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBookIcon.TabIndex = 7;
            this.pBookIcon.TabStop = false;
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.FlatAppearance.BorderSize = 0;
            this.btnQuenMK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuenMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuenMK.Location = new System.Drawing.Point(50, 164);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(90, 23);
            this.btnQuenMK.TabIndex = 9;
            this.btnQuenMK.Text = "Quên mật khẩu";
            this.btnQuenMK.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gBDangNhap);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.gBDangNhap.ResumeLayout(false);
            this.gBDangNhap.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBookIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbTenTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox tBTenTaiKhoan;
        private System.Windows.Forms.TextBox tBMatKhau;
        private System.Windows.Forms.GroupBox gBDangNhap;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbGioiThieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBookIcon;
        private System.Windows.Forms.Button btnQuenMK;
    }
}