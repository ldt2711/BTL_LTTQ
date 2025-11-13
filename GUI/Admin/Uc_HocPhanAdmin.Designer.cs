namespace BTL_LTTQ.GUI.Admin
{
    partial class Uc_HocPhanAdmin
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
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.panelAction = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHocPhan = new System.Windows.Forms.DataGridView();
            this.MaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongSoQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongSoKTHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.lblTrongSoQT = new System.Windows.Forms.Label();
            this.lblTrongSoKTHP = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtTrongSoQT = new System.Windows.Forms.TextBox();
            this.txtTrongSoKTHP = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(684, 61);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(684, 61);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Học phần";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnXuatFile);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 418);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottom.Size = new System.Drawing.Size(684, 60);
            this.panelBottom.TabIndex = 12;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXuatFile.Location = new System.Drawing.Point(583, 10);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(91, 40);
            this.btnXuatFile.TabIndex = 6;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.White;
            this.panelAction.Controls.Add(this.tableLayoutPanel1);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAction.Location = new System.Drawing.Point(0, 61);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(684, 151);
            this.panelAction.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.70175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.48538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.38012F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.48538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.67836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtTenHP, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTenHP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMaHP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSoTinChi, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTrongSoQT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTrongSoKTHP, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMaHP, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSoTinChi, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTrongSoQT, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTrongSoKTHP, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 151);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvHocPhan
            // 
            this.dgvHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocPhan,
            this.TenHocPhan,
            this.SoTinChi,
            this.TrongSoQT,
            this.TrongSoKTHP});
            this.dgvHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocPhan.Location = new System.Drawing.Point(0, 212);
            this.dgvHocPhan.Name = "dgvHocPhan";
            this.dgvHocPhan.RowHeadersVisible = false;
            this.dgvHocPhan.Size = new System.Drawing.Size(684, 206);
            this.dgvHocPhan.TabIndex = 14;
            // 
            // MaHocPhan
            // 
            this.MaHocPhan.FillWeight = 20F;
            this.MaHocPhan.HeaderText = "Mã học phần";
            this.MaHocPhan.Name = "MaHocPhan";
            this.MaHocPhan.ReadOnly = true;
            // 
            // TenHocPhan
            // 
            this.TenHocPhan.FillWeight = 70F;
            this.TenHocPhan.HeaderText = "Tên học phần";
            this.TenHocPhan.Name = "TenHocPhan";
            this.TenHocPhan.ReadOnly = true;
            // 
            // SoTinChi
            // 
            this.SoTinChi.FillWeight = 20F;
            this.SoTinChi.HeaderText = "Số tín chỉ";
            this.SoTinChi.Name = "SoTinChi";
            this.SoTinChi.ReadOnly = true;
            // 
            // TrongSoQT
            // 
            this.TrongSoQT.FillWeight = 20F;
            this.TrongSoQT.HeaderText = "Trọng số điểm quá trình";
            this.TrongSoQT.Name = "TrongSoQT";
            this.TrongSoQT.ReadOnly = true;
            // 
            // TrongSoKTHP
            // 
            this.TrongSoKTHP.FillWeight = 20F;
            this.TrongSoKTHP.HeaderText = "Trọng số điểm KTHP";
            this.TrongSoKTHP.Name = "TrongSoKTHP";
            this.TrongSoKTHP.ReadOnly = true;
            // 
            // lblTenHP
            // 
            this.lblTenHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Location = new System.Drawing.Point(132, 8);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(73, 13);
            this.lblTenHP.TabIndex = 0;
            this.lblTenHP.Text = "Mã học phần:";
            this.lblTenHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaHP
            // 
            this.lblMaHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Location = new System.Drawing.Point(128, 38);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(77, 13);
            this.lblMaHP.TabIndex = 1;
            this.lblMaHP.Text = "Tên học phần:";
            this.lblMaHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Location = new System.Drawing.Point(149, 68);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(56, 13);
            this.lblSoTinChi.TabIndex = 2;
            this.lblSoTinChi.Text = "Số tín chỉ:";
            this.lblSoTinChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrongSoQT
            // 
            this.lblTrongSoQT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTrongSoQT.AutoSize = true;
            this.lblTrongSoQT.Location = new System.Drawing.Point(83, 98);
            this.lblTrongSoQT.Name = "lblTrongSoQT";
            this.lblTrongSoQT.Size = new System.Drawing.Size(122, 13);
            this.lblTrongSoQT.TabIndex = 3;
            this.lblTrongSoQT.Text = "Trọng số điểm quá trình:";
            this.lblTrongSoQT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrongSoKTHP
            // 
            this.lblTrongSoKTHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTrongSoKTHP.AutoSize = true;
            this.lblTrongSoKTHP.Location = new System.Drawing.Point(95, 129);
            this.lblTrongSoKTHP.Name = "lblTrongSoKTHP";
            this.lblTrongSoKTHP.Size = new System.Drawing.Size(110, 13);
            this.lblTrongSoKTHP.TabIndex = 4;
            this.lblTrongSoKTHP.Text = "Trọng số điểm KTHP:";
            this.lblTrongSoKTHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(227, 3);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(112, 20);
            this.txtMaHP.TabIndex = 5;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(227, 33);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(181, 20);
            this.txtTenHP.TabIndex = 6;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(227, 63);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(67, 20);
            this.txtSoTinChi.TabIndex = 7;
            // 
            // txtTrongSoQT
            // 
            this.txtTrongSoQT.Location = new System.Drawing.Point(227, 93);
            this.txtTrongSoQT.Name = "txtTrongSoQT";
            this.txtTrongSoQT.Size = new System.Drawing.Size(67, 20);
            this.txtTrongSoQT.TabIndex = 8;
            // 
            // txtTrongSoKTHP
            // 
            this.txtTrongSoKTHP.Location = new System.Drawing.Point(227, 123);
            this.txtTrongSoKTHP.Name = "txtTrongSoKTHP";
            this.txtTrongSoKTHP.Size = new System.Drawing.Size(67, 20);
            this.txtTrongSoKTHP.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(483, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(483, 63);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(483, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // Uc_HocPhanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvHocPhan);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Uc_HocPhanAdmin";
            this.Size = new System.Drawing.Size(684, 478);
            this.panelTitle.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongSoQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongSoKTHP;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.Label lblTrongSoQT;
        private System.Windows.Forms.Label lblTrongSoKTHP;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtTrongSoQT;
        private System.Windows.Forms.TextBox txtTrongSoKTHP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
    }
}
