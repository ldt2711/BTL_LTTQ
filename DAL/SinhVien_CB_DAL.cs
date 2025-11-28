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
    internal class SinhVien_CB_DAL
    {
        public DataRow GetThongTinSinhVienByMaTK(string maTK)
        {
            // Truy vấn lấy thông tin sinh viên và thông tin học vấn từ các bảng liên quan
            // Giả định bảng SINHVIEN có cột MaTK liên kết với TTTAIKHOAN
            string query = @"
            SELECT 
                SV.MaSV, SV.HoTen, SV.NgaySinh, SV.NoiSinh, SV.GioiTinh, 
                SV.Lop, 
                SV.MaKhoa, 
                K.TenKhoa,
                TK.MaTK, TK.TaiKhoan 
            FROM SINHVIEN SV
            INNER JOIN TTTAIKHOAN TK ON SV.MaTK = TK.MaTK
            INNER JOIN KHOA K ON SV.MaKhoa = K.MaKhoa -- ⭐ JOIN với bảng KHOA
            WHERE SV.MaTK = @MaTK"; // Lọc bằng MaTK của tài khoản đã đăng nhập

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaTK", maTK);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                    return null;

                return dt.Rows[0];
            }
        }
        public static bool ThemSinhVienVaTaiKhoan(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh,
                                          string noiSinh, string lop, string maKhoa)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1️⃣ Thêm Tài khoản trước
                    string queryTK = @"
                INSERT INTO TTTAIKHOAN
                (MaTK, TaiKhoan, MatKhau, Loai)
                VALUES
                (@MaTK, @TaiKhoan, @MatKhau, @Loai)";

                    using (SqlCommand cmdTK = new SqlCommand(queryTK, conn, transaction))
                    {
                        cmdTK.Parameters.AddWithValue("@MaTK", maSV);       // MaTK = MaSV
                        cmdTK.Parameters.AddWithValue("@TaiKhoan", maSV);   // dùng MaSV làm tài khoản
                        cmdTK.Parameters.AddWithValue("@MatKhau", "12345"); // mật khẩu mặc định
                        cmdTK.Parameters.AddWithValue("@Loai", 0);          // 0 = sinh viên
                        cmdTK.ExecuteNonQuery();
                    }

                    // 2️⃣ Thêm Sinh viên
                    string querySV = @"
                INSERT INTO SINHVIEN
                (MaSV, HoTen, NgaySinh, GioiTinh, NoiSinh, Lop, MaKhoa, MaTK)
                VALUES
                (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @NoiSinh, @Lop, @MaKhoa, @MaTK)";

                    using (SqlCommand cmdSV = new SqlCommand(querySV, conn, transaction))
                    {
                        cmdSV.Parameters.AddWithValue("@MaSV", maSV);
                        cmdSV.Parameters.AddWithValue("@HoTen", hoTen);
                        cmdSV.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmdSV.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmdSV.Parameters.AddWithValue("@NoiSinh", noiSinh);
                        cmdSV.Parameters.AddWithValue("@Lop", lop);
                        cmdSV.Parameters.AddWithValue("@MaKhoa", maKhoa);
                        cmdSV.Parameters.AddWithValue("@MaTK", maSV); // MaTK = MaSV
                        cmdSV.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public static bool XoaSinhVienVaTaiKhoan(string maSV)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1️⃣ Xóa Sinh viên trước
                    string querySV = "DELETE FROM SINHVIEN WHERE MaSV = @MaSV";
                    using (SqlCommand cmdSV = new SqlCommand(querySV, conn, transaction))
                    {
                        cmdSV.Parameters.AddWithValue("@MaSV", maSV);
                        cmdSV.ExecuteNonQuery();
                    }

                    // 2️⃣ Xóa TTTAIKHOAN
                    string queryTK = "DELETE FROM TTTAIKHOAN WHERE MaTK = @MaTK";
                    using (SqlCommand cmdTK = new SqlCommand(queryTK, conn, transaction))
                    {
                        cmdTK.Parameters.AddWithValue("@MaTK", maSV); // MaTK = MaSV
                        cmdTK.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        // Sửa thông tin sinh viên
        public static bool SuaSinhVien(string maSV, string hoTen, string noiSinh, string lop,
                                        string gioiTinh, DateTime ngaySinh, string maKhoa)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string query = @"UPDATE SINHVIEN 
                 SET HoTen = @HoTen,
                     NoiSinh = @NoiSinh,
                     Lop = @Lop,
                     GioiTinh = @GioiTinh,
                     NgaySinh = @NgaySinh,
                     MaKhoa = @MaKhoa
                 WHERE MaSV = @MaSV";

                    using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@NoiSinh", noiSinh);
                        cmd.Parameters.AddWithValue("@Lop", lop);

                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                        cmd.ExecuteNonQuery();
                    }
                    
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }


            }

        }
        public static DataTable TimSinhVien(Dictionary<string, string> filters)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM SINHVIEN WHERE 1=1";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                int i = 0;
                foreach (var item in filters)
                {
                    if (string.IsNullOrWhiteSpace(item.Value)) continue;

                    string field = item.Key;
                    string value = item.Value;
                    string param = "@param" + i;

                    // Nếu cột là DateTime -> so sánh theo ngày
                    if (field == "NgaySinh")
                    {
                        query += $" AND CONVERT(date, NgaySinh) = CONVERT(date, {param})";
                        cmd.Parameters.AddWithValue(param, DateTime.Parse(value));
                    }
                    else
                    {
                        // Các cột kiểu chuỗi -> dùng LIKE
                        query += $" AND {field} LIKE {param}";
                        cmd.Parameters.AddWithValue(param, "%" + value + "%");
                    }

                    i++;
                }

                cmd.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
