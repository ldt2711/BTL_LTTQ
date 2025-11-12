using System.Data.SqlClient;

namespace WinFormsApp.Helpers
{
    public static class DbDataGen
    {
        public static void InsertSampleData()
        {
            using (SqlConnection conn = DatabaseConnection.GetDbConnection())
            {
                conn.Open();

                string query = @"
                -- Thêm KHOA (5 khoa)
                IF NOT EXISTS(SELECT 1 FROM KHOA WHERE MaKhoa='CNTT')
                    INSERT INTO KHOA(MaKhoa, TenKhoa) VALUES
                    ('CNTT','Công nghệ thông tin'),
                    ('QTKD','Quản trị kinh doanh'),
                    ('KT','Kế toán'),
                    ('VT','Vật lý kỹ thuật'),
                    ('NN','Ngoại ngữ');

                -- Thêm TTTAIKHOAN (1 admin, 4 sinh viên)
                IF NOT EXISTS(SELECT 1 FROM TTTAIKHOAN WHERE MaTK='TK000')
                    INSERT INTO TTTAIKHOAN(MaTK, TaiKhoan, MatKhau, Loai) VALUES
                    ('TK000','admin','123',0),
                    ('TK001','sv1','123',1),
                    ('TK002','sv2','123',1),
                    ('TK003','sv3','123',1),
                    ('TK004','sv4','123',1);

                -- Thêm HOCPHAN (5 học phần)
                IF NOT EXISTS(SELECT 1 FROM HOCPHAN WHERE MaHP='HP001')
                    INSERT INTO HOCPHAN(MaHP, TenHP, SoTin, TrongSoQT, TrongSoKTHP) VALUES
                    ('HP001','Toán cao cấp',3,0.3,0.7),
                    ('HP002','Lập trình C#',4,0.4,0.6),
                    ('HP003','Cấu trúc dữ liệu',3,0.35,0.65),
                    ('HP004','Cơ sở dữ liệu',3,0.3,0.7),
                    ('HP005','Mạng máy tính',2,0.4,0.6);

                -- Thêm SINHVIEN (10 sinh viên)
                IF NOT EXISTS(SELECT 1 FROM SINHVIEN WHERE MaSV='SV001')
                    INSERT INTO SINHVIEN(MaSV, HoTen, NgaySinh, NoiSinh, GioiTinh, Lop, MaKhoa, MaTK) VALUES
                    ('SV001','Nguyen Van A','2000-01-01','HN','Nam','CNTT1','CNTT','TK001'),
                    ('SV002','Tran Thi B','2000-02-02','HN','Nu','CNTT2','CNTT','TK002'),
                    ('SV003','Le Van C','2000-03-03','HN','Nam','QTKD1','QTKD','TK003'),
                    ('SV004','Pham Thi D','2000-04-04','HN','Nu','KT1','KT','TK004'),
                    ('SV005','Hoang Van E','2000-05-05','HN','Nam','VT1','VT',NULL),
                    ('SV006','Nguyen Thi F','2000-06-06','HN','Nu','NN1','NN',NULL),
                    ('SV007','Tran Van G','2000-07-07','HN','Nam','CNTT3','CNTT',NULL),
                    ('SV008','Le Thi H','2000-08-08','HN','Nu','QTKD2','QTKD',NULL),
                    ('SV009','Pham Van I','2000-09-09','HN','Nam','KT2','KT',NULL),
                    ('SV010','Hoang Thi J','2000-10-10','HN','Nu','VT2','VT',NULL);

                -- Thêm BANGDIEM (một số điểm mẫu)
                IF NOT EXISTS(SELECT 1 FROM BANGDIEM WHERE MaSV='SV001')
                    INSERT INTO BANGDIEM(MaSV, MaHP, DiemQT, DiemKTHP) VALUES
                    ('SV001','HP001',8.5,7.0),
                    ('SV001','HP002',9.0,8.0),
                    ('SV002','HP001',7.5,6.0),
                    ('SV002','HP003',8.0,7.5),
                    ('SV003','HP002',8.0,8.0),
                    ('SV003','HP004',9.0,8.5),
                    ('SV004','HP001',7.0,6.5),
                    ('SV004','HP005',8.0,7.0),
                    ('SV005','HP003',6.5,6.0),
                    ('SV005','HP004',7.5,7.0);
                ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
