using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArticleManagementApp.BUS;
using ArticleManagementApp.GUI.GiangVien.Controls;
using Guna.Charts.WinForms;
using Guna.UI2.WinForms;

namespace ArticleManagementApp.GUI.KiemDuyet.Controls
{
    public partial class KiemDuyetHomeControl : UserControl
    {
        private SearchBar searchBar;
        private Timer timer;
        private bool isHovering;
        public KiemDuyetHomeControl()
        {
            InitializeComponent();

            searchBar = new SearchBar();
            searchBar.Dock = DockStyle.Fill;
            searchBarContainer.Controls.Add(searchBar);

            this.timer = new Timer();
            timer.Interval = 1; // Adjust the interval for smoother transition
            timer.Tick += new System.EventHandler(OnTimerTick);

            LoadSampleData();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            List<string> dashboardData = BUS_GiangVien.Instance.GetGiangVienDashboardData();
            label7.Text = dashboardData[0] + " Bài báo";
            label8.Text = dashboardData[1] + " Hours";
            label9.Text = dashboardData[2] + " Bài báo";
        }

        private void LoadSampleData()
        {
            LoadDataGrid();
            LoadBarChart();
            LoadDoughnutChart();
            LoadLineChart();
        }

        private void LoadDataGrid()
        {
            //guna2DataGridView1.DataSource = BUS_KiemDuyet.Instance.GetAllReports();
            //// exclude the first column (id)
            //guna2DataGridView1.Columns[0].Visible = false;
            //DataGridViewButtonColumn btn = new()
            //{
            //    Name = "view",
            //    HeaderText = "Thao tác",
            //    Text = "Xem",
            //    UseColumnTextForButtonValue = true
            //};
            //guna2DataGridView1.Columns.Add(btn);
        }

        private void LoadLineChart()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July" };

            totalGiangVienLineChart.YAxes.GridLines.Display = false;
            totalSubmittedReportLineChart.YAxes.GridLines.Display = false;
            totalPublishedReportLineChart.YAxes.GridLines.Display = false;

            totalGiangVienLineChart.XAxes.Display = false;
            totalSubmittedReportLineChart.XAxes.Display = false;
            totalPublishedReportLineChart.XAxes.Display = false;

            totalGiangVienLineChart.YAxes.Display = false;
            totalSubmittedReportLineChart.YAxes.Display = false;
            totalPublishedReportLineChart.YAxes.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaSplineDataset();
            dataset.PointRadius = 3;
            dataset.PointStyle = PointStyle.Circle;
            var r = new Random();
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                dataset.DataPoints.Add(months[i], num);
            }

            totalGiangVienLineChart.Datasets.Add(dataset);
            totalSubmittedReportLineChart.Datasets.Add(dataset);
            totalPublishedReportLineChart.Datasets.Add(dataset);

            totalGiangVienLineChart.Legend.Display = false;
            totalSubmittedReportLineChart.Legend.Display = false;
            totalPublishedReportLineChart.Legend.Display = false;

            totalGiangVienLineChart.Update();
            totalSubmittedReportLineChart.Update();
            totalPublishedReportLineChart.Update();
        }

        private void LoadBarChart()
        {
            facultyRankBarChart.YAxes.GridLines.Display = false;
            // Set up GunaBarDataset


            GunaHorizontalBarDataset dataset = new Guna.Charts.WinForms.GunaHorizontalBarDataset();
            dataset.Label = "Số lượng bài bài báo";

            var faculties = BUS_KiemDuyet.Instance.GetReportDashboardForKhoa();
            foreach (DataRow faculty in faculties)
            {
                string facultyName = faculty["FacultyName"].ToString();
                double facultyReports = double.Parse(faculty["TotalReports"].ToString());
                dataset.DataPoints.Add(facultyName, facultyReports);
            }

            facultyRankBarChart.Datasets.Add(dataset);
            facultyRankBarChart.Legend.Display = false;

            facultyRankBarChart.Update();
        }

        private void LoadDoughnutChart()
        {
            string[] months = { "CNTT", "D-DT", "NN", "KHXH&VN", "KHUD", "KHTT", "KTCT" };

            //Chart configuration  
            totalReportDoughnutChart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            totalReportDoughnutChart.XAxes.Display = false;
            totalReportDoughnutChart.YAxes.Display = false;

            var dataset = new Guna.Charts.WinForms.GunaPieDataset();
            //Create a new dataset 
            var r = new Random();
            int total = 0;
            for (int i = 0; i < months.Length; i++)
            {
                int num = r.Next(10, 100);
                total += num;
                dataset.DataPoints.Add(months[i], num);
            }

            lblTotalReport.Text = total.ToString() + " Bài báo";

            totalReportDoughnutChart.Datasets.Add(dataset);
            totalReportDoughnutChart.Update();
        }

        private void Change_Color(object sender, EventArgs e)
        {
            guna2ColorTransition1 = new Guna2ColorTransition();
            guna2ColorTransition1.StartColor = Color.White;
            guna2ColorTransition1.EndColor = Color.DimGray;
            guna2ColorTransition1.ValueChanged += (s, e) =>
            {
                Guna2Panel panel = (Guna2Panel)sender;
                panel.BorderColor = this.guna2ColorTransition1.Value;
                panel.BorderThickness = 2;
            };

            isHovering = true;
            timer.Start();

        }

        private void Leave_Color(object sender, EventArgs e)
        {
            guna2ColorTransition1 = new Guna2ColorTransition();
            guna2ColorTransition1.StartColor = Color.White;
            guna2ColorTransition1.EndColor = Color.DimGray;
            guna2ColorTransition1.ValueChanged += (s, e) =>
            {
                Guna2Panel panel = (Guna2Panel)sender;
                // get child chart from the panel
                GunaChart chart = (GunaChart)panel.Controls[0];
            };

            isHovering = false;
            timer.Start();

        }

        private void OnTimerTick(object sender, System.EventArgs e)
        {
            if (isHovering)
            {
                guna2ColorTransition1.ProgressValue += 1;
                if (guna2ColorTransition1.ProgressValue >= 100)
                {
                    timer.Stop();
                }
            }
            else
            {
                guna2ColorTransition1.ProgressValue -= 1;
                if (guna2ColorTransition1.ProgressValue <= 0)
                {
                    timer.Stop();
                }
            }
        }
    }
}
