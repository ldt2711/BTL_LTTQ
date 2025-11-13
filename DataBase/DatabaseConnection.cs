using System;
using System.Data.SqlClient;
using System.IO;

namespace WinFormsApp.Helpers
{
    public static class DatabaseConnection
    {
        private static readonly string DatabaseFolder =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");

        // ✅ Đường dẫn đầy đủ đến file .mdf
        public static readonly string DatabaseFile =
            Path.Combine(DatabaseFolder, "StudentDB.mdf");

        // ✅ Connection string kết nối LocalDB
        public static readonly string ConnectionString =
            $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={DatabaseFile};Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static void InitializeDatabase()
        {
            // Nếu thư mục chưa có thì tạo
            if (!Directory.Exists(DatabaseFolder))
                Directory.CreateDirectory(DatabaseFolder);

            // Nếu file database chưa tồn tại thì tạo mới
            if (!File.Exists(DatabaseFile))
            {
                Console.WriteLine("Database chưa tồn tại — đang tạo mới...");
                CreateDatabase();
                DbInit.CreateTables();
                DbDataGen.InsertSampleData();
            }
        }

        private static void CreateDatabase()
        {
            string dbName = Path.GetFileNameWithoutExtension(DatabaseFile);
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                // 🔹 Kiểm tra nếu DB đã tồn tại
                string checkCmd = $"SELECT database_id FROM sys.databases WHERE Name = '{dbName}'";
                using (SqlCommand cmdCheck = new SqlCommand(checkCmd, conn))
                {
                    object result = cmdCheck.ExecuteScalar();
                    if (result != null)
                    {
                        Console.WriteLine($"Database '{dbName}' đã tồn tại — bỏ qua bước tạo mới.");
                        return;
                    }
                }

                // 🔹 Nếu chưa có, thì tạo DB mới
                string createCmd = $@"
                CREATE DATABASE [{dbName}]
                ON (NAME = N'{dbName}', FILENAME = '{DatabaseFile}')";

                using (SqlCommand cmdCreate = new SqlCommand(createCmd, conn))
                {
                    cmdCreate.ExecuteNonQuery();
                }
            }
        }
    }
}
