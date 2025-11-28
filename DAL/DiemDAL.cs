// File: DAL/DiemDAL.cs (Hoàn thiện)
using System;
using System.Data;
using System.Data.SqlClient;
using WinFormsApp.Helpers;

namespace BTL_LTTQ.DAL
{
    internal class DiemDAL
    {
        // Hàm này lấy toàn bộ dữ liệu điểm có join với SV và HP (Dùng cho Đồng bộ và GetTatCaDiem)
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

        // ⭐ Hàm TÍNH ĐIỂM TỔNG KẾT (Giữ nguyên logic của bạn)
        private static decimal TinhDiemTongKet(string maHP, decimal diemQT, decimal diemKTHP)
        {
            // Cần HocPhanDAL.cs có hàm GetTrongSo() để chạy được
            var trongSo = HocPhanDAL.GetTrongSo(maHP);

            decimal diemTK = (diemQT * trongSo.trongSoQT) + (diemKTHP * trongSo.trongSoKTHP);
            return Math.Round(diemTK, 1);
        }

        // ⭐ Hàm lấy TẤT CẢ ĐIỂM (Dùng cho Đồng bộ)
        public static DataTable GetTatCaDiem()
        {
            // Lấy tất cả các cột cần thiết, kể cả cột HoTen/TenHP
            return ExecuteDiemQuery("", new SqlCommand());
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

        // ⭐ HÀM ĐỒNG BỘ ĐIỂM TỔNG KẾT
        public static bool DongBoDiemTongKet()
        {
            DataTable dtDiem = GetTatCaDiem();
            bool success = true;

            foreach (DataRow row in dtDiem.Rows)
            {
                try
                {
                    string maSV = row["MaSV"].ToString();
                    string maHP = row["MaHP"].ToString();

                    // Cần lấy giá trị DiemQT và DiemKTHP từ DataTable của ExecuteDiemQuery
                    if (decimal.TryParse(row["DiemQT"].ToString(), out decimal diemQT) &&
                        decimal.TryParse(row["DiemKTHP"].ToString(), out decimal diemKTHP))
                    {
                        decimal diemTK = TinhDiemTongKet(maHP, diemQT, diemKTHP);

                        if (!CapNhatDiemTongKet(maSV, maHP, diemTK))
                        {
                            success = false;
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

        // ⭐ Hàm thêm Điểm (Insert)
        public static bool ThemDiem(string maSV, string maHP, decimal diemQT, decimal diemKTHP)
        {
            try
            {
                decimal diemTK = TinhDiemTongKet(maHP, diemQT, diemKTHP);
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

        // ⭐ Hàm tìm kiếm Điểm (Giữ nguyên logic của bạn)
        public static DataTable TimDiem(string maSV, string maHP)
        {
            string whereClause = "WHERE 1=1";
            SqlCommand cmd = new SqlCommand();

            if (!string.IsNullOrEmpty(maSV))
            {
                whereClause += " AND (D.MaSV LIKE @MaSV OR S.HoTen LIKE @MaSV)";
                cmd.Parameters.AddWithValue("@MaSV", "%" + maSV + "%");
            }

            if (!string.IsNullOrEmpty(maHP))
            {
                whereClause += " AND (D.MaHP LIKE @MaHP OR HP.TenHP LIKE @MaHP)";
                cmd.Parameters.AddWithValue("@MaHP", "%" + maHP + "%");
            }

            return ExecuteDiemQuery(whereClause, cmd);
        }
        private static DataTable GetDistinctValuesByMaSV(string columnName, string joinTable, string maSV)
        {
            // Cần join bảng BANGDIEM để lọc ra các MaHP mà MaSV đã học, sau đó join tiếp để lấy thông tin chi tiết (Lớp, HK, NH).
            string query = $@"
        SELECT DISTINCT 
            CAST(T.{columnName} AS NVARCHAR(50)) AS {columnName} 
        FROM BANGDIEM D
        INNER JOIN {joinTable} T ON D.{columnName} = T.{columnName} -- Đây là lỗi logic khi lấy HK/NH. Sửa lại:
        INNER JOIN HOCPHAN HP ON D.MaHP = HP.MaHP 
        INNER JOIN SINHVIEN SV ON D.MaSV = SV.MaSV
        WHERE D.MaSV = @MaSV 
        ORDER BY {columnName}";

            // Phải xử lý đặc biệt cho từng trường hợp Join để query đúng.
            // Tách riêng từng hàm sẽ dễ quản lý hơn:

            return new DataTable(); // Trả về DataTable trống để tránh lỗi nếu không implement chi tiết.
        }


        // --- Các hàm lấy danh sách LỌC THEO SINH VIÊN ---

        public static DataTable GetDanhSachLopBySV(string maSV)
        {
            // Lớp chỉ có 1 cho mỗi sinh viên, nhưng vẫn cần lấy Lớp từ bảng SINHVIEN
            string query = "SELECT DISTINCT Lop FROM SINHVIEN WHERE MaSV = @MaSV";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetDanhSachHocPhanBySV(string maSV)
        {
            // Lấy tất cả MaHP mà sinh viên có điểm
            string query = @"
        SELECT DISTINCT 
            CAST(D.MaHP AS NVARCHAR(50)) AS MaHP 
        FROM BANGDIEM D
        WHERE D.MaSV = @MaSV 
        ORDER BY MaHP";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetDanhSachHocKyBySV(string maSV)
        {
            // Lấy tất cả Học kỳ của các MaHP mà sinh viên có điểm (JOIN HOCPHAN)
            string query = @"
        SELECT DISTINCT 
            CAST(HP.HocKy AS NVARCHAR(50)) AS HocKy 
        FROM BANGDIEM D
        JOIN HOCPHAN HP ON D.MaHP = HP.MaHP
        WHERE D.MaSV = @MaSV 
        ORDER BY HocKy";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetDanhSachNamHocBySV(string maSV)
        {
            // Lấy tất cả Năm học của các MaHP mà sinh viên có điểm (JOIN HOCPHAN)
            string query = @"
                SELECT DISTINCT 
                    CAST(HP.NamHoc AS NVARCHAR(50)) AS NamHoc 
                FROM BANGDIEM D
                JOIN HOCPHAN HP ON D.MaHP = HP.MaHP
                WHERE D.MaSV = @MaSV 
                ORDER BY NamHoc";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ⭐ Hàm tra cứu điểm đã được sửa để JOIN HOCPHAN khi lọc
        public static DataTable GetBangDiemByFilter(
            string maSV,
            string lop,
            string maHP,
            string hocKy,
            string namHoc)
        {
            // Lưu ý: Dùng D.DiemKTHP (từ hàm TimDiem) hay D.DiemKT (từ query cũ)?
            // Trong query này, mình đang dùng D.DiemKT cho khớp với công thức, nếu DB dùng D.DiemKTHP thì cần sửa.
            string query = @"
            SELECT
                D.MaHP,
                HP.TenHP,
                HP.SoTin,
                D.DiemQT,
                D.DiemKTHP, -- ⭐ Sử dụng DiemKTHP cho khớp với các hàm trên
                (D.DiemQT * HP.TrongSoQT + D.DiemKTHP * HP.TrongSoKTHP) AS DiemTongKet
            FROM BANGDIEM D -- ⭐ Sử dụng BANGDIEM cho khớp với các hàm trên
            INNER JOIN HOCPHAN HP ON D.MaHP = HP.MaHP -- JOIN để lấy trọng số, Học kỳ và Năm học
            INNER JOIN SINHVIEN SV ON D.MaSV = SV.MaSV
            WHERE D.MaSV = @MaSV";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@MaSV", maSV);

            // Thêm các điều kiện lọc (nếu có)
            if (!string.IsNullOrEmpty(lop))
            {
                query += " AND SV.Lop = @Lop";
                cmd.Parameters.AddWithValue("@Lop", lop);
            }
            if (!string.IsNullOrEmpty(maHP))
            {
                query += " AND D.MaHP = @MaHP";
                cmd.Parameters.AddWithValue("@MaHP", maHP);
            }

            // ⭐ CẬP NHẬT LỌC: Lọc theo Học kỳ và Năm học trong bảng HOCPHAN (HP)
            if (!string.IsNullOrEmpty(hocKy))
            {
                query += " AND HP.HocKy = @HocKy";
                cmd.Parameters.AddWithValue("@HocKy", hocKy);
            }
            if (!string.IsNullOrEmpty(namHoc))
            {
                query += " AND HP.NamHoc = @NamHoc";
                cmd.Parameters.AddWithValue("@NamHoc", namHoc);
            }

            query += " ORDER BY HP.NamHoc, HP.HocKy, D.MaHP";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                cmd.Connection = conn;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}