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
    public partial class Uc_HocPhanSinhVien : UserControl
    {
        private string CurrentMaSV => SessionManager.IsStudent() ? SessionManager.CurrentMaTK : null;

        // DataTable để lưu trữ dữ liệu gốc, tiện cho việc tìm kiếm
        private DataTable _dtHocPhan;
        public Uc_HocPhanSinhVien()
        {
            InitializeComponent();
            this.Load += Uc_HocPhanSinhVien_Load;
            btnTim.Click += btnTim_Click;
            btnReset.Click += btnReset_Click;

            // Cài đặt TextBox tìm kiếm để có thể nhấn Enter
            txtTim.KeyDown += txtTim_KeyDown;
        }
        private void Uc_HocPhanSinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentMaSV))
            {
                MessageBox.Show("Mã Sinh viên không hợp lệ.", "Lỗi truy cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. Tải thông tin SV lên Header
            LoadSinhVienHeader();

            // 2. Tải danh sách học phần lần đầu
            LoadDanhSachHocPhan();
        }

        // Hàm để tải thông tin MaSV, TenSV, Lop lên các TextBox phía trên
        private void LoadSinhVienHeader()
        {
            try
            {
                // Giả định bạn có hàm GetSinhVienInfo trong SinhVienDAL (đã code ở trên)
                SinhVienInfo svInfo = SinhVienInfoDAL.GetSinhVienInfo(CurrentMaSV);

                if (svInfo != null)
                {
                    txtMaSV.Text = svInfo.MaSV;
                    txtTenSV.Text = svInfo.HoTen;
                    txtLop.Text = svInfo.Lop;

                    // Khóa các trường Header
                    txtMaSV.ReadOnly = true;
                    txtTenSV.ReadOnly = true;
                    txtLop.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm chính để tải dữ liệu vào DataGridView
        private void LoadDanhSachHocPhan(string keyword = null)
        {
            try
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    _dtHocPhan = HocPhanDAL.GetHocPhanByMaSV(CurrentMaSV);
                }
                else
                {
                    _dtHocPhan = HocPhanDAL.TimKiemHocPhanByMaSV(CurrentMaSV, keyword);
                }

                dgvHocPhan.DataSource = _dtHocPhan;

                // ⭐ Thiết lập lại tên cột hiển thị (tùy chọn)
                SetupDataGridViewColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách học phần: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cấu hình DataGridView
        private void SetupDataGridViewColumns()
        {
            if (dgvHocPhan.Columns.Contains("MaHP"))
                dgvHocPhan.Columns["MaHP"].HeaderText = "Mã Học Phần";
            if (dgvHocPhan.Columns.Contains("TenHP"))
                dgvHocPhan.Columns["TenHP"].HeaderText = "Tên Học Phần";
            if (dgvHocPhan.Columns.Contains("SoTin"))
                dgvHocPhan.Columns["SoTin"].HeaderText = "Số Tín Chỉ";
            if (dgvHocPhan.Columns.Contains("HocKy"))
                dgvHocPhan.Columns["HocKy"].HeaderText = "Học Kỳ";
            if (dgvHocPhan.Columns.Contains("NamHoc"))
                dgvHocPhan.Columns["NamHoc"].HeaderText = "Năm Học";
            if (dgvHocPhan.Columns.Contains("MaKhoa"))
                dgvHocPhan.Columns["MaKhoa"].HeaderText = "Mã Khoa";

            // Tùy chỉnh chiều rộng, ví dụ:
            dgvHocPhan.Columns["MaHP"].Width = 100;
            dgvHocPhan.Columns["TenHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // 1. Xóa nội dung tìm kiếm
            txtTim.Text = string.Empty;

            // 2. Tải lại toàn bộ danh sách học phần (keyword = null)
            LoadDanhSachHocPhan();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();
            LoadDanhSachHocPhan(keyword);
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e);
                e.SuppressKeyPress = true; // Ngăn tiếng 'ding' khi nhấn Enter
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lBLop_Click(object sender, EventArgs e)
        {

        }

        private void lBIntro_Click(object sender, EventArgs e)
        {

        }

        private void LBTenSinhVien_Click(object sender, EventArgs e)
        {

        }
    }
}
