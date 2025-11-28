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
    public partial class Uc_KhoaAdmin : UserControl
    {
        private string selectedTenKhoa = "";

        public Uc_KhoaAdmin()
        {
            InitializeComponent();
            this.Load += LayTatCaKhoa_Load;
            SetStateDefault();
        }

        private void LayTatCaKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                dgvKhoa.AllowUserToAddRows = false;
                DataTable dt = KhoaDAL.GetTatCaKhoa();
                dgvKhoa.DataSource = dt;

                // Đặt tên Header
                dgvKhoa.Columns["MaKhoa"].HeaderText = "Mã Khoa";
                dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên Khoa";

                // Cột không cho phép chỉnh sửa trực tiếp trên DGV
                dgvKhoa.ReadOnly = true;
                dgvKhoa.Columns["MaKhoa"].ReadOnly = true;

                dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu Khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức hỗ trợ thay đổi trạng thái nút (Giả định có các Button btnSua, btnXoa, btnTim)
        private void SetButtonDisable(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
        private void SetButtonEnable(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(21, 101, 192); // Màu xanh dương
            btn.ForeColor = Color.White;
        }
        private void SetStateDefault()
        {
            SetButtonEnable(btnThem);
            SetButtonEnable(btnTim);
            SetButtonDisable(btnSua);
            SetButtonDisable(btnXoa);
        }
        private void SetStateSelected()
        {
            SetButtonDisable(btnThem);
            SetButtonDisable(btnTim);
            SetButtonEnable(btnSua);
            SetButtonEnable(btnXoa);
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvKhoa.Rows.Count)
                {
                    DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];

                    string maKhoa = row.Cells["MaKhoa"]?.Value?.ToString() ?? "";
                    string tenKhoa = row.Cells["TenKhoa"]?.Value?.ToString() ?? "";

                    selectedTenKhoa = tenKhoa;

                    txtMaKhoa.Text = maKhoa;
                    txtTenKhoa.Text = tenKhoa;

                    // Mã Khoa không cho sửa
                    txtMaKhoa.ReadOnly = true;

                    SetStateSelected();
                }
            }
            catch (Exception) { }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LayTatCaKhoa_Load(null, null);
            SetStateDefault();
            dgvKhoa.ClearSelection();
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();

            selectedTenKhoa = "";
            txtMaKhoa.ReadOnly = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string tenKhoaMoi = txtTenKhoa.Text.Trim();

            // 1. Kiểm tra rỗng bắt buộc và đã chọn
            if (string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng chọn hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tenKhoaMoi))
            {
                MessageBox.Show("Vui lòng nhập Tên Khoa mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Gọi DAL
            if (MessageBox.Show($"Bạn có chắc muốn đổi tên Khoa **{selectedTenKhoa}** thành **{tenKhoaMoi}** không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = KhoaDAL.SuaKhoa(maKhoa, tenKhoaMoi);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật Khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật Khoa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string tenKhoa = selectedTenKhoa;

            if (string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng chọn Khoa để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa Khoa **{tenKhoa}** (Mã: {maKhoa}) không? Thao tác này có thể ảnh hưởng đến dữ liệu liên quan (lớp, sinh viên).",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = KhoaDAL.XoaKhoa(maKhoa);
                    if (success)
                    {
                        MessageBox.Show("Xóa Khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Khoa thất bại! (Có thể do ràng buộc khóa ngoại).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa Khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchMaKhoa = txtMaKhoa.Text.Trim();
            string searchTenKhoa = txtTenKhoa.Text.Trim();

            if (string.IsNullOrEmpty(searchMaKhoa) && string.IsNullOrEmpty(searchTenKhoa))
            {
                MessageBox.Show("Vui lòng nhập Mã Khoa hoặc Tên Khoa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayTatCaKhoa_Load(null, null);
                return;
            }
            try
            {
                DataTable dt = KhoaDAL.TimKhoa(searchMaKhoa, searchTenKhoa);
                dgvKhoa.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy Khoa nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void label2_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvKhoa.ClearSelection();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvKhoa.ClearSelection();
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvKhoa.ClearSelection();
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvKhoa.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string tenKhoa = txtTenKhoa.Text.Trim();
            txtMaKhoa.ReadOnly = false;

            if (string.IsNullOrEmpty(maKhoa) || string.IsNullOrEmpty(tenKhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Khoa và Tên Khoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn thêm Khoa **{tenKhoa}** (Mã: {maKhoa}) không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = KhoaDAL.ThemKhoa(maKhoa, tenKhoa);
                    if (success)
                    {
                        MessageBox.Show("Thêm Khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Khoa thất bại! Vui lòng kiểm tra lại dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi trùng khóa chính từ DAL
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
