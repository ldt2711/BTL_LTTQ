namespace BTL_LTTQ.GUI.Admin
{
    partial class FrmQLSV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uc_sidebarAdmin1 = new BTL_LTTQ.GUI.Admin.Uc_sidebarAdmin();
            this.SuspendLayout();
            // 
            // uc_sidebarAdmin1
            // 
            this.uc_sidebarAdmin1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_sidebarAdmin1.Location = new System.Drawing.Point(0, 0);
            this.uc_sidebarAdmin1.Margin = new System.Windows.Forms.Padding(4);
            this.uc_sidebarAdmin1.Name = "uc_sidebarAdmin1";
            this.uc_sidebarAdmin1.Size = new System.Drawing.Size(100, 599);
            this.uc_sidebarAdmin1.TabIndex = 0;
            this.uc_sidebarAdmin1.MenuClicked += new System.EventHandler<string>(this.Sidebar_MenuClicked);
            this.uc_sidebarAdmin1.Load += new System.EventHandler(this.uc_sidebarAdmin1_Load);
            // 
            // FrmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 599);
            this.Controls.Add(this.uc_sidebarAdmin1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(867, 638);
            this.Name = "FrmQLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLSV";
            this.ResumeLayout(false);

        }

        #endregion

        private Uc_sidebarAdmin uc_sidebarAdmin1;
    }
}