using System.Data.SqlClient;

namespace WinFormsApp.Helpers
{
    public static class DbInit
    {
        public static void CreateDatabaseIfNotExists()
        {
            using (SqlConnection conn = DatabaseConnection.GetMasterConnection())
            {
                conn.Open();
                string query = $"IF DB_ID('{DatabaseConnection.DatabaseName}') IS NULL CREATE DATABASE [{DatabaseConnection.DatabaseName}]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void CreateTablesIfNotExists()
        {
            using (SqlConnection conn = DatabaseConnection.GetDbConnection())
            {
                conn.Open();

                string query = @"
                IF OBJECT_ID('KHOA','U') IS NULL
                CREATE TABLE KHOA (
                    MaKhoa CHAR(5) PRIMARY KEY,
                    TenKhoa NVARCHAR(20)
                );

                IF OBJECT_ID('TTTAIKHOAN','U') IS NULL
                CREATE TABLE TTTAIKHOAN (
                    MaTK CHAR(10) PRIMARY KEY,
                    TaiKhoan NVARCHAR(50),
                    MatKhau NVARCHAR(20),
                    Loai INT NOT NULL
                );

                IF OBJECT_ID('HOCPHAN','U') IS NULL
                CREATE TABLE HOCPHAN (
                    MaHP NVARCHAR(20) PRIMARY KEY,
                    TenHP NVARCHAR(100),
                    SoTin INT,
                    TrongSoQT FLOAT,
                    TrongSoKTHP FLOAT
                );

                IF OBJECT_ID('SINHVIEN','U') IS NULL
                CREATE TABLE SINHVIEN (
                    MaSV CHAR(10) PRIMARY KEY,
                    HoTen NVARCHAR(30) NOT NULL,
                    NgaySinh DATE,
                    NoiSinh NVARCHAR(20),
                    GioiTinh NVARCHAR(10),
                    Lop NVARCHAR(20),
                    MaKhoa CHAR(5),
                    MaTK CHAR(10),
                    FOREIGN KEY(MaKhoa) REFERENCES KHOA(MaKhoa),
                    FOREIGN KEY(MaTK) REFERENCES TTTAIKHOAN(MaTK)
                );

                IF OBJECT_ID('BANGDIEM','U') IS NULL
                CREATE TABLE BANGDIEM (
                    MaSV CHAR(10),
                    MaHP NVARCHAR(20),
                    DiemQT FLOAT,
                    DiemKTHP FLOAT,
                    FOREIGN KEY(MaSV) REFERENCES SINHVIEN(MaSV),
                    FOREIGN KEY(MaHP) REFERENCES HOCPHAN(MaHP)
                );";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
