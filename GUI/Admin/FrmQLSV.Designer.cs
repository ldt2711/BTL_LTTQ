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
            this.sidebar_Admin = new BTL_LTTQ.GUI.Common.UC_Template();
            this.SuspendLayout();
            // 
            // sidebar_Admin
            // 
            this.sidebar_Admin.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar_Admin.Location = new System.Drawing.Point(0, 0);
            this.sidebar_Admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebar_Admin.Name = "sidebar_Admin";
            this.sidebar_Admin.Size = new System.Drawing.Size(380, 450);
            this.sidebar_Admin.TabIndex = 0;
            // 
            // FrmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidebar_Admin);
            this.Name = "FrmQLSV";
            this.Text = "FrmQLSV";
            this.ResumeLayout(false);

        }

        #endregion

        private Common.UC_Template sidebar_Admin;
    }
}