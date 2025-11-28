using System;
using System.Data;
using System.Data.SqlClient;
using WinFormsApp.Helpers;

namespace BTL_LTTQ.DAL
{
    internal class KhoaDAL
    {
        private static DataTable ExecuteKhoaQuery(string whereClause, SqlCommand cmd)
        {
            string query = @"
            SELECT 
                MaKhoa, TenKhoa
            FROM KHOA
            " + whereClause + " ORDER BY MaKhoa";

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

        public static DataTable GetTatCaKhoa()
        {
            return ExecuteKhoaQuery("", new SqlCommand());
        }

        // ⭐ HÀM MỚI: Thêm Khoa
        public static bool ThemKhoa(string maKhoa, string tenKhoa)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO KHOA (MaKhoa, TenKhoa) VALUES (@MaKhoa, @TenKhoa)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                        cmd.Parameters.AddWithValue("@TenKhoa", tenKhoa);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Kiểm tra lỗi trùng khóa chính
                if (ex.Number == 2627) // Mã lỗi khóa chính trùng (SQL Server)
                {
                    throw new Exception("Lỗi: Mã Khoa đã tồn tại trong hệ thống.");
                }
                throw;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Hàm sửa Khoa (Update) - Giữ nguyên
        public static bool SuaKhoa(string maKhoa, string tenKhoaMoi)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                    UPDATE KHOA SET 
                    TenKhoa = @TenKhoaMoi
                    WHERE MaKhoa = @MaKhoa";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                        cmd.Parameters.AddWithValue("@TenKhoaMoi", tenKhoaMoi);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Hàm xóa Khoa (Delete) - Giữ nguyên
        public static bool XoaKhoa(string maKhoa)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM KHOA WHERE MaKhoa = @MaKhoa";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Hàm tìm kiếm Khoa - Giữ nguyên
        public static DataTable TimKhoa(string maKhoa, string tenKhoa)
        {
            string whereClause = "WHERE 1=1";
            SqlCommand cmd = new SqlCommand();

            if (!string.IsNullOrEmpty(maKhoa))
            {
                whereClause += " AND MaKhoa LIKE @MaKhoa";
                cmd.Parameters.AddWithValue("@MaKhoa", "%" + maKhoa + "%");
            }

            if (!string.IsNullOrEmpty(tenKhoa))
            {
                whereClause += " AND TenKhoa LIKE @TenKhoa";
                cmd.Parameters.AddWithValue("@TenKhoa", "%" + tenKhoa + "%");
            }

            return ExecuteKhoaQuery(whereClause, cmd);
        }
    }
}