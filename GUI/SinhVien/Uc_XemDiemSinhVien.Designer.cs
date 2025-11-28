namespace BTL_LTTQ.GUI.SinhVien
{
    partial class Uc_BangDiemSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblChonHP = new System.Windows.Forms.Label();
            this.cboHocPhan = new System.Windows.Forms.ComboBox();
            this.lblChonHK = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblChonNH = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnXuat = new System.Windows.Forms.Button();
            this.panelDiem = new System.Windows.Forms.Panel();
            this.dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKTHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitle.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(886, 61);
            this.panelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(886, 61);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "BẢNG ĐIỂM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.tableLayoutPanel1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 61);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(886, 102);
            this.panelFilter.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.7991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.144469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.70429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.54176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9029346F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.39729F));
            this.tableLayoutPanel1.Controls.Add(this.lblChonLop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboLop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChonHP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboHocPhan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblChonHK, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboHocKy, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChonNH, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboNamHoc, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTraCuu, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 102);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblChonLop.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonLop.Location = new System.Drawing.Point(93, 0);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(78, 51);
            this.lblChonLop.TabIndex = 0;
            this.lblChonLop.Text = "Chọn lớp";
            this.lblChonLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLop
            // 
            this.cboLop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboLop.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(177, 12);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(140, 26);
            this.cboLop.TabIndex = 1;
            // 
            // lblChonHP
            // 
            this.lblChonHP.AutoSize = true;
            this.lblChonHP.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblChonHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonHP.Location = new System.Drawing.Point(44, 51);
            this.lblChonHP.Name = "lblChonHP";
            this.lblChonHP.Size = new System.Drawing.Size(127, 51);
            this.lblChonHP.TabIndex = 2;
            this.lblChonHP.Text = "Chọn học phần";
            this.lblChonHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboHocPhan
            // 
            this.cboHocPhan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboHocPhan.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHocPhan.FormattingEnabled = true;
            this.cboHocPhan.Location = new System.Drawing.Point(177, 63);
            this.cboHocPhan.Name = "cboHocPhan";
            this.cboHocPhan.Size = new System.Drawing.Size(140, 26);
            this.cboHocPhan.TabIndex = 2;
            // 
            // lblChonHK
            // 
            this.lblChonHK.AutoSize = true;
            this.lblChonHK.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblChonHK.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonHK.Location = new System.Drawing.Point(426, 0);
            this.lblChonHK.Name = "lblChonHK";
            this.lblChonHK.Size = new System.Drawing.Size(107, 51);
            this.lblChonHK.TabIndex = 3;
            this.lblChonHK.Text = "Chọn học kỳ";
            this.lblChonHK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboHocKy
            // 
            this.cboHocKy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboHocKy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(539, 12);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(140, 26);
            this.cboHocKy.TabIndex = 3;
            // 
            // lblChonNH
            // 
            this.lblChonNH.AutoSize = true;
            this.lblChonNH.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblChonNH.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonNH.Location = new System.Drawing.Point(410, 51);
            this.lblChonNH.Name = "lblChonNH";
            this.lblChonNH.Size = new System.Drawing.Size(123, 51);
            this.lblChonNH.TabIndex = 4;
            this.lblChonNH.Text = "Chọn năm học";
            this.lblChonNH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboNamHoc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(539, 63);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(140, 26);
            this.cboNamHoc.TabIndex = 4;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnTraCuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnTraCuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(749, 13);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2, 13, 2, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(110, 36);
            this.btnTraCuu.TabIndex = 19;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnXuat);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 448);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottom.Size = new System.Drawing.Size(886, 60);
            this.panelBottom.TabIndex = 11;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnXuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(749, 10);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(127, 40);
            this.btnXuat.TabIndex = 20;
            this.btnXuat.Text = "Xuất Báo Cáo";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // panelDiem
            // 
            this.panelDiem.Controls.Add(this.dgvBangDiem);
            this.panelDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiem.Location = new System.Drawing.Point(0, 163);
            this.panelDiem.Name = "panelDiem";
            this.panelDiem.Size = new System.Drawing.Size(886, 285);
            this.panelDiem.TabIndex = 12;
            // 
            // dgvBangDiem
            // 
            this.dgvBangDiem.AllowUserToAddRows = false;
            this.dgvBangDiem.AllowUserToDeleteRows = false;
            this.dgvBangDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvBangDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHP,
            this.TenHP,
            this.SoTin,
            this.DiemQT,
            this.DiemKTHP,
            this.DiemTongKet});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangDiem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangDiem.EnableHeadersVisualStyles = false;
            this.dgvBangDiem.Location = new System.Drawing.Point(0, 0);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.RowHeadersWidth = 51;
            this.dgvBangDiem.Size = new System.Drawing.Size(886, 285);
            this.dgvBangDiem.TabIndex = 10;
            // 
            // MaHP
            // 
            this.MaHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHP.DataPropertyName = "MaHP";
            this.MaHP.FillWeight = 30F;
            this.MaHP.HeaderText = "Mã Học Phần";
            this.MaHP.MinimumWidth = 6;
            this.MaHP.Name = "MaHP";
            this.MaHP.ReadOnly = true;
            // 
            // TenHP
            // 
            this.TenHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHP.DataPropertyName = "TenHP";
            this.TenHP.FillWeight = 40F;
            this.TenHP.HeaderText = "Tên Học Phần";
            this.TenHP.MinimumWidth = 6;
            this.TenHP.Name = "TenHP";
            this.TenHP.ReadOnly = true;
            // 
            // SoTin
            // 
            this.SoTin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTin.DataPropertyName = "SoTin";
            this.SoTin.FillWeight = 20F;
            this.SoTin.HeaderText = "Số Tín";
            this.SoTin.MinimumWidth = 6;
            this.SoTin.Name = "SoTin";
            this.SoTin.ReadOnly = true;
            // 
            // DiemQT
            // 
            this.DiemQT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemQT.DataPropertyName = "DiemQT";
            this.DiemQT.FillWeight = 30F;
            this.DiemQT.HeaderText = "Điểm Quá Trình";
            this.DiemQT.MinimumWidth = 6;
            this.DiemQT.Name = "DiemQT";
            this.DiemQT.ReadOnly = true;
            // 
            // DiemKTHP
            // 
            this.DiemKTHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemKTHP.DataPropertyName = "DiemKTHP";
            this.DiemKTHP.FillWeight = 35F;
            this.DiemKTHP.HeaderText = "Điểm Kết Thúc Học Phần";
            this.DiemKTHP.MinimumWidth = 6;
            this.DiemKTHP.Name = "DiemKTHP";
            this.DiemKTHP.ReadOnly = true;
            // 
            // DiemTongKet
            // 
            this.DiemTongKet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemTongKet.DataPropertyName = "DiemTongKet";
            this.DiemTongKet.FillWeight = 30F;
            this.DiemTongKet.HeaderText = "Điểm Tổng Kết";
            this.DiemTongKet.Name = "DiemTongKet";
            // 
            // Uc_BangDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDiem);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTitle);
            this.Name = "Uc_BangDiemSV";
            this.Size = new System.Drawing.Size(886, 508);
            this.panelTitle.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelDiem;
        private System.Windows.Forms.DataGridView dgvBangDiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblChonHP;
        private System.Windows.Forms.Label lblChonHK;
        private System.Windows.Forms.Label lblChonNH;
        private System.Windows.Forms.ComboBox cboHocPhan;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKTHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTongKet;
    }
}
