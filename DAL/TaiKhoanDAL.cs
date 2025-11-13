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
    internal class TaiKhoanDAL
    {
        private string connectionString = DatabaseConnection.ConnectionString;

        public DataRow CheckLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TTTAIKHOAN WHERE TaiKhoan = @user AND MatKhau = @pass";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@user", username);
                da.SelectCommand.Parameters.AddWithValue("@pass", password);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                    return null; // sai tài khoản hoặc mật khẩu

                return dt.Rows[0]; // trả về dòng chứa thông tin tài khoản
            }
        }
    }
}
