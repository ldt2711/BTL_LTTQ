using BTL_LTTQ.GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ.GUI.SinhVien
{
    public partial class frmSinhVien : Form
    {
        private Form frmLoginInstance;
        // Các UserControl
        private Uc_TrangChuSinhVien uc_trangChuSinhVien;
        private Uc_HocPhanSinhVien uc_hocPhanSinhVien;
        private Uc_XemDiemSinhVien uc_xemDiemSinhVien;
        private Uc_TTCNSinhVien uc_ttcnSinhVien;

        private void KhoiTaoUserControls()
        {


            // Khởi tạo các UC
            uc_hocPhanSinhVien = new Uc_HocPhanSinhVien();
            uc_trangChuSinhVien = new Uc_TrangChuSinhVien();
            uc_xemDiemSinhVien = new Uc_XemDiemSinhVien();
            uc_ttcnSinhVien = new Uc_TTCNSinhVien();

            // Dock fill
            uc_trangChuSinhVien.Dock = DockStyle.Fill;
            uc_hocPhanSinhVien.Dock = DockStyle.Fill;
            uc_xemDiemSinhVien.Dock = DockStyle.Fill;
            uc_ttcnSinhVien.Dock = DockStyle.Fill;

            // Thêm vào form
            this.Controls.AddRange(new Control[] {
                uc_trangChuSinhVien, uc_hocPhanSinhVien,
                uc_xemDiemSinhVien, uc_ttcnSinhVien
            });

            // Ẩn hết
            AnTatCaUC();

            // Hiển thị mặc định TrangChu
            uc_trangChuSinhVien.Visible = true;
            uc_trangChuSinhVien.BringToFront();
        }

        public frmSinhVien(Form frmLoginInstance)
        {
            InitializeComponent();
            KhoiTaoUserControls();
            this.Resize += FrmSinhVien_Resize;
            this.frmLoginInstance = frmLoginInstance;
            this.FormClosed += FrmSinhVien_FormClosed;
        }
        private void FrmSinhVien_Resize(object sender, EventArgs e)
        {
            uc_sidebarSinhVien1.AutoAdjustByWindowSize(this.Width);
        }

        private void Sidebar_MenuClicked(object sender, string menuName)
        {
            // Ẩn tất cả UC
            AnTatCaUC();

            // Hiển thị đúng UC
            UserControl uc = null;

            switch (menuName)
            {
                case "TrangChu":
                    uc = uc_trangChuSinhVien;
                    break;
                case "HocPhan":
                    uc = uc_hocPhanSinhVien;
                    break;
                case "XemDiem":
                    uc = uc_xemDiemSinhVien;
                    break;
                case "TTCN":
                    uc = uc_ttcnSinhVien;
                    break;
                case "DangXuat":
                    if (frmLoginInstance != null)
                    {
                        frmLoginInstance.Show();
                    }
                    this.Close();
                    break;
                default:
                    uc = uc_trangChuSinhVien;
                    break;
            }

            if (uc != null)
            {
                uc.Visible = true;
                uc.BringToFront(); // gọi BringToFront ở Form cha
            }
        }

        private void AnTatCaUC()
        {
            uc_trangChuSinhVien.Visible = false;
            uc_hocPhanSinhVien.Visible = false;
            uc_xemDiemSinhVien.Visible = false;
            uc_ttcnSinhVien.Visible = false;
        }

        private void FrmSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmLoginInstance != null && !frmLoginInstance.Visible)
            {
                frmLoginInstance.Close();
            }
        }
    }
}
