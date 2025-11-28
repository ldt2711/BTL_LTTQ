using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Helpers;

namespace BTL_LTTQ.DAL
{
    internal class DiemDAL
    {
        private static DataTable ExecuteDiemQuery(string whereClause, SqlCommand cmd)
        {
            string query = @"
            SELECT 
                D.MaSV, S.HoTen, 
                D.MaHP, HP.TenHP, 
                D.DiemQT, D.DiemKTHP, D.DiemTongKet
            FROM BANGDIEM D
            JOIN SINHVIEN S ON D.MaSV = S.MaSV
            JOIN HOCPHAN HP ON D.MaHP = HP.MaHP
            " + whereClause + " ORDER BY D.MaSV, D.MaHP";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                cmd.Connection = conn;
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static bool DongBoDiemTongKet()
        {
            DataTable dtDiem = GetTatCaDiem(); // Hàm này phải lấy cả MaSV, MaHP, DiemQT, DiemKTHP
            bool success = true;

            foreach (DataRow row in dtDiem.Rows)
            {
                try
                {
                    string maSV = row["MaSV"].ToString();
                    string maHP = row["MaHP"].ToString();

                    // Cần kiểm tra DBNull hoặc Parse lỗi
                    if (decimal.TryParse(row["DiemQT"].ToString(), out decimal diemQT) &&
                        decimal.TryParse(row["DiemKTHP"].ToString(), out decimal diemKTHP))
                    {
                        decimal diemTK = TinhDiemTongKet(maHP, diemQT, diemKTHP);

                        // Gọi hàm nội bộ để cập nhật
                        if (!CapNhatDiemTongKet(maSV, maHP, diemTK))
                        {
                            success = false; // Ghi nhận lỗi nhưng tiếp tục vòng lặp
                        }
                    }
                }
                catch (Exception)
                {
                    success = false;
                }
            }
            return success;
        }

        // ⭐ HÀM NỘI BỘ: Chỉ UPDATE cột DiemTongKet
        private static bool CapNhatDiemTongKet(string maSV, string maHP, decimal diemTK)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                    UPDATE BANGDIEM SET 
                    DiemTongKet = @DiemTongKet
                    WHERE MaSV = @MaSV AND MaHP = @MaHP";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        cmd.Parameters.Add("@DiemTongKet", SqlDbType.Decimal).Value = diemTK;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static DataTable GetTatCaDiem()
        {
            return ExecuteDiemQuery("", new SqlCommand());
        }
        private static decimal TinhDiemTongKet(string maHP, decimal diemQT, decimal diemKTHP)
        {
            var trongSo = HocPhanDAL.GetTrongSo(maHP);

            decimal diemTK = (diemQT * trongSo.trongSoQT) + (diemKTHP * trongSo.trongSoKTHP);
            return Math.Round(diemTK, 1);
        }

        // ⭐ Hàm thêm Điểm (Insert)
        public static bool ThemDiem(string maSV, string maHP, decimal diemQT, decimal diemKTHP)
        {
            try
            {
                decimal diemTK = TinhDiemTongKet(maHP, diemQT, diemKTHP); // TÍNH ĐIỂM
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                    INSERT INTO BANGDIEM (MaSV, MaHP, DiemQT, DiemKTHP, DiemTongKet)
                    VALUES (@MaSV, @MaHP, @DiemQT, @DiemKTHP, @DiemTongKet)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        cmd.Parameters.Add("@DiemQT", SqlDbType.Decimal).Value = diemQT;
                        cmd.Parameters.Add("@DiemKTHP", SqlDbType.Decimal).Value = diemKTHP;
                        cmd.Parameters.Add("@DiemTongKet", SqlDbType.Decimal).Value = diemTK;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) return false;
                throw;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ⭐ Hàm sửa Điểm (Update)
        public static bool SuaDiem(string maSV, string maHP, decimal diemQT, decimal diemKTHP)
        {
            try
            {
                decimal diemTK = TinhDiemTongKet(maHP, diemQT, diemKTHP);
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                    UPDATE BANGDIEM SET 
                    DiemQT = @DiemQT, 
                    DiemKTHP = @DiemKTHP,
                    DiemTongKet = @DiemTongKet
                    WHERE MaSV = @MaSV AND MaHP = @MaHP";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        cmd.Parameters.Add("@DiemQT", SqlDbType.Decimal).Value = diemQT;
                        cmd.Parameters.Add("@DiemKTHP", SqlDbType.Decimal).Value = diemKTHP;
                        cmd.Parameters.Add("@DiemTongKet", SqlDbType.Decimal).Value = diemTK; // Thêm tham số

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ⭐ Hàm xóa Điểm (Delete)
        public static bool XoaDiem(string maSV, string maHP)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM BANGDIEM WHERE MaSV = @MaSV AND MaHP = @MaHP";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ⭐ Hàm tìm kiếm Điểm
        public static DataTable TimDiem(string maSV, string maHP)
        {
            string whereClause = "WHERE 1=1";
            SqlCommand cmd = new SqlCommand();

            // Tìm theo Mã (vì Textbox trên UI vẫn là nơi nhập Mã để tìm kiếm)
            if (!string.IsNullOrEmpty(maSV))
            {
                // Thay đổi thành tìm kiếm theo Tên nếu muốn tìm kiếm theo Tên trên UI
                whereClause += " AND (D.MaSV LIKE @MaSV OR S.TenSV LIKE @MaSV)";
                cmd.Parameters.AddWithValue("@MaSV", "%" + maSV + "%");
            }

            if (!string.IsNullOrEmpty(maHP))
            {
                // Thay đổi thành tìm kiếm theo Tên nếu muốn tìm kiếm theo Tên trên UI
                whereClause += " AND (D.MaHP LIKE @MaHP OR HP.TenHP LIKE @MaHP)";
                cmd.Parameters.AddWithValue("@MaHP", "%" + maHP + "%");
            }

            return ExecuteDiemQuery(whereClause, cmd);
        }
    }
}
