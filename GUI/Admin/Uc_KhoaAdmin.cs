using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAL;

namespace BTL_LTTQ.GUI.Admin
{
    public partial class Uc_KhoaAdmin : UserControl
    {
        public Uc_KhoaAdmin()
        {
            InitializeComponent();
            this.Load += Uc_ThongKeKhoa_Load;
        }
        private void Uc_ThongKeKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                dgKhoa.DataSource = ThongKeDAL.GetDanhSachKhoa();

                // Tùy chọn: đặt lại tên cột
                dgKhoa.Columns["MaKhoa"].HeaderText = "Mã Khoa";
                dgKhoa.Columns["TenKhoa"].HeaderText = "Tên Khoa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Khoa: " + ex.Message);
            }
        }
        private void Uc_ThongKeSinhVienTheoKhoa(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim(); // Lấy mã khoa từ TextBox

            if (string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng chọn một khoa trước khi hiển thị danh sách sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi hàm DAL đúng để lấy sinh viên theo khoa
                dgSinhVien.DataSource = ThongKeDAL.GetSinhVienTheoKhoa(maKhoa);

                // Tùy chỉnh tiêu đề cột
                dgSinhVien.Columns["MaSV"].HeaderText = "Mã SV";
                dgSinhVien.Columns["HoTen"].HeaderText = "Họ Tên";
                dgSinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgSinhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgSinhVien.Columns["NoiSinh"].HeaderText = "Nơi Sinh";
                dgSinhVien.Columns["Lop"].HeaderText = "Lớp";
                dgSinhVien.Columns["MaKhoa"].HeaderText = "Mã Khoa";
                dgSinhVien.Columns["MaTK"].HeaderText = "Mã TK";

                // Cho cột tự giãn đều
                dgSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgSinhVien.BackgroundColor = Color.White;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message);
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem click có hợp lệ không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgKhoa.Rows[e.RowIndex];

                // Gán giá trị từ hàng được chọn vào TextBox
                txtMaKhoa.Text = row.Cells["MaKhoa"].Value?.ToString();
                txtTenKhoa.Text = row.Cells["TenKhoa"].Value?.ToString();
            }
        }
    }
}
