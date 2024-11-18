using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ArticleManagementApp.DAO;
using ArticleManagementApp.GUI.Components;
using Guna.Charts.WinForms;

namespace ArticleManagementApp.GUI.GiamSat.Controls
{
    public partial class GiamSatHome : UserControl
    {
        private GiamSatSearchBar searchBar;

        public GiamSatHome()
        {
            InitializeComponent();

            searchBar = new GiamSatSearchBar();
            searchBar.Dock = DockStyle.Fill;
            searchBarContainer.Controls.Add(searchBar);

            dashboardContainer.Controls.Add(new GiamSatDashboard());
            LoadChart();
        }

        private void LoadChart()
        {
            int[] months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            var dataTable = DAOGiamSat.Instance.GetGiamSatDashboardStatisticByYear(DateTime.Now.Year);
            var data = new Hashtable();

            foreach (DataRow row in dataTable.Rows)
            {
                data.Add(int.Parse(row["month"].ToString()), row);
            }

            dashboardChart.YAxes.GridLines.Display = false;
            dashboardChart.XAxes.GridLines.Display = false;


            GunaSplineDataset dataset1 = new GunaSplineDataset();
            dataset1.Label = "Tổng số giảng viên";
            dataset1.BorderColor = Color.FromArgb(155, Color.Red);
            dataset1.FillColor = Color.FromArgb(155, Color.Red);
            dataset1.PointRadius = 2;

            GunaSplineDataset dataset2 = new GunaSplineDataset();
            dataset2.Label = "Tổng số bài báo";
            dataset2.BorderColor = Color.FromArgb(155, Color.Blue);
            dataset2.FillColor = Color.FromArgb(155, Color.Blue);
            dataset2.PointRadius = 2;

            GunaSplineDataset dataset3 = new GunaSplineDataset();
            dataset3.Label = "Tổng số giờ viết bài";
            dataset3.BorderColor = Color.FromArgb(155, Color.Green);
            dataset3.FillColor = Color.FromArgb(155, Color.Green);
            dataset3.PointRadius = 2;

            for (int i = 0; i < months.Length; i++)
            {
                if (data.ContainsKey(months[i]))
                {
                    DataRow row = (DataRow)data[months[i]];
                    dataset1.DataPoints.Add($"Tháng {months[i]}", int.Parse(row["totalGiangVien"].ToString()));
                    dataset2.DataPoints.Add($"Tháng {months[i]}", int.Parse(row["totalReports"].ToString()) + 500);
                    dataset3.DataPoints.Add($"Tháng {months[i]}", int.Parse(row["totalSoGio"].ToString()));
                    continue;
                }

                dataset1.DataPoints.Add($"Tháng {months[i]}", 0);
                dataset2.DataPoints.Add($"Tháng {months[i]}", 0);
                dataset3.DataPoints.Add($"Tháng {months[i]}", 0);
            }

            dashboardChart.Datasets.Add(dataset1);
            dashboardChart.Datasets.Add(dataset2);
            dashboardChart.Datasets.Add(dataset3);

            dashboardChart.Legend.Display = true;
            dashboardChart.Update();
        }
    }
}
