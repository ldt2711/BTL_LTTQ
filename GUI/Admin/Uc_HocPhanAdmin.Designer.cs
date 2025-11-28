using BTL_LTTQ.Database.DataSet;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.panelAction = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.lblTrongSoQT = new System.Windows.Forms.Label();
            this.lblTrongSoKTHP = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.txtTrongSoQT = new System.Windows.Forms.TextBox();
            this.txtTrongSoKTHP = new System.Windows.Forms.TextBox();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvHocPhan = new System.Windows.Forms.DataGridView();
            this.hOCPHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCPHANDataSet = new BTL_LTTQ.Database.DataSet.HOCPHANDataSet();
            this.hOCPHANTableAdapter = new BTL_LTTQ.Database.DataSet.HOCPHANDataSetTableAdapters.HOCPHANTableAdapter();
            this.MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongSoQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongSoKTHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitle.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.panelTitle.Size = new System.Drawing.Size(1067, 70);
            this.panelTitle.TabIndex = 1;
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
            this.lblTitle.Size = new System.Drawing.Size(1067, 70);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "QUẢN LÝ HỌC PHẦN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
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
            this.panelBottom.Click += new System.EventHandler(this.panelBottom_Click);
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBottom_Paint);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnXuatFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXuatFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXuatFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.White;
            this.panelAction.Controls.Add(this.tableLayoutPanel2);
            this.panelAction.Controls.Add(this.tableLayoutPanel1);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAction.Location = new System.Drawing.Point(0, 70);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(1067, 184);
            this.panelAction.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnSua, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTim, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 130);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 54);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.tableLayoutPanel2_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(344, 13);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 13, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 26);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(877, 13);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 13, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(110, 26);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(78, 13);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 13, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 26);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(610, 13);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 13, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 26);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.99531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.71228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.93252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.21556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.96251F));
            this.tableLayoutPanel1.Controls.Add(this.lblTenHP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMaHP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSoTinChi, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMaHP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTenHP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSoTinChi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTrongSoQT, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTrongSoKTHP, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHocKy, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTrongSoQT, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTrongSoKTHP, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHocKy, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNamHoc, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNamHoc, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 5, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 130);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // lblTenHP
            // 
            this.lblTenHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHP.Location = new System.Drawing.Point(37, 12);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(119, 18);
            this.lblTenHP.TabIndex = 0;
            this.lblTenHP.Text = "Mã Học Phần:";
            this.lblTenHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaHP
            // 
            this.lblMaHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHP.Location = new System.Drawing.Point(31, 55);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(125, 18);
            this.lblMaHP.TabIndex = 1;
            this.lblMaHP.Text = "Tên Học Phần:";
            this.lblMaHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTinChi.Location = new System.Drawing.Point(62, 99);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(94, 18);
            this.lblSoTinChi.TabIndex = 2;
            this.lblSoTinChi.Text = "Số Tín Chỉ:";
            this.lblSoTinChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHP.Location = new System.Drawing.Point(162, 3);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(181, 26);
            this.txtMaHP.TabIndex = 5;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHP.Location = new System.Drawing.Point(162, 46);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(181, 26);
            this.txtTenHP.TabIndex = 6;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTinChi.Location = new System.Drawing.Point(162, 89);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(181, 26);
            this.txtSoTinChi.TabIndex = 7;
            // 
            // lblTrongSoQT
            // 
            this.lblTrongSoQT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTrongSoQT.AutoSize = true;
            this.lblTrongSoQT.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrongSoQT.Location = new System.Drawing.Point(405, 3);
            this.lblTrongSoQT.Name = "lblTrongSoQT";
            this.lblTrongSoQT.Size = new System.Drawing.Size(166, 36);
            this.lblTrongSoQT.TabIndex = 3;
            this.lblTrongSoQT.Text = "Trọng Số Điểm Quá Trình:";
            this.lblTrongSoQT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTrongSoKTHP
            // 
            this.lblTrongSoKTHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTrongSoKTHP.AutoSize = true;
            this.lblTrongSoKTHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrongSoKTHP.Location = new System.Drawing.Point(387, 55);
            this.lblTrongSoKTHP.Name = "lblTrongSoKTHP";
            this.lblTrongSoKTHP.Size = new System.Drawing.Size(184, 18);
            this.lblTrongSoKTHP.TabIndex = 4;
            this.lblTrongSoKTHP.Text = "Trọng Số Điểm KTHP:";
            this.lblTrongSoKTHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHocKy
            // 
            this.lblHocKy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.Location = new System.Drawing.Point(500, 99);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(71, 18);
            this.lblHocKy.TabIndex = 13;
            this.lblHocKy.Text = "Học Kỳ:";
            this.lblHocKy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTrongSoQT
            // 
            this.txtTrongSoQT.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrongSoQT.Location = new System.Drawing.Point(577, 3);
            this.txtTrongSoQT.Name = "txtTrongSoQT";
            this.txtTrongSoQT.Size = new System.Drawing.Size(163, 26);
            this.txtTrongSoQT.TabIndex = 8;
            // 
            // txtTrongSoKTHP
            // 
            this.txtTrongSoKTHP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrongSoKTHP.Location = new System.Drawing.Point(577, 46);
            this.txtTrongSoKTHP.Name = "txtTrongSoKTHP";
            this.txtTrongSoKTHP.Size = new System.Drawing.Size(163, 26);
            this.txtTrongSoKTHP.TabIndex = 9;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.Location = new System.Drawing.Point(577, 89);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(163, 26);
            this.txtHocKy.TabIndex = 15;
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.Location = new System.Drawing.Point(762, 12);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(87, 18);
            this.lblNamHoc.TabIndex = 14;
            this.lblNamHoc.Text = "Năm Học:";
            this.lblNamHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.Location = new System.Drawing.Point(855, 3);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(181, 26);
            this.txtNamHoc.TabIndex = 16;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(904, 88);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 26);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvHocPhan
            // 
            this.dgvHocPhan.AllowUserToAddRows = false;
            this.dgvHocPhan.AllowUserToResizeColumns = false;
            this.dgvHocPhan.AllowUserToResizeRows = false;
            this.dgvHocPhan.AutoGenerateColumns = false;
            this.dgvHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHP,
            this.TenHP,
            this.SoTin,
            this.TrongSoQT,
            this.TrongSoKTHP,
            this.HocKy,
            this.NamHoc});
            this.dgvHocPhan.DataSource = this.hOCPHANBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocPhan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocPhan.EnableHeadersVisualStyles = false;
            this.dgvHocPhan.Location = new System.Drawing.Point(0, 254);
            this.dgvHocPhan.Name = "dgvHocPhan";
            this.dgvHocPhan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocPhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHocPhan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHocPhan.Size = new System.Drawing.Size(1067, 246);
            this.dgvHocPhan.TabIndex = 14;
            this.dgvHocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPhan_CellClick);
            this.dgvHocPhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPhan_CellClick);
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
            // MaHP
            // 
            this.MaHP.DataPropertyName = "MaHP";
            this.MaHP.FillWeight = 20F;
            this.MaHP.HeaderText = "Mã HP";
            this.MaHP.Name = "MaHP";
            this.MaHP.ReadOnly = true;
            // 
            // TenHP
            // 
            this.TenHP.DataPropertyName = "TenHP";
            this.TenHP.FillWeight = 80F;
            this.TenHP.HeaderText = "Tên Học Phần";
            this.TenHP.Name = "TenHP";
            this.TenHP.ReadOnly = true;
            // 
            // SoTin
            // 
            this.SoTin.DataPropertyName = "SoTin";
            this.SoTin.FillWeight = 20F;
            this.SoTin.HeaderText = "Số Tín";
            this.SoTin.Name = "SoTin";
            this.SoTin.ReadOnly = true;
            // 
            // TrongSoQT
            // 
            this.TrongSoQT.DataPropertyName = "TrongSoQT";
            this.TrongSoQT.FillWeight = 30F;
            this.TrongSoQT.HeaderText = "Trọng Số Điểm Quá Trình";
            this.TrongSoQT.Name = "TrongSoQT";
            this.TrongSoQT.ReadOnly = true;
            // 
            // TrongSoKTHP
            // 
            this.TrongSoKTHP.DataPropertyName = "TrongSoKTHP";
            this.TrongSoKTHP.FillWeight = 30F;
            this.TrongSoKTHP.HeaderText = "Trọng Số Điểm KTHP";
            this.TrongSoKTHP.Name = "TrongSoKTHP";
            this.TrongSoKTHP.ReadOnly = true;
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.FillWeight = 15F;
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.Name = "HocKy";
            this.HocKy.ReadOnly = true;
            // 
            // NamHoc
            // 
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.FillWeight = 15F;
            this.NamHoc.HeaderText = "Năm Học";
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.ReadOnly = true;
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
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private Database.DataSet.HOCPHANDataSetTableAdapters.HOCPHANTableAdapter hOCPHANTableAdapter;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongSoQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongSoKTHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
    }
}
