using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_LTTQ.BUS
{
    public static class SessionManager
    {
        public static string CurrentMaTK { get; private set; } = null;
        public static string CurrentUsername { get; private set; } = null;
        public static int CurrentRole { get; private set; } = -1; // 0: Admin, 1: Sinh viên

        public static void SetUser(string maTK, string username, int role)
        {
            CurrentMaTK = maTK;
            CurrentUsername = username;
            CurrentRole = role;
        }

        public static void ClearSession()
        {
            CurrentMaTK = null;
            CurrentUsername = null;
            CurrentRole = -1;
        }

        // Kiểm tra xem người dùng hiện tại có phải là Sinh viên không
        public static bool IsStudent()
        {
            return CurrentRole == 1;
        }
    }
}
