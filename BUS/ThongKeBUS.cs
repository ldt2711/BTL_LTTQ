using System.Data;
using WinFormsApp.DAL;

namespace WinFormsApp.BUS
{
    public class ThongKeBUS
    {
        public static DataTable GetValues(string filterType)
        {
            if (filterType == "Khoa")
                return ThongKeDAL.GetDanhSachKhoa();
            else if (filterType == "Lớp")
                return ThongKeDAL.GetDanhSachLop();
            else if (filterType == "Học kỳ")
                return ThongKeDAL.GetDanhSachHocKy();
            else if (filterType == "Năm học")
                return ThongKeDAL.GetDanhSachNamHoc();
            else
                return new DataTable();
        }

        public static DataTable GetThongKeHocLuc(string filterType1, string value1, string filterType2, string value2)
        {
            return ThongKeDAL.GetThongKeHocLuc(filterType1, value1, filterType2, value2);
        }
    }
}
