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
using WinFormsApp.DAL;

namespace BTL_LTTQ.GUI.Admin
{
    public partial class Uc_HocPhanAdmin : UserControl
    {
        public Uc_HocPhanAdmin()
        {
            this.Load += LayTatCaHocPhan_Load;
            InitializeComponent();
        }
        private void LayTatCaHocPhan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHocPhan.DataSource = LopHocDAL.GetTatCaHocPhan();

                // Tùy chỉnh hiển thị
                dgvHocPhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHocPhan.BackgroundColor = Color.White;

                dgvHocPhan.Columns["MaHP"].HeaderText = "Mã HP";
                dgvHocPhan.Columns["TenHP"].HeaderText = "Tên học phần";
                dgvHocPhan.Columns["SoTin"].HeaderText = "Số tín";
                dgvHocPhan.Columns["TrongSoQT"].HeaderText = "Trọng số điểm quá trình";
                dgvHocPhan.Columns["TrongSoKTHP"].HeaderText = "Trọng số điểm KTHP";
                dgvHocPhan.Columns["HocKy"].HeaderText = "Học kỳ";
                dgvHocPhan.Columns["NamHoc"].HeaderText = "Năm học";


            }
            catch (Exception ex)
            {

            }
        }
        private void dgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvHocPhan.Rows.Count)
                {
                    DataGridViewRow row = dgvHocPhan.Rows[e.RowIndex];

                    txtMaHP.Text = row.Cells["MaHP"]?.Value?.ToString() ?? "";
                    txtTenHP.Text = row.Cells["TenHP"]?.Value?.ToString() ?? "";
                    txtSoTinChi.Text = row.Cells["SoTin"]?.Value?.ToString() ?? "";
                    txtTrongSoQT.Text = row.Cells["TrongSoQT"]?.Value?.ToString() ?? "";

                    txtTrongSoKTHP.Text = row.Cells["TrongSoKTHP"]?.Value?.ToString() ?? "";
                    txtNamHoc.Text = row.Cells["NamHoc"]?.Value?.ToString() ?? "";
                    txtHocKy.Text = row.Cells["HocKy"]?.Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control
            string maHP = txtMaHP.Text.Trim();
            string tenHP = txtTenHP.Text.Trim();
            string trongSoKTHP = txtTrongSoKTHP.Text.Trim();
            string trongSoQT = txtTrongSoQT.Text.Trim();
            string soTinChi = txtSoTinChi.Text.Trim();
            string hocKy = txtHocKy.Text.Trim();
            string namHoc = txtNamHoc.Text.Trim();

            // Kiểm tra dữ liệu cơ bản
            if (string.IsNullOrEmpty(maHP) || string.IsNullOrEmpty(tenHP) || string.IsNullOrEmpty(soTinChi) || string.IsNullOrEmpty(trongSoKTHP) || string.IsNullOrEmpty(trongSoQT) || string.IsNullOrEmpty(hocKy) || string.IsNullOrEmpty(namHoc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //try
            //{
            //    bool success = SinhVien_CB_DAL.ThemSinhVienVaTaiKhoan(maSV, hoTen, ngaySinh, gioiTinh, noiSinh, lop, maKhoa);
            //    if (success)
            //    {
            //        MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //        // Reset các control
            //        btnReset_Click(null, null);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtMaHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {

        }
    }
}
