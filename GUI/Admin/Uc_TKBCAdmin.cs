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
        }
        private void SetupFilters()
        {
            cbFilter1.Items.AddRange(new string[] { "Khoa", "Lớp" });
            cbValue1.Visible = false;
            cbFilter2.Items.AddRange(new string[] { "Học kỳ", "Năm học" });
            cbValue2.Visible = false;
        }

        private void cbFilter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadValues(cbFilter1, cbValue1);
            cbValue1.Visible = true;
        }

        private void cbFilter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadValues(cbFilter2, cbValue2);
            cbValue2.Visible = true;
        }

        private void LoadValues(ComboBox cbFilter, ComboBox cbValue)
        {
            string selected = cbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected)) return;

            DataTable dt = ThongKeBUS.GetValues(selected);
            cbValue.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Lấy cột phù hợp
                if (selected == "Khoa")
                {
                    cbValue.Items.Add(row["MaKhoa"].ToString());
                    lblValue1.Text = "Chọn Khoa:";
                }
                else if (selected == "Lớp")
                {
                    cbValue.Items.Add(row["Lop"].ToString());
                    lblValue1.Text = "Chọn Lớp:";
                }
                else if (selected == "Học kỳ")
                {
                    cbValue.Items.Add(row["HocKy"].ToString());
                    lblValue2.Text = "Chọn Học kỳ:";
                }
                else if (selected == "Năm học")
                {
                    cbValue.Items.Add(row["NamHoc"].ToString());
                    lblValue2.Text = "Chọn Năm học:";
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cbFilter1.SelectedItem == null || cbValue1.SelectedItem == null ||
                cbFilter2.SelectedItem == null || cbValue2.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đủ các tiêu chí lọc!");
                return;
            }

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
                else yeu++;
            }

            // Hiển thị lên chart            
            chartHocLuc.Series.Clear();
            var s = chartHocLuc.Series.Add("Học lực");
            s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            s.IsValueShownAsLabel = true;
            s.Label = "#VALX: #PERCENT{P1}";    // 👈 Hiển thị phần trăm chính xác
            s.LegendText = "#VALX (#VALY)";     // 👈 Hiển thị tên và số lượng trong chú thích
            s["PieLabelStyle"] = "Outside";     // 👈 Đưa nhãn ra ngoài
            s["PieLineColor"] = "Gray";         // 👈 Kẻ đường nối nhãn
            s.Points.AddXY("Giỏi", gioi);
            s.Points.AddXY("Khá", kha);
            s.Points.AddXY("Trung bình", tb);
            s.Points.AddXY("Yếu", yeu);
            for (int i = s.Points.Count - 1; i >= 0; i--)
            {
                if (s.Points[i].YValues[0] == 0)
                    s.Points.RemoveAt(i);
            }

        }
    }
}
