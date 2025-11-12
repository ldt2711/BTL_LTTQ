using System.Data.SqlClient;

namespace WinFormsApp.Helpers
{
    public static class DatabaseConnection
    {
        // Kết nối tới master database để tạo database mới
        private static string masterConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";

        // Tên database
        public static string DatabaseName = "LTTQ_QLSV";

        // Chuỗi kết nối tới database của bạn
        public static string GetConnectionString()
        {
            return $@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog={DatabaseName};Integrated Security=True";
        }

        // Kết nối tới master database
        public static SqlConnection GetMasterConnection()
        {
            return new SqlConnection(masterConnection);
        }

        // Kết nối tới database chính
        public static SqlConnection GetDbConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
