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
using ArticleManagementApp.DTO;
using ArticleManagementApp.GUI.Components;
using ArticleManagementApp.GUI.GiangVien.Controls;
using Guna.Charts.WinForms;

namespace ArticleManagementApp.GUI.GiamSat.Controls
{
    public partial class ReportDashboard : UserControl
    {
        private GiamSatSearchBar searchBar;

        public ReportDashboard()
        {
            InitializeComponent();

            searchBar = new GiamSatSearchBar();
            searchBar.Dock = DockStyle.Fill;
            searchBarContainer.Controls.Add(searchBar);

            LoadGrid();
            LoadBarChart();
            LoadDoghnutChart();
        }

        private void LoadGrid()
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
            dataset.BorderColor = Color.Purple;

            var dataset2 = new Guna.Charts.WinForms.GunaSplineDataset();
            dataset2.PointRadius = 3;
            dataset2.PointStyle = PointStyle.Circle;
            dataset2.BorderColor = Color.Green;

            var dataset3 = new Guna.Charts.WinForms.GunaSplineDataset();
            dataset3.PointRadius = 3;
            dataset3.PointStyle = PointStyle.Circle;
            dataset3.BorderColor = Color.Red;

            var r = new Random();
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                dataset.DataPoints.Add(months[i], num);
                dataset2.DataPoints.Add(months[i], num - 10);
                dataset3.DataPoints.Add(months[i], num - 20);
            }

            totalGiangVienLineChart.Datasets.Add(dataset);
            totalSubmittedReportLineChart.Datasets.Add(dataset2);
            totalPublishedReportLineChart.Datasets.Add(dataset3);

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
                // set color for each faculty
            }

            facultyRankBarChart.Datasets.Add(dataset);
            facultyRankBarChart.Legend.Display = false;

            facultyRankBarChart.Update();
        }

        private void LoadDoghnutChart()
        {
            // Set up GunaDoughnutDataset
            string[] months = { "CNTT", "D-DT", "NN", "KHXH&VN", "KHUD", "KHTT", "KTCT" };

            //Chart configuration  
            totalReportDoughnutChart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Bottom;
            totalReportDoughnutChart.XAxes.Display = false;
            totalReportDoughnutChart.YAxes.Display = false;

            var dataset = new Guna.Charts.WinForms.GunaDoughnutDataset();
            //Create a new dataset 
            var r = new Random();
            int total = 0;
            for (int i = 0; i < months.Length; i++)
            {
                int num = r.Next(10, 100);
                total += num;
                dataset.DataPoints.Add(months[i], num);
            }

            totalReportDoughnutChart.Datasets.Add(dataset);
            totalReportDoughnutChart.Update();
        }
    }
}
