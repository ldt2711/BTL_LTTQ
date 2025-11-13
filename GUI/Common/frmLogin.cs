using BTL_LTTQ.BUS;
using BTL_LTTQ.GUI.Admin;
using BTL_LTTQ.GUI.SinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ.Common
{
    public partial class frmLogin : Form
    {
        private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        private bool isLoggedIn = false;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void lbLogin_Click(object sender, EventArgs e)
        {

        }

        private void lbMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void lbTenTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pnLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string user = tBTenTaiKhoan.Text.Trim();
            string pass = tBMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = taiKhoanBUS.Login(user, pass);

            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mở form tương ứng
            if (result.Role == 0) // Admin
            {
                FrmQLSV adminForm = new FrmQLSV(this);
                adminForm.Show();
            }
            else if (result.Role == 1) // Sinh viên
            {
                frmSinhVien svForm = new frmSinhVien(this);
                svForm.Show();
            }

            this.Hide(); // ẩn form đăng nhập
        }
    }
}
