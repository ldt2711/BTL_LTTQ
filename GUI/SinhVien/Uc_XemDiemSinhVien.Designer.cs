namespace BTL_LTTQ.GUI.SinhVien
{
    partial class Uc_XemDiemSinhVien
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
            this.panelFilter = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnXuatBangDiem = new System.Windows.Forms.Button();
            this.panelDiem = new System.Windows.Forms.Panel();
            this.dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.MaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKTHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblChonHP = new System.Windows.Forms.Label();
            this.lblChonHK = new System.Windows.Forms.Label();
            this.lblChonNH = new System.Windows.Forms.Label();
            this.cboHocPhan = new System.Windows.Forms.ComboBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(702, 61);
            this.panelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(702, 61);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Bảng điểm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.tableLayoutPanel1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 61);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(702, 80);
            this.panelFilter.TabIndex = 10;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnXuatBangDiem);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 424);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottom.Size = new System.Drawing.Size(702, 60);
            this.panelBottom.TabIndex = 11;
            // 
            // btnXuatBangDiem
            // 
            this.btnXuatBangDiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXuatBangDiem.Location = new System.Drawing.Point(601, 10);
            this.btnXuatBangDiem.Name = "btnXuatBangDiem";
            this.btnXuatBangDiem.Size = new System.Drawing.Size(91, 40);
            this.btnXuatBangDiem.TabIndex = 6;
            this.btnXuatBangDiem.Text = "Xuất bảng điểm";
            this.btnXuatBangDiem.UseVisualStyleBackColor = true;
            // 
            // panelDiem
            // 
            this.panelDiem.Controls.Add(this.dgvBangDiem);
            this.panelDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiem.Location = new System.Drawing.Point(0, 141);
            this.panelDiem.Name = "panelDiem";
            this.panelDiem.Size = new System.Drawing.Size(702, 283);
            this.panelDiem.TabIndex = 12;
            // 
            // dgvBangDiem
            // 
            this.dgvBangDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocPhan,
            this.TenHocPhan,
            this.SoTinChi,
            this.DiemQT,
            this.DiemKTHP});
            this.dgvBangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangDiem.Location = new System.Drawing.Point(0, 0);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.RowHeadersVisible = false;
            this.dgvBangDiem.Size = new System.Drawing.Size(702, 283);
            this.dgvBangDiem.TabIndex = 10;
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
            // DiemQT
            // 
            this.DiemQT.FillWeight = 20F;
            this.DiemQT.HeaderText = "Điểm quá trình";
            this.DiemQT.Name = "DiemQT";
            this.DiemQT.ReadOnly = true;
            // 
            // DiemKTHP
            // 
            this.DiemKTHP.FillWeight = 20F;
            this.DiemKTHP.HeaderText = "Điểm kết thúc học phần";
            this.DiemKTHP.Name = "DiemKTHP";
            this.DiemKTHP.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.30435F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.608696F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnTraCuu, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboNamHoc, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChonLop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboLop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChonHP, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChonHK, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChonNH, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboHocPhan, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboHocKy, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 80);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChonLop.Location = new System.Drawing.Point(3, 0);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(60, 80);
            this.lblChonLop.TabIndex = 0;
            this.lblChonLop.Text = "Chọn lớp";
            this.lblChonLop.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboLop
            // 
            this.cboLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(69, 3);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(60, 21);
            this.cboLop.TabIndex = 1;
            // 
            // lblChonHP
            // 
            this.lblChonHP.AutoSize = true;
            this.lblChonHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChonHP.Location = new System.Drawing.Point(135, 0);
            this.lblChonHP.Name = "lblChonHP";
            this.lblChonHP.Size = new System.Drawing.Size(60, 80);
            this.lblChonHP.TabIndex = 2;
            this.lblChonHP.Text = "Chọn học phần";
            this.lblChonHP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChonHK
            // 
            this.lblChonHK.AutoSize = true;
            this.lblChonHK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChonHK.Location = new System.Drawing.Point(300, 0);
            this.lblChonHK.Name = "lblChonHK";
            this.lblChonHK.Size = new System.Drawing.Size(60, 80);
            this.lblChonHK.TabIndex = 3;
            this.lblChonHK.Text = "Chọn học kỳ";
            this.lblChonHK.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChonNH
            // 
            this.lblChonNH.AutoSize = true;
            this.lblChonNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChonNH.Location = new System.Drawing.Point(412, 0);
            this.lblChonNH.Name = "lblChonNH";
            this.lblChonNH.Size = new System.Drawing.Size(60, 80);
            this.lblChonNH.TabIndex = 4;
            this.lblChonNH.Text = "Chọn năm học";
            this.lblChonNH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboHocPhan
            // 
            this.cboHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboHocPhan.FormattingEnabled = true;
            this.cboHocPhan.Location = new System.Drawing.Point(201, 3);
            this.cboHocPhan.Name = "cboHocPhan";
            this.cboHocPhan.Size = new System.Drawing.Size(93, 21);
            this.cboHocPhan.TabIndex = 2;
            // 
            // cboHocKy
            // 
            this.cboHocKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(366, 3);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(40, 21);
            this.cboHocKy.TabIndex = 3;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(478, 3);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(127, 21);
            this.cboNamHoc.TabIndex = 4;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTraCuu.Location = new System.Drawing.Point(613, 22);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(84, 35);
            this.btnTraCuu.TabIndex = 5;
            this.btnTraCuu.Text = "Tra cứu điểm";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // Uc_XemDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDiem);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTitle);
            this.Name = "Uc_XemDiemSinhVien";
            this.Size = new System.Drawing.Size(702, 484);
            this.panelTitle.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnXuatBangDiem;
        private System.Windows.Forms.Panel panelDiem;
        private System.Windows.Forms.DataGridView dgvBangDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKTHP;
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
    }
}
