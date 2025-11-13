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

        public (bool Success, string Message, int Role) Login(string username, string password)
        {
            DataRow account = dal.CheckLogin(username, password);

            if (account == null)
                return (false, "Sai tài khoản hoặc mật khẩu!", -1);

            int role = Convert.ToInt32(account["Loai"]);
            return (true, "Đăng nhập thành công!", role);
        }
    }
}
