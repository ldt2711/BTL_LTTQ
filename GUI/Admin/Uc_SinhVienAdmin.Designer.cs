namespace BTL_LTTQ.GUI.Admin
{
    partial class Uc_SinhVienAdmin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet = new BTL_LTTQ.StudentDBDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sINHVIENTableAdapter = new BTL_LTTQ.StudentDBDataSetTableAdapters.SINHVIENTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 721);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 490);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.noiSinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.maKhoaDataGridViewTextBoxColumn,
            this.maTKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sINHVIENBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 490);
            this.dataGridView1.TabIndex = 2;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // noiSinhDataGridViewTextBoxColumn
            // 
            this.noiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.HeaderText = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noiSinhDataGridViewTextBoxColumn.Name = "noiSinhDataGridViewTextBoxColumn";
            this.noiSinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "Lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "Lop";
            this.lopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            this.lopDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            this.maKhoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // maTKDataGridViewTextBoxColumn
            // 
            this.maTKDataGridViewTextBoxColumn.DataPropertyName = "MaTK";
            this.maTKDataGridViewTextBoxColumn.HeaderText = "MaTK";
            this.maTKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTKDataGridViewTextBoxColumn.Name = "maTKDataGridViewTextBoxColumn";
            this.maTKDataGridViewTextBoxColumn.Width = 125;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.studentDBDataSet;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.36264F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.72528F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.89744F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.52747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.516483F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.78755F));
            this.tableLayoutPanel1.Controls.Add(this.txtLop, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMaSV, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHoTen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgaySinh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNoiSinh, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbKhoa, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGioiTinh, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 5, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 169);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtLop
            // 
            this.txtLop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLop.Location = new System.Drawing.Point(394, 16);
            this.txtLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(122, 23);
            this.txtLop.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaSV.Location = new System.Drawing.Point(103, 16);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(122, 23);
            this.txtMaSV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và Tên:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHoTen.Location = new System.Drawing.Point(103, 72);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(122, 23);
            this.txtHoTen.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(103, 129);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(122, 23);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lớp:";
            this.label5.Click += new System.EventHandler(this.label5_Click_2);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nơi Sinh:";
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNoiSinh.Location = new System.Drawing.Point(394, 72);
            this.txtNoiSinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(122, 23);
            this.txtNoiSinh.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Khoa:";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(647, 17);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(124, 24);
            this.cmbKhoa.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Giới Tính:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGioiTinh.Location = new System.Drawing.Point(394, 129);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(122, 23);
            this.txtGioiTinh.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReset.Location = new System.Drawing.Point(647, 127);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 27);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 62);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(225, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // Uc_SinhVienAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Uc_SinhVienAdmin";
            this.Size = new System.Drawing.Size(819, 721);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private StudentDBDataSet studentDBDataSet;
        private StudentDBDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.Panel panel3;
    }
}
