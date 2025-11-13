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
            this.lBQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.pnLayout = new System.Windows.Forms.Panel();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.pBGraduate = new System.Windows.Forms.PictureBox();
            this.gBDangNhap.SuspendLayout();
            this.pnLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBGraduate)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(5, 18);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(227, 46);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "ĐĂNG NHẬP";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // lbTenTaiKhoan
            // 
            this.lbTenTaiKhoan.AutoSize = true;
            this.lbTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTaiKhoan.Location = new System.Drawing.Point(7, 108);
            this.lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            this.lbTenTaiKhoan.Size = new System.Drawing.Size(162, 32);
            this.lbTenTaiKhoan.TabIndex = 1;
            this.lbTenTaiKhoan.Text = "Tên tài khoản";
            this.lbTenTaiKhoan.Click += new System.EventHandler(this.lbTenTaiKhoan_Click);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(6, 186);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(119, 32);
            this.lbMatKhau.TabIndex = 2;
            this.lbMatKhau.Text = "Mật khẩu";
            this.lbMatKhau.Click += new System.EventHandler(this.lbMatKhau_Click);
            // 
            // tBTenTaiKhoan
            // 
            this.tBTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTenTaiKhoan.Location = new System.Drawing.Point(15, 140);
            this.tBTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBTenTaiKhoan.Name = "tBTenTaiKhoan";
            this.tBTenTaiKhoan.Size = new System.Drawing.Size(328, 23);
            this.tBTenTaiKhoan.TabIndex = 3;
            this.tBTenTaiKhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tBMatKhau
            // 
            this.tBMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBMatKhau.Location = new System.Drawing.Point(13, 222);
            this.tBMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBMatKhau.Name = "tBMatKhau";
            this.tBMatKhau.Size = new System.Drawing.Size(330, 23);
            this.tBMatKhau.TabIndex = 4;
            // 
            // gBDangNhap
            // 
            this.gBDangNhap.Controls.Add(this.lbLogin);
            this.gBDangNhap.Controls.Add(this.btLogin);
            this.gBDangNhap.Controls.Add(this.tBMatKhau);
            this.gBDangNhap.Controls.Add(this.tBTenTaiKhoan);
            this.gBDangNhap.Controls.Add(this.lbTenTaiKhoan);
            this.gBDangNhap.Controls.Add(this.lbMatKhau);
            this.gBDangNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.gBDangNhap.Location = new System.Drawing.Point(725, 0);
            this.gBDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBDangNhap.Name = "gBDangNhap";
            this.gBDangNhap.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBDangNhap.Size = new System.Drawing.Size(356, 618);
            this.gBDangNhap.TabIndex = 5;
            this.gBDangNhap.TabStop = false;
            this.gBDangNhap.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogin.Location = new System.Drawing.Point(85, 333);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(182, 54);
            this.btLogin.TabIndex = 7;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lBQuenMatKhau
            // 
            this.lBQuenMatKhau.AutoSize = true;
            this.lBQuenMatKhau.Location = new System.Drawing.Point(84, 203);
            this.lBQuenMatKhau.Name = "lBQuenMatKhau";
            this.lBQuenMatKhau.Size = new System.Drawing.Size(96, 16);
            this.lBQuenMatKhau.TabIndex = 8;
            this.lBQuenMatKhau.TabStop = true;
            this.lBQuenMatKhau.Text = "Quên mật khẩu";
            // 
            // pnLayout
            // 
            this.pnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.pnLayout.Controls.Add(this.lbWelcome);
            this.pnLayout.Controls.Add(this.pBGraduate);
            this.pnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLayout.Location = new System.Drawing.Point(0, 0);
            this.pnLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnLayout.Name = "pnLayout";
            this.pnLayout.Size = new System.Drawing.Size(725, 618);
            this.pnLayout.TabIndex = 6;
            this.pnLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLayout_Paint);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(80, 307);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(560, 89);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "Quản lý sinh viên";
            this.lbWelcome.Click += new System.EventHandler(this.lbWelcome_Click);
            // 
            // pBGraduate
            // 
            this.pBGraduate.Image = global::BTL_LTTQ.Properties.Resources.pngwing_com;
            this.pBGraduate.Location = new System.Drawing.Point(227, 88);
            this.pBGraduate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBGraduate.Name = "pBGraduate";
            this.pBGraduate.Size = new System.Drawing.Size(260, 194);
            this.pBGraduate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBGraduate.TabIndex = 0;
            this.pBGraduate.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 618);
            this.Controls.Add(this.pnLayout);
            this.Controls.Add(this.gBDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.gBDangNhap.ResumeLayout(false);
            this.gBDangNhap.PerformLayout();
            this.pnLayout.ResumeLayout(false);
            this.pnLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBGraduate)).EndInit();
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
        private System.Windows.Forms.LinkLabel lBQuenMatKhau;
        private System.Windows.Forms.Panel pnLayout;
        private System.Windows.Forms.PictureBox pBGraduate;
        private System.Windows.Forms.Label lbWelcome;
    }
}