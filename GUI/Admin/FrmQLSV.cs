using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ.GUI.Admin
{
    public partial class FrmQLSV : Form
    {
        public FrmQLSV()
        {
            InitializeComponent();
            sidebar_Admin.Dock = DockStyle.Left;
            sidebar_Admin.MenuClicked += Sidebar_MenuClicked;
            this.Controls.Add(sidebar_Admin);

            this.Resize += FrmMain_Resize; // Gắn sự kiện resize
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            sidebar_Admin.AutoAdjustByWindowSize(this.Width);
        }

        private void Sidebar_MenuClicked(object sender, string buttonName)
        {

        }
 
    }
}
