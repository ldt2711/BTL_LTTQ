namespace BTL_LTTQ.GUI.SinhVien
{
    partial class Uc_HocPhanSinhVien
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
            this.lBIntro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lBMaSinhVien = new System.Windows.Forms.Label();
            this.lBLop = new System.Windows.Forms.Label();
            this.LBTenSinhVien = new System.Windows.Forms.Label();
            this.panelThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.tBTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lBIntro
            // 
            this.lBIntro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lBIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBIntro.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBIntro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lBIntro.Location = new System.Drawing.Point(0, 0);
            this.lBIntro.Name = "lBIntro";
            this.lBIntro.Size = new System.Drawing.Size(1048, 74);
            this.lBIntro.TabIndex = 0;
            this.lBIntro.Text = "DANH SÁCH HỌC PHẦN";
            this.lBIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lBIntro.Click += new System.EventHandler(this.lBIntro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lBIntro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 74);
            this.panel1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lBMaSinhVien
            // 
            this.lBMaSinhVien.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lBMaSinhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBMaSinhVien.Location = new System.Drawing.Point(3, 22);
            this.lBMaSinhVien.Name = "lBMaSinhVien";
            this.lBMaSinhVien.Size = new System.Drawing.Size(158, 70);
            this.lBMaSinhVien.TabIndex = 1;
            this.lBMaSinhVien.Text = "Mã sinh viên:";
            this.lBMaSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBLop
            // 
            this.lBLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBLop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLop.Location = new System.Drawing.Point(725, 0);
            this.lBLop.Name = "lBLop";
            this.lBLop.Size = new System.Drawing.Size(102, 115);
            this.lBLop.TabIndex = 3;
            this.lBLop.Text = "Lớp:";
            this.lBLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lBLop.Click += new System.EventHandler(this.lBLop_Click);
            // 
            // LBTenSinhVien
            // 
            this.LBTenSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBTenSinhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTenSinhVien.Location = new System.Drawing.Point(364, 0);
            this.LBTenSinhVien.Name = "LBTenSinhVien";
            this.LBTenSinhVien.Size = new System.Drawing.Size(158, 115);
            this.LBTenSinhVien.TabIndex = 2;
            this.LBTenSinhVien.Text = "Tên sinh viên:";
            this.LBTenSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBTenSinhVien.Click += new System.EventHandler(this.LBTenSinhVien_Click);
            // 
            // panelThongTin
            // 
            this.panelThongTin.ColumnCount = 6;
            this.panelThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.67399F));
            this.panelThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.80877F));
            this.panelThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.67398F));
            this.panelThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.80877F));
            this.panelThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.34483F));
            this.panelThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.68965F));
            this.panelThongTin.Controls.Add(this.textBox2, 5, 0);
            this.panelThongTin.Controls.Add(this.textBox1, 3, 0);
            this.panelThongTin.Controls.Add(this.lBMaSinhVien, 0, 0);
            this.panelThongTin.Controls.Add(this.LBTenSinhVien, 2, 0);
            this.panelThongTin.Controls.Add(this.lBLop, 4, 0);
            this.panelThongTin.Controls.Add(this.txtMaSV, 1, 0);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTin.Location = new System.Drawing.Point(0, 74);
            this.panelThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.RowCount = 1;
            this.panelThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelThongTin.Size = new System.Drawing.Size(1048, 115);
            this.panelThongTin.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.31464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.28829F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69853F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69853F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTim, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBTimKiem, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 189);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.22884F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.26019F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.51097F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 106);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 295);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 269);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(167, 42);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(191, 30);
            this.txtMaSV.TabIndex = 7;
            // 
            // tBTimKiem
            // 
            this.tBTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTimKiem.Location = new System.Drawing.Point(184, 37);
            this.tBTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBTimKiem.Name = "tBTimKiem";
            this.tBTimKiem.Size = new System.Drawing.Size(289, 25);
            this.tBTimKiem.TabIndex = 8;
            this.tBTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(700, 37);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(137, 41);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tìm kiếm:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(528, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 30);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(833, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 30);
            this.textBox2.TabIndex = 11;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(875, 37);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(137, 41);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 308);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1040, 204);
            this.dataGridView2.TabIndex = 13;
            // 
            // Uc_HocPhanSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Uc_HocPhanSinhVien";
            this.Size = new System.Drawing.Size(1048, 564);
            this.panel1.ResumeLayout(false);
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lBIntro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lBMaSinhVien;
        private System.Windows.Forms.Label lBLop;
        private System.Windows.Forms.Label LBTenSinhVien;
        private System.Windows.Forms.TableLayoutPanel panelThongTin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox tBTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
