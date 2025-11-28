using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Helpers;

namespace BTL_LTTQ.DAL
{

    public class SinhVienInfo
    {
        // Thông tin từ bảng SINHVIEN
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string GioiTinh { get; set; }
        public string Lop { get; set; }
        public string MaKhoa { get; set; }

        // Thông tin từ bảng KHOA (để hiển thị tên)
        public string TenKhoa { get; set; }

        // Thông tin từ bảng TTTAIKHOAN
        public string MaTK {  get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
    }
    public static class SinhVienInfoDAL
    {
        // -------------------------------------------------------------------
        // ⭐ 1. HÀM LẤY THÔNG TIN CÁ NHÂN CỦA SINH VIÊN
        // -------------------------------------------------------------------
        public static SinhVienInfo GetSinhVienInfo(string maSV)
        {
            SinhVienInfo sv = null;
            string query = @"
            SELECT  
                SV.MaSV, SV.HoTen, SV.NgaySinh, SV.NoiSinh, 
                SV.GioiTinh, SV.Lop, SV.MaKhoa, K.TenKhoa,
                TK.MaTK, TK.TaiKhoan, TK.MatKhau -- ⭐ Lấy MaTK
            FROM SINHVIEN SV
            JOIN KHOA K ON SV.MaKhoa = K.MaKhoa
            -- ⭐ JOIN: Dùng MaTaiKhoan của SV = MaTK của TTTAIKHOAN
            JOIN TTTAIKHOAN TK ON SV.MaTK = TK.MaTK 
            WHERE SV.MaSV = @MaSV";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sv = new SinhVienInfo
                        {
                            // ... (Các trường SV giữ nguyên)
                            MaSV = reader["MaSV"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                            NoiSinh = reader["NoiSinh"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            Lop = reader["Lop"].ToString(),
                            MaKhoa = reader["MaKhoa"].ToString(),
                            TenKhoa = reader["TenKhoa"].ToString(),

                            // ⭐ Lấy MaTK mới
                            MaTK = reader["MaTK"].ToString(),
                            TenTaiKhoan = reader["TaiKhoan"].ToString(),
                            MatKhau = reader["MatKhau"].ToString()
                        };
                    }
                }
            }
            return sv;
        }

        // -------------------------------------------------------------------
        // ⭐ 2. HÀM CẬP NHẬT THÔNG TIN CÁ NHÂN CỦA SINH VIÊN
        // -------------------------------------------------------------------
        public static bool UpdateSinhVienInfo(string maSV, string noiSinh, string maTK, string tenTaiKhoanMoi, string matKhauMoi)
        {
            string updateSV = @"
            UPDATE SINHVIEN SET
                NoiSinh = @NoiSinh
            WHERE MaSV = @MaSV";

            // Cập nhật Tên Tài khoản và Mật khẩu trong TTTAIKHOAN
            string updateTK = @"
            UPDATE TTTAIKHOAN SET
                TaiKhoan = @TenTaiKhoanMoi,
                MatKhau = @MatKhauMoi
            WHERE MaTK = @MaTK"; // Lọc theo MaTK (Khóa chính)

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // 1. Cập nhật bảng SINHVIEN
                    using (SqlCommand cmdSV = new SqlCommand(updateSV, conn, transaction))
                    {
                        cmdSV.Parameters.AddWithValue("@MaSV", maSV);
                        cmdSV.Parameters.AddWithValue("@NoiSinh", noiSinh);
                        cmdSV.ExecuteNonQuery();
                    }

                    // 2. Cập nhật bảng TTTAIKHOAN (TaiKhoan và MatKhau)
                    using (SqlCommand cmdTK = new SqlCommand(updateTK, conn, transaction))
                    {
                        cmdTK.Parameters.AddWithValue("@MaTK", maTK);
                        cmdTK.Parameters.AddWithValue("@TenTaiKhoanMoi", tenTaiKhoanMoi);
                        cmdTK.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                        cmdTK.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}