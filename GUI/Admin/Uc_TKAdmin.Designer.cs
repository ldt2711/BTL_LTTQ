namespace BTL_LTTQ.GUI.Admin
{
    partial class Uc_TKAdmin
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelAction = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.dgvDSTK = new System.Windows.Forms.DataGridView();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitle.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(820, 75);
            this.panelTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(820, 75);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Tài khoản";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 539);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelBottom.Size = new System.Drawing.Size(820, 52);
            this.panelBottom.TabIndex = 13;
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.White;
            this.panelAction.Controls.Add(this.tableLayoutPanel1);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAction.Location = new System.Drawing.Point(0, 75);
            this.panelAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(820, 186);
            this.panelAction.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.70175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.48538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.38012F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.48538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.67836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLoai, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMatKhau, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTaiKhoan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMaTK, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboLoai, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMatKhau, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTaiKhoan, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMaTK, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 186);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(581, 41);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(581, 78);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(581, 115);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // lblLoai
            // 
            this.lblLoai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(209, 159);
            this.lblLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(36, 16);
            this.lblLoai.TabIndex = 3;
            this.lblLoai.Text = "Loại:";
            this.lblLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(181, 121);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(64, 16);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu:";
            this.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(175, 84);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(70, 16);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Tài khoản:";
            this.lblTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaTK
            // 
            this.lblMaTK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Location = new System.Drawing.Point(159, 47);
            this.lblMaTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(86, 16);
            this.lblMaTK.TabIndex = 0;
            this.lblMaTK.Text = "Mã tài khoản:";
            this.lblMaTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboLoai.Location = new System.Drawing.Point(273, 152);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(88, 24);
            this.cboLoai.TabIndex = 13;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(273, 115);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(240, 22);
            this.txtMatKhau.TabIndex = 7;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(273, 78);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(240, 22);
            this.txtTaiKhoan.TabIndex = 6;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(273, 41);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(148, 22);
            this.txtMaTK.TabIndex = 5;
            // 
            // dgvDSTK
            // 
            this.dgvDSTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTK,
            this.TaiKhoan,
            this.MatKhau,
            this.Loai});
            this.dgvDSTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDSTK.Location = new System.Drawing.Point(0, 261);
            this.dgvDSTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDSTK.Name = "dgvDSTK";
            this.dgvDSTK.RowHeadersVisible = false;
            this.dgvDSTK.RowHeadersWidth = 51;
            this.dgvDSTK.Size = new System.Drawing.Size(820, 278);
            this.dgvDSTK.TabIndex = 15;
            // 
            // MaTK
            // 
            this.MaTK.FillWeight = 35F;
            this.MaTK.HeaderText = "Mã tài khoản";
            this.MaTK.MinimumWidth = 6;
            this.MaTK.Name = "MaTK";
            this.MaTK.ReadOnly = true;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.FillWeight = 70F;
            this.TaiKhoan.HeaderText = "Tài khoản";
            this.TaiKhoan.MinimumWidth = 6;
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.FillWeight = 70F;
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // Loai
            // 
            this.Loai.FillWeight = 20F;
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 6;
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            // 
            // Uc_TKAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvDSTK);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Uc_TKAdmin";
            this.Size = new System.Drawing.Size(820, 591);
            this.panelTitle.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvDSTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.ComboBox cboLoai;
    }
}
