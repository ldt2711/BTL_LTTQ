using BTL_LTTQ.GUI.Admin;
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
            isLoggedIn = true;
            if (isLoggedIn)
            {
                FrmQLSV frmQlsv = new FrmQLSV(this);
                frmQlsv.Show();
                this.Hide();
            }
        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
