using System.Data.SqlClient;

namespace WinFormsApp.Helpers
{
    public static class DbDataGen
    {
        public static void InsertSampleData()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                // 5 tài khoản (1 admin, 4 sinh viên)
                string sql = @"
                    INSERT INTO KHOA (MaKhoa, TenKhoa) VALUES
                    ('CNTT', N'Công nghệ thông tin'),
                    ('KHMT', N'Khoa học máy tính'),
                    ('CK', N'Cơ khí');



                    INSERT INTO TTTAIKHOAN (MaTK, TaiKhoan, MatKhau, Loai)
                    VALUES
                    ('2312001', 'nguyenvanan', '12345', 1),
                    ('2312002', 'lethibinh', '12345', 1),
                    ('2312003', 'tranminhcuong', '12345', 1),
                    ('2312004', 'phamquynhnga', '12345', 1),
                    ('2312005', 'dohoangviet', '12345', 1),
                    ('2312006', 'nguyenthanhtu', '12345', 1),
                    ('2312007', 'phanthihanh', '12345', 1),
                    ('2312008', 'hoangvanhuy', '12345', 1),
                    ('2312009', 'nguyendinhlong', '12345', 1),
                    ('2312010', 'tranthutrang', '12345', 1),
                    ('2313001', 'leanhtuan', '12345', 1),
                    ('2313002', 'phamhongnhung', '12345', 1),
                    ('2313003', 'tranquocviet', '12345', 1),
                    ('2313004', 'ngothanhhien', '12345', 1),
                    ('2313005', 'dinhvanhoang', '12345', 1),
                    ('2313006', 'nguyenhoainam', '12345', 1),
                    ('2313007', 'luongmailan', '12345', 1),
                    ('2313008', 'hoangducduy', '12345', 1),
                    ('2313009', 'phamanhdung', '12345', 1),
                    ('2313010', 'nguyenminhhang', '12345', 1),
                    ('2314001', 'tranhuuquang', '12345', 1),
                    ('2314002', 'lequanghuy', '12345', 1),
                    ('2314003', 'phamhoanglong', '12345', 1),
                    ('2314004', 'nguyenthihoa', '12345', 1),
                    ('2314005', 'hoangvantung', '12345', 1),
                    ('2314006', 'dangthuthao', '12345', 1),
                    ('2314007', 'phanvanduc', '12345', 1),
                    ('2314008', 'lythihoa', '12345', 1),
                    ('2314009', 'vuductoan', '12345', 1),
                    ('2314010', 'trinhvannam', '12345', 1),
                    ('admin', 'admin', '12345', 0);

                    INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, NoiSinh, GioiTinh, Lop, MaKhoa, MaTK)
                    VALUES
                    ('2312001', N'Nguyễn Văn An', '2003-04-12', N'Hà Nội', N'Nam', N'CNTT1', 'CNTT', '2312001'),
                    ('2312002', N'Lê Thị Bình', '2003-07-20', N'Hải Phòng', N'Nữ', N'CNTT1', 'CNTT', '2312002'),
                    ('2312003', N'Trần Minh Cường', '2003-11-02', N'Bắc Ninh', N'Nam', N'CNTT3', 'CNTT', '2312003'),
                    ('2312004', N'Phạm Quỳnh Nga', '2003-03-18', N'Hà Nam', N'Nữ', N'CNTT3', 'CNTT', '2312004'),
                    ('2312005', N'Đỗ Hoàng Việt', '2003-10-25', N'Hưng Yên', N'Nam', N'CNTT1', 'CNTT', '2312005'),
                    ('2312006', N'Nguyễn Thanh Tú', '2003-09-12', N'Hà Nội', N'Nữ', N'CNTT3', 'CNTT', '2312006'),
                    ('2312007', N'Phan Thị Hạnh', '2003-06-04', N'Nghệ An', N'Nữ', N'CNTT1', 'CNTT', '2312007'),
                    ('2312008', N'Hoàng Văn Huy', '2003-12-21', N'Bắc Giang', N'Nam', N'CNTT3', 'CNTT', '2312008'),
                    ('2312009', N'Nguyễn Đình Long', '2003-01-17', N'Thái Bình', N'Nam', N'CNTT1', 'CNTT', '2312009'),
                    ('2312010', N'Trần Thu Trang', '2003-08-10', N'Hà Nội', N'Nữ', N'CNTT3', 'CNTT', '2312010');

                    
                    INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, NoiSinh, GioiTinh, Lop, MaKhoa, MaTK)
                    VALUES
                    ('2313001', N'Lê Anh Tuấn', '2003-02-05', N'Hà Nội', N'Nam', N'KHMT1', 'KHMT', '2313001'),
                    ('2313002', N'Phạm Hồng Nhung', '2003-03-15', N'Hải Dương', N'Nữ', N'KHMT2', 'KHMT', '2313002'),
                    ('2313003', N'Trần Quốc Việt', '2003-07-22', N'Nam Định', N'Nam', N'KHMT1', 'KHMT', '2313003'),
                    ('2313004', N'Ngô Thanh Huyền', '2003-09-11', N'Ninh Bình', N'Nữ', N'KHMT2', 'KHMT', '2313004'),
                    ('2313005', N'Đinh Văn Hoàng', '2003-10-01', N'Thanh Hóa', N'Nam', N'KHMT1', 'KHMT', '2313005'),
                    ('2313006', N'Nguyễn Hoài Nam', '2003-12-20', N'Hà Nội', N'Nam', N'KHMT2', 'KHMT', '2313006'),
                    ('2313007', N'Lương Mai Lan', '2003-04-30', N'Hà Nam', N'Nữ', N'KHMT1', 'KHMT', '2313007'),
                    ('2313008', N'Hoàng Đức Duy', '2003-08-09', N'Hà Giang', N'Nam', N'KHMT2', 'KHMT', '2313008'),
                    ('2313009', N'Phạm Anh Dũng', '2003-06-16', N'Hải Phòng', N'Nam', N'KHMT1', 'KHMT', '2313009'),
                    ('2313010', N'Nguyễn Minh Hằng', '2003-05-08', N'Hà Nội', N'Nữ', N'KHMT2', 'KHMT', '2313010');

                    
                    INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, NoiSinh, GioiTinh, Lop, MaKhoa, MaTK)
                    VALUES
                    ('2314001', N'Trần Hữu Quang', '2003-04-01', N'Hà Nội', N'Nam', N'CK1', 'CK', '2314001'),
                    ('2314002', N'Lê Quang Huy', '2003-09-10', N'Hải Dương', N'Nam', N'CK1', 'CK', '2314002'),
                    ('2314003', N'Phạm Hoàng Long', '2003-11-03', N'Hà Nam', N'Nam', N'CK2', 'CK', '2314003'),
                    ('2314004', N'Nguyễn Thị Hòa', '2003-02-26', N'Hà Nội', N'Nữ', N'CK2', 'CK', '2314004'),
                    ('2314005', N'Hoàng Văn Tùng', '2003-06-20', N'Ninh Bình', N'Nam', N'CK1', 'CK', '2314005'),
                    ('2314006', N'Đặng Thu Thảo', '2003-08-13', N'Hà Nội', N'Nữ', N'CK2', 'CK', '2314006'),
                    ('2314007', N'Phan Văn Đức', '2003-12-01', N'Thanh Hóa', N'Nam', N'CK1', 'CK', '2314007'),
                    ('2314008', N'Lý Thị Hoa', '2003-05-25', N'Hà Giang', N'Nữ', N'CK2', 'CK', '2314008'),
                    ('2314009', N'Vũ Đức Toàn', '2003-07-15', N'Hà Nội', N'Nam', N'CK1', 'CK', '2314009'),
                    ('2314010', N'Trịnh Văn Nam', '2003-03-19', N'Hải Phòng', N'Nam', N'CK2', 'CK', '2314010');

                    INSERT INTO HOCPHAN (MaHP, TenHP, SoTin, TrongSoQT, TrongSoKTHP, HocKy, NamHoc)
                    VALUES
                    ('HP001', N'Lập trình C#', 3, 0.4, 0.6, 1, 2023),
                    ('HP002', N'Cơ sở dữ liệu', 3, 0.3, 0.7, 1, 2023),
                    ('HP003', N'Mạng máy tính', 3, 0.5, 0.5, 2, 2023),
                    ('HP004', N'Trí tuệ nhân tạo', 3, 0.4, 0.6, 2, 2023),
                    ('HP005', N'Kỹ thuật lập trình', 3, 0.3, 0.7, 1, 2023),
                    ('HP006', N'Hệ điều hành', 3, 0.4, 0.6, 2, 2023);

                    INSERT INTO HOCPHAN (MaHP, TenHP, SoTin, TrongSoQT, TrongSoKTHP, HocKy, NamHoc) VALUES
                    ('HP101', N'Cơ học', 3, 0.4, 0.6, 1, 2023),
                    ('HP102', N'Vật liệu cơ khí', 3, 0.5, 0.5, 1, 2023),
                    ('HP103', N'Thực hành cơ khí', 2, 0.3, 0.7, 2, 2024),
                    ('HP104', N'Trắc địa và đo vẽ kỹ thuật', 2, 0.4, 0.6, 2, 2024),
                    ('HP105', N'Máy công cụ', 4, 0.3, 0.7, 2, 2024);

                    INSERT INTO BANGDIEM (MaSV, MaHP, DiemQT, DiemKTHP)
                    VALUES
                    ('2312001', 'HP001', 8.0, 9.0),
                    ('2312001', 'HP002', 7.5, 8.5),
                    ('2312001', 'HP003', 6.0, 7.0),
                    ('2312002', 'HP001', 9.0, 9.5),
                    ('2312002', 'HP002', 8.5, 8.0),
                    ('2312002', 'HP003', 7.0, 6.5),
                    ('2313001', 'HP101', 7.0, 8.0),
                    ('2313001', 'HP102', 6.5, 7.5),
                    ('2313002', 'HP101', 8.5, 9.0),
                    ('2313002', 'HP102', 9.0, 8.5),
                    ('2314001', 'HP103', 7.5, 8.0),
                    ('2314001', 'HP104', 6.0, 7.0);
                    ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
