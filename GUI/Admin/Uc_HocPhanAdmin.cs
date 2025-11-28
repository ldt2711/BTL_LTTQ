using BTL_LTTQ.DAL;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ.GUI.Admin
{
    public partial class Uc_HocPhanAdmin : UserControl
    {
        public Uc_HocPhanAdmin()
        {

            InitializeComponent();
            this.Load += LayTatCaHocPhan_Load;
            SetStateDefault();
        }
        private void LayTatCaHocPhan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHocPhan.DataSource = HocPhanDAL.GetTatCaHocPhan();


                dgvHocPhan.Columns["MaHP"].HeaderText = "Mã HP";
                dgvHocPhan.Columns["TenHP"].HeaderText = "Tên Học Phần";
                dgvHocPhan.Columns["SoTin"].HeaderText = "Số Tín";
                dgvHocPhan.Columns["TrongSoQT"].HeaderText = "Trọng Số Điểm Quá Trình";
                dgvHocPhan.Columns["TrongSoKTHP"].HeaderText = "Trọng Số Điểm KTHP";
                dgvHocPhan.Columns["HocKy"].HeaderText = "Học Kỳ";
                dgvHocPhan.Columns["NamHoc"].HeaderText = "Năm Học";
                // Tùy chỉnh hiển thị
                dgvHocPhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    txtHocKy.Text = row.Cells["HocKy"]?.Value?.ToString() ?? "";
                    txtNamHoc.Text = row.Cells["NamHoc"]?.Value?.ToString() ?? "";
                    SetStateSelected();
                }
            }
            catch (Exception ex) { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHP = txtMaHP.Text.Trim();

            if (string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Vui lòng chọn học phần để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa học phần {maHP} không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = HocPhanDAL.XoaHocPhan(maHP);
                    if (success)
                    {
                        MessageBox.Show("Xóa học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Load lại DataGridView
                        dgvHocPhan.DataSource = HocPhanDAL.GetTatCaHocPhan();

                        // Reset các control
                        btnReset_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa học phần thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa học phần: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFile.FileName = "DanhSachHocPhan.xlsx";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                XuatDataGridViewRaExcel(dgvHocPhan, saveFile.FileName);
            }
        }
        public void XuatDataGridViewRaExcel(DataGridView dgv, string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("DanhSachHocPhan"); // Đổi tên sheet

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
                                    // Nếu là DateTime, giữ định dạng ngày (Tuy nhiên Học phần không có cột DateTime)
                                    if (cellValue is DateTime dt)
                                        worksheet.Cell(rowExcel, col + 1).Value = dt;
                                    else
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaHP.Clear();
            txtHocKy.Clear();
            txtNamHoc.Clear();
            txtSoTinChi.Clear();
            txtTenHP.Clear();
            txtTrongSoKTHP.Clear();
            txtTrongSoQT.Clear();
            dgvHocPhan.DataSource = HocPhanDAL.GetTatCaHocPhan();
            SetStateDefault();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu
            string maHP = txtMaHP.Text.Trim();
            string tenHP = txtTenHP.Text.Trim();
            string soTinStr = txtSoTinChi.Text.Trim();
            string trongSoQTStr = txtTrongSoQT.Text.Trim();
            string trongSoKTHPStr = txtTrongSoKTHP.Text.Trim();
            string hocKyStr = txtHocKy.Text.Trim();
            string namHocStr = txtNamHoc.Text.Trim();

            // 1. Kiểm tra rỗng bắt buộc
            if (string.IsNullOrEmpty(maHP) || string.IsNullOrEmpty(tenHP) || string.IsNullOrEmpty(soTinStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã HP, Tên HP và Số Tín Chỉ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Chuyển đổi và Kiểm tra kiểu dữ liệu
            if (!int.TryParse(soTinStr, out int soTin) || soTin <= 0)
            {
                MessageBox.Show("Số Tín Chỉ phải là số nguyên dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sử dụng ConvertHelper (nếu bạn có) hoặc TryParse với CultureInfo.InvariantCulture
            if (!decimal.TryParse(trongSoQTStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal trongSoQT))
            {
                trongSoQT = 0; // Gán mặc định nếu không nhập hoặc sai định dạng
            }
            if (!decimal.TryParse(trongSoKTHPStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal trongSoKTHP))
            {
                decimal kq = 1.0m - trongSoQT;
                trongSoKTHP = (decimal)Math.Round(kq, 2);
            }

            if (!int.TryParse(hocKyStr, out int hocKy)) { 
                hocKy = 0;
            } else if (hocKy <= 0 || hocKy >= 25)
            {
                MessageBox.Show("Học Kỳ phải là số nguyên dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(namHocStr, out int namHoc)) { namHoc = 0; }
            else if (namHoc <= 2000 || namHoc >= 2100)
            {
                MessageBox.Show("Năm Học phải là số nguyên dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // 3. Kiểm tra tổng trọng số
            if (Math.Abs(trongSoQT + trongSoKTHP - 1.0m) > 0.000001m && Math.Abs(trongSoQT + trongSoKTHP - 0.0m) > 0.000001m)
            {
                MessageBox.Show("Tổng Trọng Số QT và KTHP phải bằng 1.", "Lỗi Logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Gọi DAL
            try
            {
                bool success = HocPhanDAL.ThemHocPhan(maHP, tenHP, soTin, trongSoQT, trongSoKTHP, hocKy, namHoc);
                if (success)
                {
                    MessageBox.Show("Thêm học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReset_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Thêm học phần thất bại! (Có thể Mã HP đã tồn tại).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHP = txtMaHP.Text.Trim();
            if (string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Vui lòng chọn học phần để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoTinChi.Text.Trim(), out int soTin) || soTin <= 0)
            {
                MessageBox.Show("Số Tín Chỉ phải là số nguyên dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal.TryParse(txtTrongSoQT.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal trongSoQT);
            decimal.TryParse(txtTrongSoKTHP.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal trongSoKTHP);

            if (Math.Abs(trongSoQT + trongSoKTHP - 1.0m) > 0.000001m && Math.Abs(trongSoQT + trongSoKTHP - 0.0m) > 0.000001m)
            {
                MessageBox.Show("Tổng Trọng Số QT và KTHP phải bằng 1.", "Lỗi Logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int.TryParse(txtHocKy.Text.Trim(), out int hocKy);
            int.TryParse(txtNamHoc.Text.Trim(), out int namHoc);

            try
            {
                bool success = HocPhanDAL.SuaHocPhan(
                    maHP,
                    txtTenHP.Text.Trim(),
                    soTin,
                    trongSoQT,
                    trongSoKTHP,
                    hocKy,
                    namHoc
                );

                if (success)
                {
                    MessageBox.Show("Cập nhật học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReset_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Cập nhật học phần thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var filters = new Dictionary<string, string>();

            // 1. Thêm các trường chuỗi/mã
            if (!string.IsNullOrEmpty(txtMaHP.Text.Trim()))
                filters["MaHP"] = txtMaHP.Text.Trim();

            if (!string.IsNullOrEmpty(txtTenHP.Text.Trim()))
                filters["TenHP"] = txtTenHP.Text.Trim();

            // 2. Thêm các trường số (chỉ thêm nếu chúng hợp lệ và được nhập)
            if (int.TryParse(txtSoTinChi.Text.Trim(), out int soTin) && soTin > 0)
                filters["SoTin"] = soTin.ToString();

            if (decimal.TryParse(txtTrongSoQT.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal trongSoQT))
            {
                filters["TrongSoQT"] = trongSoQT.ToString(CultureInfo.InvariantCulture);
            }

            if (decimal.TryParse(txtTrongSoKTHP.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal trongSoKTHP))
            {
                filters["TrongSoKTHP"] = trongSoKTHP.ToString(CultureInfo.InvariantCulture);
            }

            if (int.TryParse(txtHocKy.Text.Trim(), out int hocKy))
                filters["HocKy"] = hocKy.ToString();

            if (int.TryParse(txtNamHoc.Text.Trim(), out int namHoc))
                filters["NamHoc"] = namHoc.ToString();

            // Kiểm tra nếu không có bất kỳ bộ lọc nào
            if (filters.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayTatCaHocPhan_Load(null, null);
                return;
            }

            try
            {
                DataTable dt = HocPhanDAL.TimHocPhan(filters);
                dgvHocPhan.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy Học phần nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Trạng thái mặc định: Cho phép Thêm/Tìm, Vô hiệu hóa Sửa/Xóa
            SetButtonEnable(btnThem);
            SetButtonEnable(btnTim);
            SetButtonDisable(btnSua);
            SetButtonDisable(btnXoa);
        }

        private void SetStateSelected()
        {
            // Trạng thái khi chọn hàng: Vô hiệu hóa Thêm/Tìm, Cho phép Sửa/Xóa
            SetButtonDisable(btnThem);
            SetButtonDisable(btnTim);
            SetButtonEnable(btnSua);
            SetButtonEnable(btnXoa);
        }
        private void panelBottom_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvHocPhan.ClearSelection();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvHocPhan.ClearSelection();
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvHocPhan.ClearSelection();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            SetStateDefault();
            dgvHocPhan.ClearSelection();
        }
    }
}
