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
    public partial class UC_Template : UserControl
    {
        public event EventHandler<string> MenuClicked; // Sự kiện để thông báo form cha biết nút nào được bấm
        private bool isCollapsed = false;

        public UC_Template()
        {
            InitializeComponent();
            CollaspeMenu(true);
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
                panelMenu.Width = 230;
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

        private void btnThongTin_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
