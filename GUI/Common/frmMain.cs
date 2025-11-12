using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace BTL_LTTQ.GUI.Common
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            sidebar.Dock = DockStyle.Left;
            sidebar.MenuClicked += Sidebar_MenuClicked;
            this.Controls.Add(sidebar);

            this.Resize += FrmMain_Resize; // Gắn sự kiện resize
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            sidebar.AutoAdjustByWindowSize(this.Width);
        }

        private void Sidebar_MenuClicked(object sender, string buttonName)
        {
            //switch (buttonName)
            //{
            //    case "btnTrangChu":
            //        LoadContent(new UC_TrangChu());
            //        break;
            //    case "btnSinhVien":
            //        LoadContent(new UC_QuanLySinhVien());
            //        break;
            //    case "btnMonHoc":
            //        LoadContent(new UC_QuanLyMonHoc());
            //        break;
            //    case "btnThongKe":
            //        LoadContent(new UC_ThongKe());
            //        break;
            //}
        }


    }
}
