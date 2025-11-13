using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ.GUI.SinhVien
{
    public partial class Uc_sidebarSinhVien : UserControl
    {
        public event EventHandler<string> MenuClicked;
        private bool isCollapsed = false;
        private bool isTextVisible = false; // Biến trạng thái mới
        private IconButton currentButton = null;

        private Timer animationTimer;
        private int targetWidth;
        private const int ANIMATION_SPEED_DIVISOR = 6;
        private const int MAX_WIDTH = 400;
        private const int MIN_WIDTH = 100;

        private const int TEXT_TRIGGER_WIDTH = 270;

        public Uc_sidebarSinhVien()
        {
            InitializeComponent();

            animationTimer = new Timer();
            animationTimer.Interval = 15;
            animationTimer.Tick += AnimationTimer_Tick;

            // Thiết lập trạng thái ban đầu (mở rộng)
            isCollapsed = true;
            isTextVisible = false;
            targetWidth = MAX_WIDTH;
            SnapToWidth(true);       // Cài đặt Width ban đầu
            UpdateMenuVisuals(true); // Cài đặt Text/Icon ban đầu
            HighlightButton(btnTrangChu); // Mặc định chọn Trang Chủ
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ToggleMenu();
        }

        private void ToggleMenu()
        {
            isCollapsed = !isCollapsed;
            targetWidth = isCollapsed ? MIN_WIDTH : MAX_WIDTH;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int distance = targetWidth - panelMenu.Width;

            if (Math.Abs(distance) < 3)
            {
                // Animation kết thúc, dừng timer và "snap" về đúng vị trí
                animationTimer.Stop();
                SnapToWidth(isCollapsed);
                UpdateMenuVisuals(isCollapsed); // Đảm bảo trạng thái cuối cùng chính xác
                isTextVisible = !isCollapsed; // Đồng bộ trạng thái
            }
            else
            {
                // Animation đang chạy
                int step = (distance / ANIMATION_SPEED_DIVISOR) + (distance > 0 ? 1 : -1);

                panelMenu.Width += step;
                this.Width += step;

                // 1. Nếu đang THU GỌN, text VẪN HIỆN, và Width < mốc
                if (isCollapsed && isTextVisible && panelMenu.Width < TEXT_TRIGGER_WIDTH)
                {
                    UpdateMenuVisuals(true); // Ẩn text, căn giữa icon
                    isTextVisible = false;
                }
                // 2. Nếu đang MỞ RỘNG, text ĐANG ẨN, và Width > mốc
                else if (!isCollapsed && !isTextVisible && panelMenu.Width > TEXT_TRIGGER_WIDTH)
                {
                    UpdateMenuVisuals(false); // Hiện text, căn trái icon
                    isTextVisible = true;
                }
            }
        }

        // HÀM MỚI: Chỉ cập nhật Width (không animation)
        private void SnapToWidth(bool collapse)
        {
            int width = collapse ? MIN_WIDTH : MAX_WIDTH;
            this.Width = width;
            panelMenu.Width = width;
        }

        private void UpdateMenuVisuals(bool collapse)
        {
            if (collapse) // Thu gọn (ẩn text, căn giữa icon)
            {
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;

                foreach (IconButton menuButton in panelMenu.Controls.OfType<IconButton>())
                {
                    if (menuButton != btnMenu)
                    {
                        menuButton.Text = "";
                        menuButton.ImageAlign = ContentAlignment.MiddleCenter; // Yêu cầu của bạn
                        menuButton.Padding = new Padding(0);
                    }
                }
            }
            else // Mở rộng (hiện text, căn trái icon)
            {
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;

                foreach (IconButton menuButton in panelMenu.Controls.OfType<IconButton>())
                {
                    if (menuButton != btnMenu)
                    {
                        menuButton.Text = "  " + menuButton.Tag?.ToString();
                        menuButton.ImageAlign = ContentAlignment.MiddleLeft; // Yêu cầu của bạn
                        menuButton.Padding = new Padding(10, 0, 0, 0);
                    }
                }
            }
        }

        // Cập nhật hàm AutoAdjust để dùng hàm mới
        public void AutoAdjustByWindowSize(int formWidth)
        {
            if (formWidth < 900 && !isCollapsed)
            {
                SnapToWidth(true);
                UpdateMenuVisuals(true);
                isCollapsed = true;
                isTextVisible = false;
                targetWidth = MIN_WIDTH;
            }
            else if (formWidth >= 900 && isCollapsed)
            {
                SnapToWidth(false);
                UpdateMenuVisuals(false);
                isCollapsed = false;
                isTextVisible = true;
                targetWidth = MAX_WIDTH;
            }
        }


        private void HighlightButton(IconButton btn)
        {
            // Đặt lại màu nút trước đó về mặc định
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(21, 101, 192); // màu mặc định
                currentButton.ForeColor = currentButton.IconColor = Color.White;
            }
            // Lưu nút hiện tại và đổi màu đậm
            currentButton = btn;
            currentButton.BackColor = Color.FromArgb(13, 71, 161); // màu đậm khi chọn

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as IconButton);
            MenuClicked?.Invoke(this, "TrangChu");

        }

        private void btnHocPhan_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as IconButton);
            MenuClicked?.Invoke(this, "HocPhan");
        }
        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as IconButton);
            MenuClicked?.Invoke(this, "XemDiem");
        }
        private void btnTTCN_Click(object sender, EventArgs e)
        {
            HighlightButton(sender as IconButton);
            MenuClicked?.Invoke(this, "TTCN");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?", // Nội dung
                "Xác nhận Đăng xuất", // Tiêu đề
                MessageBoxButtons.YesNo, // Nút Yes/No
                MessageBoxIcon.Question // Icon
            );

            // 2. Chỉ xử lý nếu người dùng nhấn "Yes"
            if (result == DialogResult.Yes)
            {
                HighlightButton(sender as IconButton);

                MenuClicked?.Invoke(this, "DangXuat");
            }
        }
    }
}
