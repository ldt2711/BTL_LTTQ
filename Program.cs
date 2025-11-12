using BTL_LTTQ.Common;
using BTL_LTTQ.GUI.Admin;
using BTL_LTTQ.GUI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Helpers;

namespace BTL_LTTQ
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tạo database và bảng
            DbInit.CreateDatabaseIfNotExists();
            DbInit.CreateTablesIfNotExists();

            // Chèn dữ liệu mẫu
            DbDataGen.InsertSampleData();

            Application.Run(new frmLogin());
        }
    }
}
