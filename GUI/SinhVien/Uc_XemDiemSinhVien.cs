using BTL_LTTQ.BUS;
using BTL_LTTQ.DAL; 
using ClosedXML.Excel;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp.Helpers;

namespace BTL_LTTQ.GUI.SinhVien
{
    public partial class Uc_BangDiemSV : UserControl
    {
        // ⭐ KHÔNG CẦN KHỞI TẠO DiemBUS
        // private DiemBUS diemBus = new DiemBUS(); 

        // Lấy Mã Sinh viên từ Session đã lưu khi đăng nhập
        private string CurrentMaSV => SessionManager.IsStudent() ? SessionManager.CurrentMaTK : null;

        public Uc_BangDiemSV()
        {
            InitializeComponent();
            this.Load += Uc_BangDiemSV_Load;
        }

        private void Uc_BangDiemSV_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentMaSV))
            {
                MessageBox.Show("Chức năng chỉ dành cho Sinh viên.", "Lỗi truy cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadComboBoxData();
            SetupDataGridView();
            TraCuuDiem();
        }

        private void LoadComboBoxData()
        {
            string maSV = CurrentMaSV;
            if (string.IsNullOrEmpty(maSV)) return; // Thoát nếu không có MaSV

            // ⭐ GỌI CÁC HÀM MỚI CÓ LỌC THEO SINH VIÊN

            // 1. Load ComboBox Lớp (cbLop)
            DataTable dtLop = DiemDAL.GetDanhSachLopBySV(maSV); // ⭐ Dùng hàm mới
            LoadDistinctValuesToComboBox(cboLop, dtLop, "Lop", false); // Lớp không cần "Tất cả" vì mỗi SV chỉ có 1 lớp

            // 2. Load ComboBox Học phần (cbHocPhan)
            DataTable dtHP = DiemDAL.GetDanhSachHocPhanBySV(maSV); // ⭐ Dùng hàm mới
            LoadDistinctValuesToComboBox(cboHocPhan, dtHP, "MaHP", true);

            // 3. Load ComboBox Học kỳ (cbHocKy)
            DataTable dtHK = DiemDAL.GetDanhSachHocKyBySV(maSV); // ⭐ Dùng hàm mới
            LoadDistinctValuesToComboBox(cboHocKy, dtHK, "HocKy", true);

            // 4. Load ComboBox Năm học (cbNamHoc)
            DataTable dtNH = DiemDAL.GetDanhSachNamHocBySV(maSV); // ⭐ Dùng hàm mới
            LoadDistinctValuesToComboBox(cboNamHoc, dtNH, "NamHoc", true);
        }

        /// <summary>
        /// Hàm nội bộ thay thế DataHelper để gán dữ liệu cho ComboBox
        /// </summary>
        private void LoadDistinctValuesToComboBox(
            ComboBox cb,
            DataTable dt,
            string columnName, // Vì các hàm DAL trả về DataTable chỉ có 1 cột
            bool includeAllOption)
        {
            if (includeAllOption)
            {
                // Tạo một dòng "Tất cả"
                DataRow topRow = dt.NewRow();
                topRow[columnName] = "Tất cả";
                dt.Rows.InsertAt(topRow, 0);
            }

            // Gán trực tiếp DataSource
            cb.DataSource = dt;
            cb.DisplayMember = columnName;
            cb.ValueMember = columnName; // Sử dụng cột duy nhất làm cả Display và Value
        }

        private void SetupDataGridView()
        {
            dgvBangDiem.AutoGenerateColumns = true; // Set lại thành true cho đơn giản
            dgvBangDiem.ReadOnly = true;
            dgvBangDiem.AllowUserToAddRows = false;

            dgvBangDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuDiem();
        }

        private void TraCuuDiem()
        {
            if (string.IsNullOrEmpty(CurrentMaSV))
            {
                MessageBox.Show("Mã Sinh viên không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Lấy giá trị từ ComboBox
                // Giá trị của mục "Tất cả" sẽ là "Tất cả"
                string lop = cboLop.SelectedValue?.ToString() ?? "";
                string maHP = cboHocPhan.SelectedValue?.ToString() ?? "";
                string hocKy = cboHocKy.SelectedValue?.ToString() ?? "";
                string namHoc = cboNamHoc.SelectedValue?.ToString() ?? "";

                // ⭐ Đảm bảo truyền giá trị rỗng/null nếu là "Tất cả"
                if (lop == "Tất cả") lop = "";
                if (maHP == "Tất cả") maHP = "";
                if (hocKy == "Tất cả") hocKy = "";
                if (namHoc == "Tất cả") namHoc = "";


                DataTable dtBangDiem = DiemDAL.GetBangDiemByFilter(
                    CurrentMaSV, lop, maHP, hocKy, namHoc
                );

                dgvBangDiem.DataSource = dtBangDiem;

                if (dtBangDiem.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy điểm số nào phù hợp với tiêu chí tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tra cứu điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            if (dgvBangDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất báo cáo.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFile.FileName = $"BangDiem_{CurrentMaSV}_{DateTime.Now.ToString("yyyyMMdd")}.xlsx";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                XuatDataGridViewRaExcel(dgvBangDiem, saveFile.FileName, CurrentMaSV);
            }
        }

        // Hàm XuatDataGridViewRaExcel (Giữ nguyên)
        public void XuatDataGridViewRaExcel(DataGridView dgv, string filePath, string maSV)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Bảng Điểm");

                    // Thêm tiêu đề chung
                    worksheet.Cell(1, 1).Value = "BẢNG ĐIỂM SINH VIÊN";
                    worksheet.Range("A1:F1").Merge().Style.Font.Bold = true;
                    worksheet.Range("A1:F1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet.Cell(2, 1).Value = "Mã Sinh viên: " + maSV;

                    int startRow = 4; // Bắt đầu từ hàng 4

                    // Ghi header
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        worksheet.Cell(startRow, i + 1).Value = dgv.Columns[i].HeaderText;
                        worksheet.Cell(startRow, i + 1).Style.Font.Bold = true;
                    }

                    // Ghi dữ liệu
                    int rowExcel = startRow + 1;
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
                    workbook.SaveAs(filePath);
                }

                MessageBox.Show("Xuất Báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}