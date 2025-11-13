namespace BTL_LTTQ.GUI.Admin
{
    partial class Uc_TKBCAdmin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartHocLuc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelButton = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblFilter2 = new System.Windows.Forms.Label();
            this.lblFilter1 = new System.Windows.Forms.Label();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.cbFilter1 = new System.Windows.Forms.ComboBox();
            this.cbValue1 = new System.Windows.Forms.ComboBox();
            this.cbFilter2 = new System.Windows.Forms.ComboBox();
            this.cbValue2 = new System.Windows.Forms.ComboBox();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHocLuc)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelButton);
            this.panel1.Controls.Add(this.panelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 562);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartHocLuc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 362);
            this.panel2.TabIndex = 3;
            // 
            // chartHocLuc
            // 
            this.chartHocLuc.BackColor = System.Drawing.Color.Transparent;
            this.chartHocLuc.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartHocLuc.ChartAreas.Add(chartArea2);
            this.chartHocLuc.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chartHocLuc.Legends.Add(legend2);
            this.chartHocLuc.Location = new System.Drawing.Point(0, 0);
            this.chartHocLuc.Name = "chartHocLuc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartHocLuc.Series.Add(series2);
            this.chartHocLuc.Size = new System.Drawing.Size(769, 362);
            this.chartHocLuc.TabIndex = 0;
            this.chartHocLuc.Text = "chart1";
            // 
            // panelButton
            // 
            this.panelButton.ColumnCount = 5;
            this.panelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelButton.Controls.Add(this.panel3, 4, 1);
            this.panelButton.Controls.Add(this.lblFilter2, 2, 0);
            this.panelButton.Controls.Add(this.lblFilter1, 0, 0);
            this.panelButton.Controls.Add(this.lblValue1, 0, 1);
            this.panelButton.Controls.Add(this.cbFilter1, 1, 0);
            this.panelButton.Controls.Add(this.cbValue1, 1, 1);
            this.panelButton.Controls.Add(this.cbFilter2, 3, 0);
            this.panelButton.Controls.Add(this.cbValue2, 3, 1);
            this.panelButton.Controls.Add(this.lblValue2, 2, 1);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 100);
            this.panelButton.Name = "panelButton";
            this.panelButton.RowCount = 2;
            this.panelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelButton.Size = new System.Drawing.Size(769, 100);
            this.panelButton.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(655, 53);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel3.Size = new System.Drawing.Size(111, 44);
            this.panel3.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButton1.IconColor = System.Drawing.Color.Gray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(101, 34);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Lọc";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // lblFilter2
            // 
            this.lblFilter2.AutoSize = true;
            this.lblFilter2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFilter2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter2.Location = new System.Drawing.Point(348, 0);
            this.lblFilter2.Name = "lblFilter2";
            this.lblFilter2.Size = new System.Drawing.Size(77, 50);
            this.lblFilter2.TabIndex = 6;
            this.lblFilter2.Text = "Học Kỳ/ Năm:";
            this.lblFilter2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFilter1
            // 
            this.lblFilter1.AutoSize = true;
            this.lblFilter1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFilter1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter1.Location = new System.Drawing.Point(3, 0);
            this.lblFilter1.Name = "lblFilter1";
            this.lblFilter1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblFilter1.Size = new System.Drawing.Size(71, 50);
            this.lblFilter1.TabIndex = 0;
            this.lblFilter1.Text = "Khoa/ Lớp:";
            this.lblFilter1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblValue1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue1.Location = new System.Drawing.Point(3, 50);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(0, 50);
            this.lblValue1.TabIndex = 1;
            this.lblValue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbFilter1
            // 
            this.cbFilter1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilter1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter1.FormattingEnabled = true;
            this.cbFilter1.Location = new System.Drawing.Point(118, 12);
            this.cbFilter1.Name = "cbFilter1";
            this.cbFilter1.Size = new System.Drawing.Size(121, 26);
            this.cbFilter1.TabIndex = 2;
            this.cbFilter1.SelectedIndexChanged += new System.EventHandler(this.cbFilter1_SelectedIndexChanged);
            // 
            // cbValue1
            // 
            this.cbValue1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbValue1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValue1.FormattingEnabled = true;
            this.cbValue1.Location = new System.Drawing.Point(118, 62);
            this.cbValue1.Name = "cbValue1";
            this.cbValue1.Size = new System.Drawing.Size(121, 26);
            this.cbValue1.TabIndex = 3;
            // 
            // cbFilter2
            // 
            this.cbFilter2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilter2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter2.FormattingEnabled = true;
            this.cbFilter2.Location = new System.Drawing.Point(463, 12);
            this.cbFilter2.Name = "cbFilter2";
            this.cbFilter2.Size = new System.Drawing.Size(121, 26);
            this.cbFilter2.TabIndex = 4;
            this.cbFilter2.SelectedIndexChanged += new System.EventHandler(this.cbFilter2_SelectedIndexChanged);
            // 
            // cbValue2
            // 
            this.cbValue2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbValue2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValue2.FormattingEnabled = true;
            this.cbValue2.Location = new System.Drawing.Point(463, 62);
            this.cbValue2.Name = "cbValue2";
            this.cbValue2.Size = new System.Drawing.Size(121, 26);
            this.cbValue2.TabIndex = 5;
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblValue2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue2.Location = new System.Drawing.Point(348, 50);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(0, 50);
            this.lblValue2.TabIndex = 8;
            this.lblValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(769, 100);
            this.panelTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(769, 100);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "THỐNG KÊ HỌC LỰC";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Uc_TKBCAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Uc_TKBCAdmin";
            this.Size = new System.Drawing.Size(769, 562);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHocLuc)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel panelButton;
        private System.Windows.Forms.Label lblFilter1;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblFilter2;
        private System.Windows.Forms.ComboBox cbFilter1;
        private System.Windows.Forms.ComboBox cbValue1;
        private System.Windows.Forms.ComboBox cbFilter2;
        private System.Windows.Forms.ComboBox cbValue2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHocLuc;
        private System.Windows.Forms.Panel panel3;
    }
}
