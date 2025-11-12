using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ.GUI.Common
{
    public partial class Uc_sidebarAdmin : UserControl
    {
        public event EventHandler<string> MenuClicked; // Sự kiện để thông báo form cha biết nút nào được bấm
        private bool isCollapsed = false;
        private Button currentButton = null;
        public Uc_sidebarAdmin()
        {
            InitializeComponent();
            CollaspeMenu(false);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ToggleMenu();
        }
        private void ToggleMenu()
        {
            isCollapsed = !isCollapsed;
            CollaspeMenu(isCollapsed);
        }

        private void CollaspeMenu(bool collapse)
        {
            if (collapse) // Thu gọn menu
            {
                this.Width = 100;
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    if (menuButton != btnMenu)
                    {
                        menuButton.Text = "";
                        menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                        menuButton.Padding = new Padding(0);
                    }
                }
            }
            else // Mở rộng menu
            {
                this.Width = 400;
                panelMenu.Width = 400;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    if (menuButton != btnMenu)
                    {
                        menuButton.Text = "  " + menuButton.Tag?.ToString();
                        menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                        menuButton.Padding = new Padding(10, 0, 0, 0);
                    }
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && MenuClicked != null)
            {
                MenuClicked(this, btn.Name); // 👈 Gửi tên nút cho form cha
            }
            if (!isCollapsed)
            {
                ToggleMenu();
            }
        }

        public void AutoAdjustByWindowSize(int formWidth)
        {
            if (formWidth < 900 && !isCollapsed)
            {
                // Nếu cửa sổ nhỏ và menu đang mở → thu lại
                CollaspeMenu(true);
                isCollapsed = true;
            }
            else if (formWidth >= 900 && isCollapsed)
            {
                // Nếu cửa sổ to và menu đang thu → mở ra
                CollaspeMenu(false);
                isCollapsed = false;
            }
        }


        private void HighlightButton(Button btn)
        {
            // Đặt lại màu nút trước đó về mặc định
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(21, 101, 192); // màu mặc định
                currentButton.ForeColor = Color.White;
            }
            // Lưu nút hiện tại và đổi màu đậm
            currentButton = btn;
            currentButton.BackColor = Color.FromArgb(255,255,255); // màu đậm khi chọn
            currentButton.ForeColor = Color.FromArgb(21, 101, 192);
            
        }



        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            MenuClicked?.Invoke(this, "TrangChu");
            
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            MenuClicked?.Invoke(this, "SinhVien");
            
        }

        private void btnHocPhan_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            MenuClicked?.Invoke(this, "HocPhan");
            
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            MenuClicked?.Invoke(this, "NhapDiem");
            
        }

        private void btnTKBC_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            MenuClicked?.Invoke(this, "TKBC");
            
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            MenuClicked?.Invoke(this, "TaiKhoan");
            
        }



        private void btnKhoa_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as Button);
            MenuClicked?.Invoke(this, "Khoa");
            
        }


    }
}
