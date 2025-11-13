using ClosedXML.Excel;
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
using WinFormsApp.Helpers;

namespace BTL_LTTQ.GUI.Admin
{
    public partial class Uc_NhapDiemAdmin : UserControl
    {
        public Uc_NhapDiemAdmin()
        {
            InitializeComponent();
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maHP = txtMaHP.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Vui lòng nhập MaSV và MaHP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    // 1️⃣ Lấy dữ liệu cho TextBox
                    string queryTextBox = @"
                        SELECT BD.DiemQT, BD.DiemKTHP, SV.HoTen, SV.Lop
                        FROM BANGDIEM BD
                        INNER JOIN SINHVIEN SV ON BD.MaSV = SV.MaSV
                        WHERE BD.MaSV = @MaSV AND BD.MaHP = @MaHP";

                    using (SqlCommand cmd = new SqlCommand(queryTextBox, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtDiemQT.Text = reader["DiemQT"].ToString();
                                txtDiemKTHP.Text = reader["DiemKTHP"].ToString();
                                txtTenSV.Text = reader["HoTen"].ToString();
                                txtLop.Text = reader["Lop"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy điểm cho MaSV và MaHP này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtDiemQT.Clear();
                                txtDiemKTHP.Clear();
                                txtTenSV.Clear();
                                txtLop.Clear();
                            }
                        }
                    }

                    // 2️⃣ Lấy dữ liệu cho DataGridView (chỉ 4 cột)
                    string queryGrid = @"
                        SELECT MaSV, MaHP, DiemQT, DiemKTHP
                        FROM BANGDIEM
                        WHERE MaSV = @MaSV";

                    using (SqlDataAdapter da = new SqlDataAdapter(queryGrid, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@MaSV", maSV);
                       

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgBangDiem.DataSource = dt;

                        // Tùy chỉnh header
                        dgBangDiem.Columns["MaSV"].HeaderText = "Mã SV";
                        dgBangDiem.Columns["MaHP"].HeaderText = "Mã HP";
                        dgBangDiem.Columns["DiemQT"].HeaderText = "Điểm QT";
                        dgBangDiem.Columns["DiemKTHP"].HeaderText = "Điểm KTHP";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maHP = txtMaHP.Text.Trim();
            string diemQTText = txtDiemQT.Text.Trim();
            string diemKTHPText = txtDiemKTHP.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maHP) ||
                string.IsNullOrEmpty(diemQTText) || string.IsNullOrEmpty(diemKTHPText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển điểm sang kiểu double
            if (!double.TryParse(diemQTText, out double diemQT) || !double.TryParse(diemKTHPText, out double diemKTHP))
            {
                MessageBox.Show("Điểm phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Kiểm tra xem bản ghi đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM BANGDIEM WHERE MaSV=@MaSV AND MaHP=@MaHP";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MaSV", maSV);
                        checkCmd.Parameters.AddWithValue("@MaHP", maHP);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Bản ghi này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Thêm bản ghi mới
                    string insertQuery = @"
                INSERT INTO BANGDIEM (MaSV, MaHP, DiemQT, DiemKTHP)
                VALUES (@MaSV, @MaHP, @DiemQT, @DiemKTHP)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        cmd.Parameters.AddWithValue("@DiemQT", diemQT);
                        cmd.Parameters.AddWithValue("@DiemKTHP", diemKTHP);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Có thể load lại DataGridView nếu cần
                        }
                        else
                        {
                            MessageBox.Show("Thêm bản ghi thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Xóa toàn bộ TextBox
            txtMaSV.Clear();
            txtMaHP.Clear();
            txtDiemQT.Clear();
            txtDiemKTHP.Clear();
            txtTenSV.Clear();
            txtLop.Clear();

            // Nếu muốn, đặt con trỏ về txtMaSV
            txtMaSV.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maHP = txtMaHP.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Vui lòng nhập MaSV và MaHP để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa điểm của sinh viên {maSV} môn {maHP} không?",
                                              "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                return;

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM BANGDIEM WHERE MaSV=@MaSV AND MaHP=@MaHP";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Xóa TextBox sau khi xóa dữ liệu
                            txtMaSV.Clear();
                            txtMaHP.Clear();
                            txtDiemQT.Clear();
                            txtDiemKTHP.Clear();
                            txtTenSV.Clear();
                            txtLop.Clear();

                            // Nếu có DataGridView, load lại dữ liệu
                            // LoadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Kiểm tra DataGridView có dữ liệu không
            if (dgBangDiem.Rows.Count == 0)
            {
                MessageBox.Show("Bảng không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveFile.FileName = "BangDiem.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable dt = new DataTable();

                        // Lấy dữ liệu từ DataGridView
                        foreach (DataGridViewColumn col in dgBangDiem.Columns)
                            dt.Columns.Add(col.HeaderText);

                        foreach (DataGridViewRow row in dgBangDiem.Rows)
                        {
                            if (row.IsNewRow) continue;
                            DataRow dr = dt.NewRow();
                            for (int i = 0; i < dgBangDiem.Columns.Count; i++)
                                dr[i] = row.Cells[i].Value?.ToString() ?? "";
                            dt.Rows.Add(dr);
                        }

                        // Tạo file Excel
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(dt, "BangDiem");
                            wb.SaveAs(saveFile.FileName);
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



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
