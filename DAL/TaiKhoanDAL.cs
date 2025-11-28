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
    internal class TaiKhoanDAL
    {
        public DataRow CheckLogin(string username, string password)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                // Thay vì TTTAIKHOAN, ta dùng tên bảng TAIKHOAN nếu TTTAIKHOAN là bảng view/temp
                // Giả định tên bảng là TTTAIKHOAN như bạn đã dùng
                string query = "SELECT MaTK, Loai, TaiKhoan, MatKhau FROM TTTAIKHOAN WHERE TaiKhoan = @user AND MatKhau = @pass";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@user", username);
                da.SelectCommand.Parameters.AddWithValue("@pass", password);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                    return null; // sai tài khoản hoặc mật khẩu

                return dt.Rows[0]; // Trả về dòng chứa MaTK và Loai
            }
        }
        private static DataTable ExecuteTaiKhoanQuery(string whereClause, SqlCommand cmd)
        {
            string query = @"
            SELECT 
                MaTK, 
                TaiKhoan, 
                Loai,
                CASE Loai
                    WHEN 0 THEN N'Admin'
                    WHEN 1 THEN N'Sinh viên'
                    ELSE N'Không xác định'
                END AS LoaiHienThi  -- <== Cột này chứa chữ để hiển thị trên DGV
            FROM TTTAIKHOAN
            " + whereClause + " ORDER BY MaTK";

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
        public static DataTable GetTatCaTaiKhoan()
        {
            return ExecuteTaiKhoanQuery("", new SqlCommand());
        }

        // ⭐ Hàm sửa Tài Khoản (Update) - Chỉ cho phép sửa Loại (0: Admin, 1: SV)
        public static bool SuaTaiKhoan(string maTK, string tenTK, int loai)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                    UPDATE TTTAIKHOAN SET 
                    TaiKhoan = @TaiKhoan,
                    Loai = @Loai
                    WHERE MaTK = @MaTK";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTK", maTK);
                        cmd.Parameters.AddWithValue("@Loai", loai);
                        cmd.Parameters.AddWithValue("@TaiKhoan", tenTK);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ⭐ Hàm xóa Tài Khoản (Delete)
        public static bool XoaTaiKhoan(string maTK)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM TTTAIKHOAN WHERE MaTK = @MaTK";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTK", maTK);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ⭐ Hàm tìm kiếm Tài Khoản
        public static DataTable TimTaiKhoan(string maTK, string taiKhoan)
        {
            string whereClause = "WHERE 1=1";
            SqlCommand cmd = new SqlCommand();

            if (!string.IsNullOrEmpty(maTK))
            {
                whereClause += " AND MaTK LIKE @MaTK";
                cmd.Parameters.AddWithValue("@MaTK", "%" + maTK + "%");
            }

            if (!string.IsNullOrEmpty(taiKhoan))
            {
                whereClause += " AND TaiKhoan LIKE @TaiKhoan";
                cmd.Parameters.AddWithValue("@TaiKhoan", "%" + taiKhoan + "%");
            }

            return ExecuteTaiKhoanQuery(whereClause, cmd);
        }
    }
}
