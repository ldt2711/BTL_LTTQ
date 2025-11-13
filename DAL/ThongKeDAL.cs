using System;
using System.Data;
using System.Data.SqlClient;
using WinFormsApp.Helpers;

namespace WinFormsApp.DAL
{
    public class ThongKeDAL
    {
        public static DataTable GetDanhSachKhoa()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MaKhoa, TenKhoa FROM KHOA";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetDanhSachLop()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT DISTINCT Lop FROM SINHVIEN WHERE Lop IS NOT NULL";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetDanhSachHocKy()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT DISTINCT HocKy FROM HOCPHAN WHERE HocKy IS NOT NULL";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetDanhSachNamHoc()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT DISTINCT NamHoc FROM HOCPHAN WHERE NamHoc IS NOT NULL";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ✅ Hàm lấy thống kê GPA theo trọng số tín chỉ
        public static DataTable GetThongKeHocLuc(string filterType1, string value1, string filterType2, string value2)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        sv.MaSV, 
                        sv.HoTen,
                        SUM((bd.DiemQT * hp.TrongSoQT + bd.DiemKTHP * hp.TrongSoKTHP) * hp.SoTin) / SUM(hp.SoTin) AS GPA
                    FROM BANGDIEM bd
                    JOIN SINHVIEN sv ON bd.MaSV = sv.MaSV
                    JOIN HOCPHAN hp ON bd.MaHP = hp.MaHP
                    WHERE 1=1";

                // 🔹 Lọc theo loại 1 (Khoa hoặc Lớp)
                if (filterType1 == "Khoa")
                    query += " AND sv.MaKhoa = @val1";
                else if (filterType1 == "Lớp")
                    query += " AND sv.Lop = @val1";

                // 🔹 Lọc theo loại 2 (Học kỳ hoặc Năm học)
                if (filterType2 == "Học kỳ")
                    query += " AND hp.HocKy = @val2";
                else if (filterType2 == "Năm học")
                    query += " AND hp.NamHoc = @val2";

                query += " GROUP BY sv.MaSV, sv.HoTen";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@val1", value1);
                    cmd.Parameters.AddWithValue("@val2", value2);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
