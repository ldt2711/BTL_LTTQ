using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Helpers;

namespace BTL_LTTQ.DAL
{
    internal class HocPhanDAL
    {
        // Hàm lấy tất cả học phần (dùng cho Load)
        public static DataTable GetTatCaHocPhan()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MaHP, TenHP, SoTin, TrongSoQT, TrongSoKTHP, HocKy, NamHoc FROM HOCPHAN";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static (decimal trongSoQT, decimal trongSoKTHP) GetTrongSo (string maHP)
        {
            decimal trongSoQT = 0.0m;
            decimal trongSoKTHP = 0.0m;

            if (string.IsNullOrEmpty(maHP))
            {
                // Trả về mặc định nếu mã HP rỗng
                return (trongSoQT, trongSoKTHP);
            }

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT TrongSoQT, TrongSoKTHP FROM HOCPHAN WHERE MaHP = @MaHP";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHP", maHP);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Kiểm tra và lấy giá trị (sử dụng GetDecimal và xử lý DBNull)
                                // Nếu giá trị là NULL trong DB, sẽ sử dụng giá trị mặc định (0.0m)
                                trongSoQT = reader.IsDBNull(0) ? 0.0m : reader.GetDecimal(0);
                                trongSoKTHP = reader.IsDBNull(1) ? 0.0m : reader.GetDecimal(1);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            // Trường hợp không tìm thấy MaHP, hàm trả về (0.0m, 0.0m)
            return (trongSoQT, trongSoKTHP);
        }

        // Hàm thêm Học phần
        public static bool ThemHocPhan(string maHP, string tenHP, int soTin, decimal trongSoQT, decimal trongSoKTHP, int hocKy, int namHoc)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO HOCPHAN (MaHP, TenHP, SoTin, TrongSoQT, TrongSoKTHP, HocKy, NamHoc)
                        VALUES (@MaHP, @TenHP, @SoTin, @TrongSoQT, @TrongSoKTHP, @HocKy, @NamHoc)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        cmd.Parameters.AddWithValue("@TenHP", tenHP);
                        // Sử dụng Add để chỉ định rõ kiểu dữ liệu cho số nguyên và số thực
                        cmd.Parameters.Add("@SoTin", SqlDbType.Int).Value = soTin;
                        cmd.Parameters.Add("@TrongSoQT", SqlDbType.Decimal).Value = trongSoQT;
                        cmd.Parameters.Add("@TrongSoKTHP", SqlDbType.Decimal).Value = trongSoKTHP;
                        cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = hocKy;
                        cmd.Parameters.Add("@NamHoc", SqlDbType.Int).Value = namHoc;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Hàm sửa Học phần
        public static bool SuaHocPhan(string maHP, string tenHP, int soTin, decimal trongSoQT, decimal trongSoKTHP, int hocKy, int namHoc)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        UPDATE HOCPHAN SET 
                        TenHP = @TenHP, 
                        SoTin = @SoTin, 
                        TrongSoQT = @TrongSoQT, 
                        TrongSoKTHP = @TrongSoKTHP, 
                        HocKy = @HocKy, 
                        NamHoc = @NamHoc
                        WHERE MaHP = @MaHP";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        cmd.Parameters.AddWithValue("@TenHP", tenHP);
                        cmd.Parameters.Add("@SoTin", SqlDbType.Int).Value = soTin;
                        cmd.Parameters.Add("@TrongSoQT", SqlDbType.Decimal).Value = trongSoQT;
                        cmd.Parameters.Add("@TrongSoKTHP", SqlDbType.Decimal).Value = trongSoKTHP;
                        cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = hocKy;
                        cmd.Parameters.Add("@NamHoc", SqlDbType.Int).Value = namHoc;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Hàm xóa Học phần
        public static bool XoaHocPhan(string maHP)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    // Lưu ý: Nếu bảng HOCPHAN có khóa ngoại (Foreign Key) sang các bảng khác (VD: DIEM),
                    // bạn cần xóa dữ liệu ở các bảng liên quan trước hoặc đảm bảo khóa ngoại không bị ràng buộc.
                    string query = "DELETE FROM HOCPHAN WHERE MaHP = @MaHP";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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

        // Hàm tìm kiếm Học phần
        public static DataTable TimHocPhan(Dictionary<string, string> filters)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT MaHP, TenHP, SoTin, TrongSoQT, TrongSoKTHP, HocKy, NamHoc FROM HOCPHAN WHERE 1=1";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                int i = 0;
                foreach (var item in filters)
                {
                    string field = item.Key;
                    string value = item.Value;
                    string param = "@param" + i;

                    if (string.IsNullOrWhiteSpace(value)) continue;

                    // Các trường số (int, decimal) -> dùng so sánh bằng (=)
                    if (field == "SoTin" || field == "TrongSoQT" || field == "TrongSoKTHP" || field == "HocKy" || field == "NamHoc")
                    {
                        query += $" AND {field} = {param}";

                        if (field == "SoTin" || field == "HocKy" || field == "NamHoc")
                        {
                            cmd.Parameters.Add(param, SqlDbType.Int).Value = int.Parse(value);
                        }
                        else // TrongSoQT, TrongSoKTHP (decimal)
                        {
                            // Cần đảm bảo sử dụng dấu chấm thập phân (CultureInfo.InvariantCulture)
                            if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal decimalValue))
                            {
                                cmd.Parameters.Add(param, SqlDbType.Decimal).Value = decimalValue;
                            }
                            else
                            {
                                // Bỏ qua nếu giá trị số không hợp lệ
                                continue;
                            }
                        }
                    }
                    // Các trường chuỗi (MaHP, TenHP) -> dùng LIKE
                    else
                    {
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
        public static (string tenSV, string lop, string maKhoa) GetThongTinCoBanSV(string maSV)
        {
            string tenSV = "";
            string lop = "";
            string maKhoa = "";

            if (string.IsNullOrEmpty(maSV)) return (tenSV, lop, maKhoa);

            string query = "SELECT HoTen, Lop FROM SINHVIEN WHERE MaSV = @MaSV";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tenSV = reader["HoTen"].ToString();
                            lop = reader["Lop"].ToString();
                            maKhoa = reader["MaKhoa"].ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    // Có thể log lỗi nếu cần
                }
            }
            return (tenSV, lop, maKhoa);
        }

        // -------------------------------------------------------------------
        // ⭐ HÀM BỔ SUNG CHO SINH VIÊN (LẤY DANH SÁCH HỌC PHẦN LIÊN QUAN)
        // Lấy tất cả học phần, nhưng chỉ những học phần thuộc MaKhoa của sinh viên
        // -------------------------------------------------------------------
        public static DataTable GetHocPhanByMaSV(string maSV)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                // JOIN BANGDIEM để lọc ra các MaHP duy nhất mà MaSV đã học
                string query = @"
                SELECT DISTINCT
                    HP.MaHP, 
                    HP.TenHP, 
                    HP.SoTin, 
                    HP.TrongSoQT, 
                    HP.TrongSoKTHP, 
                    HP.HocKy, 
                    HP.NamHoc 
                FROM BANGDIEM BD
                JOIN HOCPHAN HP ON BD.MaHP = HP.MaHP
                WHERE BD.MaSV = @MaSV
                ORDER BY HP.NamHoc DESC, HP.HocKy DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // -------------------------------------------------------------------
        // ⭐ HÀM BỔ SUNG CHO SINH VIÊN (TÌM KIẾM THEO TÊN/MÃ TRONG DANH SÁCH HP LIÊN QUAN)
        // -------------------------------------------------------------------
        public static DataTable TimKiemHocPhanByMaSV(string maSV, string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                // Nếu không có từ khóa, gọi hàm lấy tất cả học phần đã học
                return GetHocPhanByMaSV(maSV);
            }

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                // Lọc bằng cách JOIN BANGDIEM VÀ dùng LIKE trên MaHP/TenHP
                string query = @"
                SELECT DISTINCT
                    HP.MaHP, 
                    HP.TenHP, 
                    HP.SoTin, 
                    HP.TrongSoQT, 
                    HP.TrongSoKTHP, 
                    HP.HocKy, 
                    HP.NamHoc 
                FROM BANGDIEM BD
                JOIN HOCPHAN HP ON BD.MaHP = HP.MaHP
                WHERE BD.MaSV = @MaSV 
                  AND (HP.MaHP LIKE @Keyword OR HP.TenHP LIKE @Keyword)
                ORDER BY HP.NamHoc DESC, HP.HocKy DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
