using BTL_LTTQ.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAL;
using WinFormsApp.Helpers;

namespace BTL_LTTQ.GUI.Admin
{
    public partial class Uc_SinhVienAdmin : UserControl
    {
        public Uc_SinhVienAdmin()
        {
            InitializeComponent();
            this.Load += LayTatCaSinhVien_Load;
            cmbKhoa.DataSource = ThongKeDAL.GetDanhSachKhoa();
            cmbKhoa.DisplayMember = "TenKhoa";  // Tên hiển thị
            cmbKhoa.ValueMember = "MaKhoa";     // Giá trị thực sự
            cmbKhoa.SelectedIndex = -1;         // ban đầu chưa chọn
        }

    

        private void LayTatCaSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                dgSinhVien.DataSource = ThongKeDAL.GetTatCaSinhVien();

                // Tùy chỉnh hiển thị
                dgSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgSinhVien.BackgroundColor = Color.White;

                dgSinhVien.Columns["MaSV"].HeaderText = "Mã SV";
                dgSinhVien.Columns["HoTen"].HeaderText = "Họ Tên";
                dgSinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgSinhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgSinhVien.Columns["NoiSinh"].HeaderText = "Nơi Sinh";
                dgSinhVien.Columns["Lop"].HeaderText = "Lớp";
                dgSinhVien.Columns["MaKhoa"].HeaderText = "Mã Khoa";
                dgSinhVien.Columns["MaTK"].HeaderText = "Mã TK";

               
            }
            catch (Exception ex)
            {
                
            }
        }
        private void dgSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgSinhVien.Rows.Count)
                {
                    DataGridViewRow row = dgSinhVien.Rows[e.RowIndex];

                    txtMaSV.Text = row.Cells["MaSV"]?.Value?.ToString() ?? "";
                    txtHoTen.Text = row.Cells["HoTen"]?.Value?.ToString() ?? "";
                    txtNoiSinh.Text = row.Cells["NoiSinh"]?.Value?.ToString() ?? "";
                    txtLop.Text = row.Cells["Lop"]?.Value?.ToString() ?? "";
                    
                    txtGioiTinh.Text = row.Cells["GioiTinh"]?.Value?.ToString() ?? "";

                    // DateTimePicker
                    if (DateTime.TryParse(row.Cells["NgaySinh"]?.Value?.ToString(), out DateTime ngaySinh))
                    {
                        dtpNgaySinh.Value = ngaySinh;
                    }

                    // ComboBox Khoa
                    string maKhoa = row.Cells["MaKhoa"]?.Value?.ToString();
                    if (!string.IsNullOrEmpty(maKhoa))
                    {
                        cmbKhoa.SelectedValue = maKhoa;
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Xóa TextBox
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtNoiSinh.Clear();
            txtLop.Clear();
            

            // Reset DateTimePicker về ngày hiện tại hoặc giá trị mặc định
            dtpNgaySinh.Value = DateTime.Now;

            // Reset ComboBox
            cmbKhoa.SelectedIndex = -1;

            // Nếu muốn reset DataGridView về tất cả sinh viên
            dgSinhVien.DataSource = ThongKeDAL.GetTatCaSinhVien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string noiSinh = txtNoiSinh.Text.Trim();
            string lop = txtLop.Text.Trim();
           
            string maKhoa = cmbKhoa.SelectedValue?.ToString();
            string gioiTinh = txtGioiTinh.Text.Trim(); // hoặc lấy từ RadioButton / ComboBox nếu có
            DateTime ngaySinh = dtpNgaySinh.Value;

            // Kiểm tra dữ liệu cơ bản
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc (Mã SV, Họ Tên, Khoa).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = SinhVien_CB_DAL.ThemSinhVienVaTaiKhoan(maSV, hoTen, ngaySinh, gioiTinh, noiSinh, lop, maKhoa);
                if (success)
                {
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   

                    // Reset các control
                    btnReset_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Xoa SInhVien
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {maSV} không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = SinhVien_CB_DAL.XoaSinhVienVaTaiKhoan(maSV);
                    if (success)
                    {
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Load lại DataGridView
                        dgSinhVien.DataSource = ThongKeDAL.GetTatCaSinhVien();

                        // Reset các control
                        btnReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = SinhVien_CB_DAL.SuaSinhVien(
                    maSV,
                    txtHoTen.Text.Trim(),
                    txtNoiSinh.Text.Trim(),
                    txtLop.Text.Trim(),
                    txtGioiTinh.Text.Trim(),
                    dtpNgaySinh.Value,
                    cmbKhoa.SelectedValue?.ToString()
                );

                if (success)
                {
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    

                    // Reset các control
                    btnReset_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Cập nhật sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTim.Text.Trim(); // txtTim là TextBox nhập từ khóa

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = SinhVien_CB_DAL.TimSinhVien(tuKhoa);
                if (dt.Rows.Count > 0)
                {
                    dgSinhVien.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgSinhVien.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
