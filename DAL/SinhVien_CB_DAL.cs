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
        public static bool ThemSinhVien(
                string maSV, string hoTen, DateTime ngaySinh, string gioiTinh,
                string noiSinh, string lop, string maKhoa, string maTK)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
            INSERT INTO SINHVIEN
            (MaSV, HoTen, NgaySinh, GioiTinh, NoiSinh, Lop, MaKhoa, MaTK)
            VALUES
            (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @NoiSinh, @Lop, @MaKhoa, @MaTK)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSV);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@NoiSinh", noiSinh);
                    cmd.Parameters.AddWithValue("@Lop", lop);
                    cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                    cmd.Parameters.AddWithValue("@MaTK", maTK);

                    conn.Open();
                    int kq = cmd.ExecuteNonQuery();
                    return kq > 0;
                }
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
        public static DataTable TimSinhVien(string tuKhoa)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {

                string query = @"SELECT * FROM SINHVIEN 
                                 WHERE MaSV LIKE @TuKhoa OR HoTen LIKE @TuKhoa";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }




            
        }
    }
}
