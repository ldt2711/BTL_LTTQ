using BTL_LTTQ.GUI.Common;
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
        // Các UserControl
        private Uc_TrangChuAdmin uc_trangChuAdmin;
        private Uc_SinhVienAdmin uc_sinhVienAdmin;
        private Uc_HocPhanAdmin uc_hocPhanAdmin;
        private Uc_NhapDiemAdmin uc_nhapDiemAdmin;
        private Uc_TKBCAdmin uc_tkbcAdmin;
        private Uc_TKAdmin uc_taiKhoanAdmin;
        private Uc_KhoaAdmin uc_khoaAdmin;

        private void KhoiTaoUserControls()
        {


            // Khởi tạo các UC
            uc_trangChuAdmin = new Uc_TrangChuAdmin();
            uc_sinhVienAdmin = new Uc_SinhVienAdmin();
            uc_hocPhanAdmin = new Uc_HocPhanAdmin();
            uc_nhapDiemAdmin = new Uc_NhapDiemAdmin();
            uc_tkbcAdmin = new Uc_TKBCAdmin();
            uc_taiKhoanAdmin = new Uc_TKAdmin();
            uc_khoaAdmin = new Uc_KhoaAdmin();

            // Dock fill
            uc_trangChuAdmin.Dock = DockStyle.Fill;
            uc_sinhVienAdmin.Dock = DockStyle.Fill;
            uc_hocPhanAdmin.Dock = DockStyle.Fill;
            uc_nhapDiemAdmin.Dock = DockStyle.Fill;
            uc_tkbcAdmin.Dock = DockStyle.Fill;
            uc_taiKhoanAdmin.Dock = DockStyle.Fill;
            uc_khoaAdmin.Dock = DockStyle.Fill;

            // Thêm vào form
            this.Controls.AddRange(new Control[] {
                uc_trangChuAdmin, uc_sinhVienAdmin, uc_hocPhanAdmin,
                uc_nhapDiemAdmin, uc_tkbcAdmin, uc_taiKhoanAdmin, uc_khoaAdmin
            });

            // Ẩn hết
            AnTatCaUC();

            // Hiển thị mặc định TrangChu
            uc_trangChuAdmin.Visible = true;
            uc_trangChuAdmin.BringToFront();
        }

        public FrmQLSV()
        {
            InitializeComponent();
            KhoiTaoUserControls();


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
                    uc = uc_trangChuAdmin;
                    break;
                case "SinhVien":
                    uc = uc_sinhVienAdmin;
                    break;
                case "HocPhan":
                    uc = uc_hocPhanAdmin;
                    break;
                case "NhapDiem":
                    uc = uc_nhapDiemAdmin;
                    break;
                case "TKBC":
                    uc = uc_tkbcAdmin;
                    break;
                case "TaiKhoan":
                    uc = uc_taiKhoanAdmin;
                    break;
                case "Khoa":
                    uc = uc_khoaAdmin;
                    break;
                default:
                    uc = uc_trangChuAdmin;
                    break;
            }

            if (uc != null)
            {
                uc.Visible = true;
                uc.BringToFront(); // ✅ gọi BringToFront ở Form cha
            }
        }

        private void AnTatCaUC()
        {
            uc_trangChuAdmin.Visible = false;
            uc_sinhVienAdmin.Visible = false;
            uc_hocPhanAdmin.Visible = false;
            uc_nhapDiemAdmin.Visible = false;
            uc_tkbcAdmin.Visible = false;
            uc_taiKhoanAdmin.Visible = false;
            uc_khoaAdmin.Visible = false;
        }

        private void uc_sidebarAdmin1_Load(object sender, EventArgs e)
        {

        }
    }
}
