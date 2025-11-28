using BTL_LTTQ.DAL;
using ClosedXML.Excel;
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
    public partial class Uc_TKAdmin : UserControl
    {
        private string selectedTaiKhoan = "";
        public Uc_TKAdmin()
        {
            InitializeComponent();
            SetupComboBoxLoai();
            this.Load += LayTatCaTaiKhoan_Load;
            SetStateDefault();
        }
        private void SetupComboBoxLoai()
        {
            // Cấu hình ComboBox để gán giá trị số (Value) nhưng hiển thị chữ (Display)
            cboLoai.DataSource = new[]
            {
                new { Value = 0, Display = "Admin" },
                new { Value = 1, Display = "Sinh viên" }
            };
            cboLoai.DisplayMember = "Display";
            cboLoai.ValueMember = "Value";
            cboLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoai.SelectedIndex = -1;
        }

        private void LayTatCaTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTaiKhoan.AllowUserToAddRows = false;
                DataTable dt = TaiKhoanDAL.GetTatCaTaiKhoan();
                dgvTaiKhoan.DataSource = dt;

                // Đặt tên Header
                dgvTaiKhoan.Columns["MaTK"].HeaderText = "Mã TK";
                dgvTaiKhoan.Columns["TaiKhoan"].HeaderText = "Tên Tài khoản";

                // ⭐ Cột hiển thị chữ (Cột ảo từ DAL)
                dgvTaiKhoan.Columns["LoaiHienThi"].HeaderText = "Loại Tài khoản";

                // ⭐ Ẩn cột Loai (chứa 0/1) nhưng vẫn giữ để lấy dữ liệu khi click
                dgvTaiKhoan.Columns["Loai"].Visible = false;

                // Các cột không cho sửa
                dgvTaiKhoan.ReadOnly = true;
                dgvTaiKhoan.Columns["MaTK"].ReadOnly = true;
                dgvTaiKhoan.Columns["TaiKhoan"].ReadOnly = true;

                dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Không có nút Thêm trong UC này
            SetButtonEnable(btnTim);
            SetButtonDisable(btnSua);
            SetButtonDisable(btnXoa);
        }
        private void SetStateSelected()
        {
            SetButtonDisable(btnTim);
            SetButtonEnable(btnSua);
            SetButtonEnable(btnXoa);
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvTaiKhoan.Rows.Count)
                {
                    DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                    string maTK = row.Cells["MaTK"]?.Value?.ToString() ?? "";
                    string tenTK = row.Cells["TaiKhoan"]?.Value?.ToString() ?? "";

                    // ⭐ Lấy giá trị số (0 hoặc 1) từ cột Loai ẩn để gán vào ComboBox
                    int loaiInt = Convert.ToInt32(row.Cells["Loai"].Value);

                    selectedTaiKhoan = tenTK;

                    txtMaTK.Text = maTK;
                    txtTenTK.Text = tenTK;
                    cboLoai.SelectedValue = loaiInt;

                    txtMaTK.ReadOnly = true;

                    SetStateSelected();
                }
            }
            catch (Exception) { }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LayTatCaTaiKhoan_Load(null, null);
            SetStateDefault();
            dgvTaiKhoan.ClearSelection();
            txtMaTK.Clear();
            txtTenTK.Clear();
            cboLoai.SelectedIndex = -1;

            selectedTaiKhoan = "";
            txtMaTK.ReadOnly = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTK.Text.Trim();
            string tenTK = txtTenTK.Text.Trim();

            if (cboLoai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int loai = (int)cboLoai.SelectedValue;

            if (string.IsNullOrEmpty(maTK))
            {
                MessageBox.Show("Vui lòng chọn hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi DAL
            if (MessageBox.Show($"Bạn có chắc muốn cập nhật tài khoản của **{selectedTaiKhoan}** không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Truyền MaTK và giá trị số Loai
                    bool success = TaiKhoanDAL.SuaTaiKhoan(maTK, tenTK, loai);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string maTK = txtMaTK.Text.Trim();
            string tenTK = txtTenTK.Text.Trim();

            if (string.IsNullOrEmpty(maTK))
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa tài khoản **{tenTK}** không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = TaiKhoanDAL.XoaTaiKhoan(maTK);
                    if (success)
                    {
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchMaTK = txtMaTK.Text.Trim();
            string searchTenTK = txtTenTK.Text.Trim();

            if (string.IsNullOrEmpty(searchMaTK) && string.IsNullOrEmpty(searchTenTK))
            {
                MessageBox.Show("Vui lòng nhập Mã TK hoặc Tên Tài khoản để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayTatCaTaiKhoan_Load(null, null);
                return;
            }
            try
            {
                DataTable dt = TaiKhoanDAL.TimTaiKhoan(searchMaTK, searchTenTK);
                dgvTaiKhoan.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy Tài khoản nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Các hàm click không quan trọng khác để reset trạng thái
        private void tableLayoutPanel2_Click(object sender, EventArgs e) { SetStateDefault(); dgvTaiKhoan.ClearSelection(); }
        private void tableLayoutPanel1_Click(object sender, EventArgs e) { SetStateDefault(); dgvTaiKhoan.ClearSelection(); }
        private void panelBottom_Click(object sender, EventArgs e) { SetStateDefault(); dgvTaiKhoan.ClearSelection(); }
        private void lblTitle_Click(object sender, EventArgs e) { SetStateDefault(); dgvTaiKhoan.ClearSelection(); }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFile.FileName = "DanhSachTaiKhoan.xlsx";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                XuatDataGridViewRaExcel(dgvTaiKhoan, saveFile.FileName);
            }
        }
        // Hàm XuatDataGridViewRaExcel tương tự như file Diem
        public void XuatDataGridViewRaExcel(DataGridView dgv, string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("DanhSachTaiKhoan");
                    int excelColIndex = 1;

                    // Ghi header (chỉ những cột hiển thị)
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        if (dgv.Columns[i].Visible)
                        {
                            worksheet.Cell(1, excelColIndex).Value = dgv.Columns[i].HeaderText;
                            worksheet.Cell(1, excelColIndex).Style.Font.Bold = true;
                            excelColIndex++;
                        }
                    }

                    // Ghi dữ liệu
                    int rowExcel = 2;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            excelColIndex = 1; // Reset cột excel
                            for (int col = 0; col < dgv.Columns.Count; col++)
                            {
                                if (dgv.Columns[col].Visible) // Chỉ lấy các cột hiển thị
                                {
                                    object cellValue = row.Cells[col].Value;
                                    if (cellValue != null)
                                    {
                                        worksheet.Cell(rowExcel, excelColIndex).Value = cellValue.ToString();
                                    }
                                    excelColIndex++;
                                }
                            }
                            rowExcel++;
                        }
                    }

                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(filePath);

                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
