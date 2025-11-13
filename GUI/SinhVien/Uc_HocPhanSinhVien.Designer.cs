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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lBTimKiem = new System.Windows.Forms.Label();
            this.tBTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panelThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lBIntro
            // 
            this.lBIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBIntro.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBIntro.Location = new System.Drawing.Point(0, 0);
            this.lBIntro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBIntro.Name = "lBIntro";
            this.lBIntro.Size = new System.Drawing.Size(634, 60);
            this.lBIntro.TabIndex = 0;
            this.lBIntro.Text = "Danh sách học phần sinh viên";
            this.lBIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lBIntro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 60);
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
            this.lBMaSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBMaSinhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBMaSinhVien.Location = new System.Drawing.Point(2, 0);
            this.lBMaSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBMaSinhVien.Name = "lBMaSinhVien";
            this.lBMaSinhVien.Size = new System.Drawing.Size(95, 57);
            this.lBMaSinhVien.TabIndex = 1;
            this.lBMaSinhVien.Text = "Mã sinh viên:";
            this.lBMaSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBLop
            // 
            this.lBLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBLop.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLop.Location = new System.Drawing.Point(438, 0);
            this.lBLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBLop.Name = "lBLop";
            this.lBLop.Size = new System.Drawing.Size(61, 57);
            this.lBLop.TabIndex = 3;
            this.lBLop.Text = "Lớp:";
            this.lBLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lBLop.Click += new System.EventHandler(this.lBLop_Click);
            // 
            // LBTenSinhVien
            // 
            this.LBTenSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBTenSinhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTenSinhVien.Location = new System.Drawing.Point(220, 0);
            this.LBTenSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBTenSinhVien.Name = "LBTenSinhVien";
            this.LBTenSinhVien.Size = new System.Drawing.Size(95, 57);
            this.LBTenSinhVien.TabIndex = 2;
            this.LBTenSinhVien.Text = "Tên sinh viên:";
            this.LBTenSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 57);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lBTimKiem
            // 
            this.lBTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBTimKiem.Location = new System.Drawing.Point(2, 0);
            this.lBTimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBTimKiem.Name = "lBTimKiem";
            this.lBTimKiem.Size = new System.Drawing.Size(313, 27);
            this.lBTimKiem.TabIndex = 7;
            this.lBTimKiem.Text = "Tìm kiếm:";
            this.lBTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lBTimKiem.Click += new System.EventHandler(this.lBTimKiem_Click);
            // 
            // tBTimKiem
            // 
            this.tBTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tBTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTimKiem.Location = new System.Drawing.Point(50, 29);
            this.tBTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tBTimKiem.Name = "tBTimKiem";
            this.tBTimKiem.Size = new System.Drawing.Size(217, 21);
            this.tBTimKiem.TabIndex = 8;
            this.tBTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(319, 29);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(66, 21);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
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
            this.panelThongTin.Controls.Add(this.lBMaSinhVien, 0, 0);
            this.panelThongTin.Controls.Add(this.label1, 1, 0);
            this.panelThongTin.Controls.Add(this.LBTenSinhVien, 2, 0);
            this.panelThongTin.Controls.Add(this.label2, 3, 0);
            this.panelThongTin.Controls.Add(this.lBLop, 4, 0);
            this.panelThongTin.Controls.Add(this.label3, 5, 0);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTin.Location = new System.Drawing.Point(0, 60);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.RowCount = 1;
            this.panelThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelThongTin.Size = new System.Drawing.Size(634, 57);
            this.panelThongTin.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tBTimKiem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTim, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lBTimKiem, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 81);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 170);
            this.dataGridView1.TabIndex = 12;
            // 
            // Uc_HocPhanSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Uc_HocPhanSinhVien";
            this.Size = new System.Drawing.Size(634, 368);
            this.panel1.ResumeLayout(false);
            this.panelThongTin.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lBIntro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lBMaSinhVien;
        private System.Windows.Forms.Label lBLop;
        private System.Windows.Forms.Label LBTenSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lBTimKiem;
        private System.Windows.Forms.TextBox tBTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TableLayoutPanel panelThongTin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
