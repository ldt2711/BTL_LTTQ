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
            this.components = new System.ComponentModel.Container();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelAction = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.lblTrongSoQT = new System.Windows.Forms.Label();
            this.lblTrongSoKTHP = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtTrongSoQT = new System.Windows.Forms.TextBox();
            this.txtTrongSoKTHP = new System.Windows.Forms.TextBox();
            this.dgvHocPhan = new System.Windows.Forms.DataGridView();
            this.MaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongSoQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongSoKTHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOCPHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCPHANDataSet = new BTL_LTTQ.HOCPHANDataSet();
            this.hOCPHANTableAdapter = new BTL_LTTQ.HOCPHANDataSetTableAdapters.HOCPHANTableAdapter();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHANDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1067, 61);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1067, 61);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "HỌC PHẦN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnXuatFile);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 500);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottom.Size = new System.Drawing.Size(1067, 60);
            this.panelBottom.TabIndex = 12;
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBottom_Paint);
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.White;
            this.panelAction.Controls.Add(this.tableLayoutPanel1);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAction.Location = new System.Drawing.Point(0, 61);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(1067, 215);
            this.panelAction.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.47895F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.467344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.467344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.46299F));
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
            this.tableLayoutPanel1.Controls.Add(this.lblHocKy, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblNamHoc, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtHocKy, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtNamHoc, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 215);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHP.Location = new System.Drawing.Point(354, 33);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(181, 26);
            this.txtTenHP.TabIndex = 6;
            // 
            // lblTenHP
            // 
            this.lblTenHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHP.Location = new System.Drawing.Point(212, 6);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(110, 18);
            this.lblTenHP.TabIndex = 0;
            this.lblTenHP.Text = "Mã học phần:";
            this.lblTenHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaHP
            // 
            this.lblMaHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHP.Location = new System.Drawing.Point(207, 36);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(115, 18);
            this.lblMaHP.TabIndex = 1;
            this.lblMaHP.Text = "Tên học phần:";
            this.lblMaHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTinChi.Location = new System.Drawing.Point(239, 66);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(83, 18);
            this.lblSoTinChi.TabIndex = 2;
            this.lblSoTinChi.Text = "Số tín chỉ:";
            this.lblSoTinChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrongSoQT
            // 
            this.lblTrongSoQT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTrongSoQT.AutoSize = true;
            this.lblTrongSoQT.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrongSoQT.Location = new System.Drawing.Point(131, 96);
            this.lblTrongSoQT.Name = "lblTrongSoQT";
            this.lblTrongSoQT.Size = new System.Drawing.Size(191, 18);
            this.lblTrongSoQT.TabIndex = 3;
            this.lblTrongSoQT.Text = "Trọng số điểm quá trình:";
            this.lblTrongSoQT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrongSoKTHP
            // 
            this.lblTrongSoKTHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTrongSoKTHP.AutoSize = true;
            this.lblTrongSoKTHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrongSoKTHP.Location = new System.Drawing.Point(157, 126);
            this.lblTrongSoKTHP.Name = "lblTrongSoKTHP";
            this.lblTrongSoKTHP.Size = new System.Drawing.Size(165, 18);
            this.lblTrongSoKTHP.TabIndex = 4;
            this.lblTrongSoKTHP.Text = "Trọng số điểm KTHP:";
            this.lblTrongSoKTHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHP.Location = new System.Drawing.Point(354, 3);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(112, 26);
            this.txtMaHP.TabIndex = 5;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTinChi.Location = new System.Drawing.Point(354, 63);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(67, 26);
            this.txtSoTinChi.TabIndex = 7;
            // 
            // txtTrongSoQT
            // 
            this.txtTrongSoQT.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrongSoQT.Location = new System.Drawing.Point(354, 93);
            this.txtTrongSoQT.Name = "txtTrongSoQT";
            this.txtTrongSoQT.Size = new System.Drawing.Size(67, 26);
            this.txtTrongSoQT.TabIndex = 8;
            // 
            // txtTrongSoKTHP
            // 
            this.txtTrongSoKTHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrongSoKTHP.Location = new System.Drawing.Point(354, 123);
            this.txtTrongSoKTHP.Name = "txtTrongSoKTHP";
            this.txtTrongSoKTHP.Size = new System.Drawing.Size(67, 26);
            this.txtTrongSoKTHP.TabIndex = 9;
            // 
            // dgvHocPhan
            // 
            this.dgvHocPhan.AutoGenerateColumns = false;
            this.dgvHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocPhan,
            this.TenHocPhan,
            this.SoTinChi,
            this.TrongSoQT,
            this.TrongSoKTHP,
            this.hocKyDataGridViewTextBoxColumn,
            this.namHocDataGridViewTextBoxColumn});
            this.dgvHocPhan.DataSource = this.hOCPHANBindingSource;
            this.dgvHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocPhan.Location = new System.Drawing.Point(0, 276);
            this.dgvHocPhan.Name = "dgvHocPhan";
            this.dgvHocPhan.RowHeadersVisible = false;
            this.dgvHocPhan.Size = new System.Drawing.Size(1067, 224);
            this.dgvHocPhan.TabIndex = 14;
            this.dgvHocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPhan_CellClick);
            this.dgvHocPhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPhan_CellClick);
            // 
            // MaHocPhan
            // 
            this.MaHocPhan.DataPropertyName = "MaHP";
            this.MaHocPhan.FillWeight = 30F;
            this.MaHocPhan.HeaderText = "Mã HP";
            this.MaHocPhan.Name = "MaHocPhan";
            this.MaHocPhan.ReadOnly = true;
            // 
            // TenHocPhan
            // 
            this.TenHocPhan.DataPropertyName = "TenHP";
            this.TenHocPhan.FillWeight = 70F;
            this.TenHocPhan.HeaderText = "Tên học phần";
            this.TenHocPhan.Name = "TenHocPhan";
            this.TenHocPhan.ReadOnly = true;
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SoTin";
            this.SoTinChi.FillWeight = 30F;
            this.SoTinChi.HeaderText = "Số tín chỉ";
            this.SoTinChi.Name = "SoTinChi";
            this.SoTinChi.ReadOnly = true;
            // 
            // TrongSoQT
            // 
            this.TrongSoQT.DataPropertyName = "TrongSoQT";
            this.TrongSoQT.FillWeight = 20F;
            this.TrongSoQT.HeaderText = "Trọng số điểm quá trình";
            this.TrongSoQT.Name = "TrongSoQT";
            this.TrongSoQT.ReadOnly = true;
            // 
            // TrongSoKTHP
            // 
            this.TrongSoKTHP.DataPropertyName = "TrongSoKTHP";
            this.TrongSoKTHP.FillWeight = 20F;
            this.TrongSoKTHP.HeaderText = "Trọng số điểm KTHP";
            this.TrongSoKTHP.Name = "TrongSoKTHP";
            this.TrongSoKTHP.ReadOnly = true;
            // 
            // hocKyDataGridViewTextBoxColumn
            // 
            this.hocKyDataGridViewTextBoxColumn.DataPropertyName = "HocKy";
            this.hocKyDataGridViewTextBoxColumn.FillWeight = 30F;
            this.hocKyDataGridViewTextBoxColumn.HeaderText = "Học kỳ";
            this.hocKyDataGridViewTextBoxColumn.Name = "hocKyDataGridViewTextBoxColumn";
            // 
            // namHocDataGridViewTextBoxColumn
            // 
            this.namHocDataGridViewTextBoxColumn.DataPropertyName = "NamHoc";
            this.namHocDataGridViewTextBoxColumn.FillWeight = 30F;
            this.namHocDataGridViewTextBoxColumn.HeaderText = "Năm học";
            this.namHocDataGridViewTextBoxColumn.Name = "namHocDataGridViewTextBoxColumn";
            // 
            // hOCPHANBindingSource
            // 
            this.hOCPHANBindingSource.DataMember = "HOCPHAN";
            this.hOCPHANBindingSource.DataSource = this.hOCPHANDataSet;
            // 
            // hOCPHANDataSet
            // 
            this.hOCPHANDataSet.DataSetName = "HOCPHANDataSet";
            this.hOCPHANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCPHANTableAdapter
            // 
            this.hOCPHANTableAdapter.ClearBeforeFill = true;
            // 
            // lblHocKy
            // 
            this.lblHocKy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.Location = new System.Drawing.Point(261, 156);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(61, 18);
            this.lblHocKy.TabIndex = 13;
            this.lblHocKy.Text = "Học Kỳ";
            this.lblHocKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.Location = new System.Drawing.Point(245, 188);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(77, 18);
            this.lblNamHoc.TabIndex = 14;
            this.lblNamHoc.Text = "Năm Học";
            this.lblNamHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.Location = new System.Drawing.Point(354, 153);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(67, 26);
            this.txtHocKy.TabIndex = 15;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.Location = new System.Drawing.Point(354, 183);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(67, 26);
            this.txtNamHoc.TabIndex = 16;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(753, 32);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 26);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(753, 62);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 26);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(753, 92);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 26);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnXuatFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXuatFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXuatFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(939, 10);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(118, 40);
            this.btnXuatFile.TabIndex = 8;
            this.btnXuatFile.Text = "Export File";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Uc_HocPhanAdmin";
            this.Size = new System.Drawing.Size(1067, 560);
            this.panelTitle.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHANDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvHocPhan;
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
        private System.Windows.Forms.BindingSource hOCPHANBindingSource;
        private HOCPHANDataSet hOCPHANDataSet;
        private HOCPHANDataSetTableAdapters.HOCPHANTableAdapter hOCPHANTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongSoQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongSoKTHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXuatFile;
    }
}
