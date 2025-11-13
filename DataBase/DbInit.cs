using System.Data.SqlClient;

namespace WinFormsApp.Helpers
{
    public static class DbInit
    {
        public static void CreateTables()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string sql = @"
                CREATE TABLE TTTAIKHOAN (
                    MaTK CHAR(10) NOT NULL PRIMARY KEY,
                    TaiKhoan NVARCHAR(50),
                    MatKhau NVARCHAR(20),
                    Loai INT NOT NULL
                );

                CREATE TABLE KHOA (
                    MaKhoa CHAR(5) NOT NULL PRIMARY KEY,
                    TenKhoa NVARCHAR(20)
                );

                CREATE TABLE HOCPHAN (
                    MaHP NVARCHAR(20) NOT NULL PRIMARY KEY,
                    TenHP NVARCHAR(100),
                    SoTin INT,
                    TrongSoQT FLOAT,
                    TrongSoKTHP FLOAT,
                    HocKy INT,
                    NamHoc INT
                );

                CREATE TABLE SINHVIEN (
                    MaSV CHAR(10) NOT NULL PRIMARY KEY,
                    HoTen NVARCHAR(30) NOT NULL,
                    NgaySinh DATE,
                    NoiSinh NVARCHAR(20),
                    GioiTinh NVARCHAR(10),
                    Lop NVARCHAR(20),
                    MaKhoa CHAR(5),
                    MaTK CHAR(10),
                    FOREIGN KEY (MaKhoa) REFERENCES KHOA(MaKhoa),
                    FOREIGN KEY (MaTK) REFERENCES TTTAIKHOAN(MaTK)
                );

                CREATE TABLE BANGDIEM (
                    MaSV CHAR(10),
                    MaHP NVARCHAR(20),
                    DiemQT FLOAT,
                    DiemKTHP FLOAT,
                    FOREIGN KEY (MaSV) REFERENCES SINHVIEN(MaSV),
                    FOREIGN KEY (MaHP) REFERENCES HOCPHAN(MaHP)
                );";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
