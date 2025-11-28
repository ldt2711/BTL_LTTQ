using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WinFormsApp.BUS;

namespace BTL_LTTQ.GUI.Admin
{
    public partial class Uc_TKBCAdmin : UserControl
    {
        public Uc_TKBCAdmin()
        {
            InitializeComponent();
            SetupFilters();
            SetupChartDefault(); // ⭐ Khởi tạo biểu đồ ngay khi load
        }

        private void SetupFilters()
        {
            // Thêm mục "Tất cả" để có thể chọn không lọc
            cbFilter1.Items.AddRange(new string[] { "Khoa", "Lớp" });
            cbFilter2.Items.AddRange(new string[] { "Học kỳ", "Năm học" });
        }

        // ⭐ PHƯƠNG THỨC MỚI: Thiết lập trạng thái ban đầu/Reset cho biểu đồ
        private void SetupChartDefault()
        {
            chartHocLuc.Series.Clear();
            chartHocLuc.Titles.Clear();
            chartHocLuc.Titles.Add("Thống kê Học lực");
            Title mainTitle = chartHocLuc.Titles[0]; // Lấy đối tượng Title vừa tạo

            // ⭐ THAY ĐỔI VỊ TRÍ (Ví dụ: Đặt ở dưới cùng)
            mainTitle.Docking = Docking.Bottom;
            // ⭐ (Tùy chọn) Căn giữa chữ
            mainTitle.Alignment = ContentAlignment.MiddleCenter;
            chartHocLuc.Legends.Clear();

            // Thêm một Series mặc định để giữ Chart Area không bị trống
            var defaultSeries = chartHocLuc.Series.Add("Dữ liệu");
            defaultSeries.ChartType = SeriesChartType.Pie;
            defaultSeries.IsValueShownAsLabel = true;
            defaultSeries.Label = "Chưa có dữ liệu";
            defaultSeries.Points.AddXY("Chưa có dữ liệu", 1);
            defaultSeries.Points[0].Color = Color.LightGray;
            defaultSeries.Points[0].Label = "Vui lòng chọn tiêu chí tìm kiếm";
            defaultSeries.Points[0].IsValueShownAsLabel = false; // Ẩn nhãn cho mục mặc định

            chartHocLuc.Invalidate();
        }

        private void cbFilter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadValues(cbFilter1, cbValue1, lblValue1);
        }

        private void cbFilter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadValues(cbFilter2, cbValue2, lblValue2);
        }

        private void LoadValues(ComboBox cbFilter, ComboBox cbValue, Label lblValue)
        {
            string selected = cbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected)) return;

            DataTable dt = ThongKeBUS.GetValues(selected);
            cbValue.Items.Clear();
            cbValue.Text = string.Empty; // Xóa text cũ

            // Xác định tên cột và nhãn Label
            string columnName = "";
            string labelText = "";

            if (selected == "Khoa")
            {
                columnName = "MaKhoa";
                labelText = "Chọn Khoa:";
            }
            else if (selected == "Lớp")
            {
                columnName = "Lop";
                labelText = "Chọn Lớp:";
            }
            else if (selected == "Học kỳ")
            {
                columnName = "HocKy";
                labelText = "Chọn Học kỳ:";
            }
            else if (selected == "Năm học")
            {
                columnName = "NamHoc";
                labelText = "Chọn Năm học:";
            }

            lblValue.Text = labelText;

            // Thêm các giá trị vào ComboBox
            if (!string.IsNullOrEmpty(columnName))
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbValue.Items.Add(row[columnName].ToString());
                }
            }
        }

        // ⭐ HÀM RESET
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset các ComboBox lọc
            cbFilter1.SelectedIndex = -1;
            cbValue1.Items.Clear();
            cbValue1.Text = string.Empty;
            lblValue1.Text = "Giá trị 1:";

            cbFilter2.SelectedIndex = -1;
            cbValue2.Items.Clear();
            cbValue2.Text = string.Empty;
            lblValue2.Text = "Giá trị 2:";

            // Reset biểu đồ
            SetupChartDefault();

            MessageBox.Show("Đã reset các tiêu chí lọc và biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbFilter1.SelectedItem == null || cbValue1.SelectedItem == null ||
                cbFilter2.SelectedItem == null || cbValue2.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đủ các tiêu chí lọc!");
                SetupChartDefault(); // Vẫn giữ biểu đồ trống nếu lỗi
                return;
            }

            try
            {
                var dt = ThongKeBUS.GetThongKeHocLuc(
                    cbFilter1.SelectedItem.ToString(),
                    cbValue1.SelectedItem.ToString(),
                    cbFilter2.SelectedItem.ToString(),
                    cbValue2.SelectedItem.ToString()
                );

                // Xử lý phân loại học lực
                int gioi = 0, kha = 0, tb = 0, yeu = 0;

                foreach (DataRow r in dt.Rows)
                {
                    double gpa = Convert.ToDouble(r["GPA"]);
                    if (gpa >= 8.0) gioi++;
                    else if (gpa >= 6.5) kha++;
                    else if (gpa >= 5.0) tb++;
                    else if (gpa >= 3.0) tb++; // Sửa lỗi logic nếu có: GPA 5.0 - 6.4 là Trung bình
                    else yeu++; // Dưới 3.0 là Yếu (Tùy theo thang điểm của bạn)
                }

                // Tổng số sinh viên được thống kê
                int totalStudents = gioi + kha + tb + yeu;

                // Hiển thị lên chart
                chartHocLuc.Series.Clear();
                chartHocLuc.Titles.Clear();
                chartHocLuc.Titles.Add($"Thống kê Học lực theo {cbFilter1.Text} ({cbValue1.Text}) và {cbFilter2.Text} ({cbValue2.Text})");
                Title mainTitle = chartHocLuc.Titles[0]; // Lấy đối tượng Title vừa tạo

                // ⭐ THAY ĐỔI VỊ TRÍ (Ví dụ: Đặt ở dưới cùng)
                mainTitle.Docking = Docking.Bottom;
                // ⭐ (Tùy chọn) Căn giữa chữ
                mainTitle.Alignment = ContentAlignment.MiddleCenter;

                if (totalStudents == 0)
                {
                    // Trường hợp không có dữ liệu: Vẫn hiển thị chart area nhưng thông báo không có data
                    SetupChartDefault();
                    MessageBox.Show("Không tìm thấy dữ liệu sinh viên phù hợp với các tiêu chí lọc này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var s = chartHocLuc.Series.Add("Học lực");
                s.ChartType = SeriesChartType.Pie;
                s.IsValueShownAsLabel = true;
                s.Label = "#VALX: #PERCENT{P1}";
                s.LegendText = "#VALX (#VALY)";
                s["PieLabelStyle"] = "Outside";
                s["PieLineColor"] = "Gray";

                // Thêm dữ liệu vào biểu đồ
                s.Points.AddXY("Giỏi", gioi);
                s.Points.AddXY("Khá", kha);
                s.Points.AddXY("Trung bình", tb);
                s.Points.AddXY("Yếu", yeu);

                // Xóa các điểm có giá trị bằng 0
                for (int i = s.Points.Count - 1; i >= 0; i--)
                {
                    if (s.Points[i].YValues[0] == 0)
                        s.Points.RemoveAt(i);
                }

                chartHocLuc.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetupChartDefault();
            }
        }
    }
}
