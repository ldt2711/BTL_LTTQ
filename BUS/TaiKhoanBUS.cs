using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_LTTQ.DAL;

namespace BTL_LTTQ.BUS
{
    internal class TaiKhoanBUS
    {
        private TaiKhoanDAL dal = new TaiKhoanDAL();
        private SinhVien_CB_DAL svDal = new SinhVien_CB_DAL(); // Thêm DAL của Sinh viên

        public (bool Success, string Message, int Role) Login(string username, string password)
        {
            DataRow account = dal.CheckLogin(username, password);

            if (account == null)
                return (false, "Sai tài khoản hoặc mật khẩu!", -1);

            string maTK = account["MaTK"].ToString();
            int role = Convert.ToInt32(account["Loai"]);

            // Lưu thông tin phiên
            SessionManager.SetUser(maTK, username, role);

            return (true, "Đăng nhập thành công!", role);
        }

        // ⭐ HÀM MỚI: Lấy thông tin sinh viên sau khi đăng nhập
        public DataRow GetThongTinSinhVien(string maTK)
        {
            // Hàm này sẽ gọi đến SinhVienDAL để lấy DataRow
            return svDal.GetThongTinSinhVienByMaTK(maTK);
        }
    }
}
