using BTL_LTTQ.DAL;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Helpers;

namespace BTL_LTTQ.GUI.Admin
{
    public partial class Uc_NhapDiemAdmin : UserControl
    {
        private string selectedTenSV = "";
        private string selectedTenHP = "";
        public Uc_NhapDiemAdmin()
        {
            InitializeComponent();
            try
            {
                // Chạy ngầm việc đồng bộ điểm trước khi load UI
                DiemDAL.DongBoDiemTongKet();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu việc đồng bộ không thành công
                MessageBox.Show("Lỗi đồng bộ điểm tổng kết ban đầu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Load += LayTatCaDiem_Load;
            SetStateDefault();
        }

        private void LayTatCaDiem_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDiem.AllowUserToAddRows = false;
                DataTable dt = DiemDAL.GetTatCaDiem();
                dgvDiem.DataSource = dt;

                // Đặt tên Header (Thêm TenSV và TenHP)
                dgvDiem.Columns["MaSV"].HeaderText = "Mã SV";
                dgvDiem.Columns["HoTen"].HeaderText = "Tên Sinh viên";
                dgvDiem.Columns["MaHP"].HeaderText = "Mã HP";
                dgvDiem.Columns["TenHP"].HeaderText = "Tên Học phần";
                dgvDiem.Columns["DiemQT"].HeaderText = "Điểm Quá trình";
                dgvDiem.Columns["DiemKTHP"].HeaderText = "Điểm KTHP";
                dgvDiem.Columns["DiemTongKet"].HeaderText = "Điểm Tổng kết";


                // ⭐ Đảm bảo cột Tên/Điểm không cho phép chỉnh sửa trực tiếp trên DGV
                dgvDiem.ReadOnly = true; // Chỉ cho phép chỉnh sửa qua các TextBox

                // Có thể hiện thị cột Mã nhưng set ReadOnly
                dgvDiem.Columns["MaSV"].ReadOnly = true;
                dgvDiem.Columns["MaHP"].ReadOnly = true;


                dgvDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetButtonDisable(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
        private void SetButtonEnable(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(21, 101, 192);
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

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDiem.Rows.Count)
                {
                    DataGridViewRow row = dgvDiem.Rows[e.RowIndex];

                    // ⭐ Lấy giá trị Mã ẩn và Tên hiển thị
                    selectedTenSV = row.Cells["HoTen"]?.Value?.ToString() ?? "";
                    selectedTenHP = row.Cells["TenHP"]?.Value?.ToString() ?? "";

                    txtMaSV.Text = row.Cells["MaSV"]?.Value?.ToString() ?? ""; // Hiển thị Tên SV (giả định txtMaSV là txtTenSV)
                    txtMaHP.Text = row.Cells["MaHP"]?.Value?.ToString() ?? ""; // Hiển thị Tên HP (giả định txtMaHP là txtTenHP)

                    // Vô hiệu hóa việc sửa Tên SV và Tên HP
                    txtMaSV.ReadOnly = true;
                    txtMaHP.ReadOnly = true;

                    // Gán điểm
                    txtDiemQT.Text = row.Cells["DiemQT"]?.Value?.ToString()?.Replace(',', '.');
                    txtDiemKTHP.Text = row.Cells["DiemKTHP"]?.Value?.ToString()?.Replace(',', '.');

                    SetStateSelected();
                }
            }
            catch (Exception) { }
        }



        private void lblTenHP_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LayTatCaDiem_Load(null, null);
            SetStateDefault();
            dgvDiem.ClearSelection();
            txtMaSV.Clear();
            txtMaHP.Clear();
            txtDiemQT.Clear();
            txtDiemKTHP.Clear();

            selectedTenSV = "";
            selectedTenHP = "";
            txtMaSV.ReadOnly = false;
            txtMaHP.ReadOnly = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maHP = txtMaHP.Text.Trim();
            string diemQTStr = txtDiemQT.Text.Trim().Replace(',', '.');
            string diemKTHPStr = txtDiemKTHP.Text.Trim().Replace(',', '.');

            // 1. Kiểm tra rỗng bắt buộc
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Mã HP.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra và chuyển đổi điểm
            if (!decimal.TryParse(diemQTStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal diemQT) || diemQT < 0 || diemQT > 10)
            {
                MessageBox.Show("Điểm Quá trình không hợp lệ (0-10).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(diemKTHPStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal diemKTHP) || diemKTHP < 0 || diemKTHP > 10)
            {
                MessageBox.Show("Điểm KTHP không hợp lệ (0-10).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Gọi DAL
            try
            {
                bool success = DiemDAL.ThemDiem(maSV, maHP, diemQT, diemKTHP);
                if (success)
                {
                    MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReset_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Thêm điểm thất bại! (Có thể Mã SV và Mã HP đã tồn tại).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maHP = txtMaHP.Text.Trim();

            string diemQTStr = txtDiemQT.Text.Trim().Replace(',', '.');
            string diemKTHPStr = txtDiemKTHP.Text.Trim().Replace(',', '.');

            // Kiểm tra Mã bắt buộc phải được chọn trước khi sửa
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Vui lòng chọn hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra và chuyển đổi điểm (tương tự Them)
            if (!decimal.TryParse(diemQTStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal diemQT) || diemQT < 0 || diemQT > 10)
            {
                MessageBox.Show("Điểm Quá trình không hợp lệ (0-10).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(diemKTHPStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal diemKTHP) || diemKTHP < 0 || diemKTHP > 10)
            {
                MessageBox.Show("Điểm KTHP không hợp lệ (0-10).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi DAL
            if (MessageBox.Show($"Bạn có chắc muốn cập nhật điểm của sinh viên {selectedTenSV} cho học phần {selectedTenHP} không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = DiemDAL.SuaDiem(maSV, maHP, diemQT, diemKTHP);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string tenSV = selectedTenSV;
            string tenHP = selectedTenHP;
            string maSV = txtMaSV.Text.Trim();
            string maHP = txtMaHP.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Vui lòng chọn điểm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa điểm của sinh viên {tenSV} cho học phần {tenHP} không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = DiemDAL.XoaDiem(maSV, maHP);
                    if (success)
                    {
                        MessageBox.Show("Xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchStringSV = txtMaSV.Text.Trim();
            string searchStringHP = txtMaHP.Text.Trim();

            if (string.IsNullOrEmpty(searchStringSV) && string.IsNullOrEmpty(searchStringHP))
            {
                MessageBox.Show("Vui lòng nhập Mã SV hoặc Mã HP để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayTatCaDiem_Load(null, null);
                return;
            }
            try
            {
                // DAL TimDiem đã được sửa để tìm kiếm theo cả Mã hoặc Tên
                DataTable dt = DiemDAL.TimDiem(searchStringSV, searchStringHP);
                dgvDiem.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy Điểm nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvDiem.ClearSelection();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvDiem.ClearSelection();
        }

        private void panelBottom_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvDiem.ClearSelection();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvDiem.ClearSelection();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFile.FileName = "DanhSachDiem.xlsx";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                XuatDataGridViewRaExcel(dgvDiem, saveFile.FileName);
            }
        }
        public void XuatDataGridViewRaExcel(DataGridView dgv, string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("DanhSachDiem"); // Đổi tên sheet

                    // Ghi header
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                        worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                    }

                    // Ghi dữ liệu
                    int rowExcel = 2;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int col = 0; col < dgv.Columns.Count; col++)
                            {
                                object cellValue = row.Cells[col].Value;
                                if (cellValue != null)
                                {
                                    worksheet.Cell(rowExcel, col + 1).Value = cellValue.ToString();
                                }
                            }
                            rowExcel++;
                        }
                    }

                    // Tự động điều chỉnh cột
                    worksheet.Columns().AdjustToContents();

                    // Lưu file
                    workbook.SaveAs(filePath);
                }

                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
