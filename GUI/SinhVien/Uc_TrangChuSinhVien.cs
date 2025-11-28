using BTL_LTTQ.BUS;
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
    public partial class Uc_TrangChuSinhVien : UserControl
    {
        private TaiKhoanBUS tkBus = new TaiKhoanBUS();

        public Uc_TrangChuSinhVien()
        {
            InitializeComponent();
            this.Load += Uc_TrangChu_Load;
        }

        private void Uc_TrangChu_Load(object sender, EventArgs e)
        {
            HienThiThongTinNguoiDung();
        }

        private void HienThiThongTinNguoiDung()
        {
            // 1. Kiểm tra xem có người dùng đang đăng nhập không
            if (string.IsNullOrEmpty(SessionManager.CurrentMaTK))
            {
                lbHello.Text = "CHÀO MỪNG";
                // Xóa các thông tin khác
                ClearStudentInfo();
                return;
            }

            // 2. Nếu là Admin (Loai = 0)
            if (SessionManager.CurrentRole == 0)
            {
                lbHello.Text = $"CHÀO MỪNG {SessionManager.CurrentUsername.ToUpper()} (ADMIN)";
                ClearStudentInfo();
                return;
            }

            // 3. Nếu là Sinh viên (Loai = 1)
            if (SessionManager.CurrentRole == 1)
            {
                string maTK = SessionManager.CurrentMaTK; // Lấy MaTK đã lưu khi Login

                DataRow svInfo = tkBus.GetThongTinSinhVien(maTK); // Truyền MaTK

                if (svInfo != null)
                {
                    // Lấy dữ liệu
                    string tenSV = svInfo["HoTen"].ToString();
                    string ngaySinh = Convert.ToDateTime(svInfo["NgaySinh"]).ToShortDateString();
                    string gioiTinh = svInfo["GioiTinh"].ToString();

                    // Hiển thị ở cột bên trái (Thông tin sinh viên)
                    lbHello.Text = $"CHÀO MỪNG {tenSV.ToUpper()}";
                    lblMaSV.Text = "Mã sinh viên: " + svInfo["MaSV"].ToString(); // Lấy MaSV từ bảng SINHVIEN
                    lblTenSV.Text = "Tên sinh viên: " + tenSV;
                    lblNgaySinh.Text = "Ngày sinh: " + ngaySinh;
                    lblNoiSinh.Text = "Nơi sinh: " + svInfo["NoiSinh"].ToString();
                    lblGioiTinh.Text = "Giới tính: " + gioiTinh;

                    // Hiển thị ở cột bên phải (Thông tin học vấn)
                    lblLop.Text = "Lớp: " + svInfo["Lop"].ToString();
                    lblMaKhoa.Text = "Mã khoa: " + svInfo["MaKhoa"].ToString();
                    lblTenKhoa.Text = "Tên khoa: " + svInfo["TenKhoa"].ToString(); // Lấy MaTK từ Session
                }
                else
                {
                    lbHello.Text = $"CHÀO MỪNG {SessionManager.CurrentUsername}";
                    MessageBox.Show("Không tìm thấy thông tin chi tiết sinh viên!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearStudentInfo();
                }
            }
        }

        // ⭐ Phương thức xóa thông tin chi tiết sinh viên
        private void ClearStudentInfo()
        {
            // Reset tất cả các label chi tiết về trạng thái ban đầu (hoặc rỗng)
            lblMaSV.Text = "Mã sinh viên:";
            lblTenSV.Text = "Tên sinh viên:";
            lblNgaySinh.Text = "Ngày sinh:";
            lblNoiSinh.Text = "Nơi sinh:";
            lblGioiTinh.Text = "Giới tính:";

            lblLop.Text = "Lớp:";
            lblMaKhoa.Text = "Mã khoa:";
            lblTenKhoa.Text = "Tên khoa:";
        }

        private void gBHocVan_Enter(object sender, EventArgs e)
        {

        }
    }
}
