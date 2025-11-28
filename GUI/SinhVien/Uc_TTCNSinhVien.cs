using BTL_LTTQ.BUS;
using BTL_LTTQ.DAL;
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
    public partial class Uc_TTCNSinhVien : UserControl
    {
        private string CurrentMaSV => SessionManager.IsStudent() ? SessionManager.CurrentMaTK : null;
        private SinhVienInfo _currentSVInfo; // Biến lưu trữ dữ liệu hiện tại
        public Uc_TTCNSinhVien()
        {
            InitializeComponent();
            this.Load += Uc_ThongTinCaNhan_Load;
            btnLuu.Click += btnLuu_Click;
        }

        private void Uc_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentMaSV))
            {
                MessageBox.Show("Mã Sinh viên không hợp lệ.", "Lỗi truy cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadSinhVienData();
        }

        private void LoadSinhVienData()
        {
            try
            {
                _currentSVInfo = SinhVienInfoDAL.GetSinhVienInfo(CurrentMaSV);
                txtMaSV.Text = _currentSVInfo.MaSV;
                txtHoTen.Text = _currentSVInfo.HoTen;
                dtpNgaySinh.Value = _currentSVInfo.NgaySinh; // Dùng Value cho DateTimePicker
                txtNoiSinh.Text = _currentSVInfo.NoiSinh;
                txtLop.Text = _currentSVInfo.Lop;
                txtKhoa.Text = _currentSVInfo.TenKhoa;
                txtTenTK.Text = _currentSVInfo.TenTaiKhoan;
                txtMK.Text = _currentSVInfo.MatKhau;

                if (_currentSVInfo != null)
                {
                    // Hiển thị dữ liệu lên Controls
                    txtMaSV.ReadOnly = true;
                    txtHoTen.ReadOnly = true;
                    dtpNgaySinh.Enabled = false;
                    txtLop.ReadOnly = true;
                    txtKhoa.ReadOnly = true;
                    radNam.Enabled = false;
                    radNu.Enabled = false;

                    // ⭐ CÁC TRƯỜNG ĐƯỢC PHÉP SỬA
                    txtNoiSinh.ReadOnly = false;
                    txtTenTK.ReadOnly = false;
                    txtMK.ReadOnly = false;

                    // Xử lý Giới tính
                    if (_currentSVInfo.GioiTinh == "Nam")
                        radNam.Checked = true;
                    else if (_currentSVInfo.GioiTinh == "Nữ")
                        radNu.Checked = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin Sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_currentSVInfo == null)
            {
                MessageBox.Show("Không có dữ liệu để lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ⭐ HỘP THOẠI XÁC NHẬN TRƯỚC KHI LƯU
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn cập nhật thông tin cá nhân và tài khoản không?",
                "Xác nhận cập nhật",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                // 1. Lấy giá trị mới từ các trường được phép sửa
                string newNoiSinh = txtNoiSinh.Text.Trim();
                string newTenTaiKhoan = txtTenTK.Text.Trim();
                string newMatKhau = txtMK.Text;

                // 2. Xác thực dữ liệu cơ bản
                if (string.IsNullOrEmpty(newNoiSinh) || string.IsNullOrEmpty(newTenTaiKhoan) || string.IsNullOrEmpty(newMatKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Nơi sinh, Tên Tài khoản và Mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Gọi hàm cập nhật
                bool success = SinhVienInfoDAL.UpdateSinhVienInfo(
                    CurrentMaSV,
                    newNoiSinh,
                    _currentSVInfo.MaTK, // Truyền Khóa chính MaTK
                    newTenTaiKhoan,
                    newMatKhau
                );

                if (success)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSinhVienData(); // Tải lại dữ liệu sau khi lưu thành công
                }
                else
                {
                    MessageBox.Show("Lỗi trong quá trình cập nhật thông tin. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // ⭐ NẾU NHẤN NO (KHÔNG): Tải lại dữ liệu ban đầu
                LoadSinhVienData();
                MessageBox.Show("Đã hủy cập nhật. Thông tin ban đầu đã được khôi phục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMaSV_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lblNoiSinh_Click(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void lblLop_Click(object sender, EventArgs e)
        {

        }

        private void txtLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoiSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
