namespace BTL_LTTQ.GUI.SinhVien
{
    partial class frmSinhVien
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
            this.uc_sidebarSinhVien1 = new BTL_LTTQ.GUI.SinhVien.Uc_sidebarSinhVien();
            this.SuspendLayout();
            // 
            // uc_sidebarSinhVien1
            // 
            this.uc_sidebarSinhVien1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uc_sidebarSinhVien1.Location = new System.Drawing.Point(0, 0);
            this.uc_sidebarSinhVien1.Name = "uc_sidebarSinhVien1";
            this.uc_sidebarSinhVien1.Size = new System.Drawing.Size(100, 656);
            this.uc_sidebarSinhVien1.TabIndex = 0;
            this.uc_sidebarSinhVien1.MenuClicked += new System.EventHandler<string>(this.Sidebar_MenuClicked);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 656);
            this.Controls.Add(this.uc_sidebarSinhVien1);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.ResumeLayout(false);

        }

        #endregion

        private Uc_sidebarSinhVien uc_sidebarSinhVien1;
    }
}