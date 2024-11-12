using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArticleManagementApp.BUS;
using ArticleManagementApp.DAO;
using ArticleManagementApp.DTO;
using Guna.Charts.WinForms;
using Guna.UI2.WinForms;

namespace ArticleManagementApp.GUI.GiangVien.Controls
{
    public partial class GiangVienHomeControl : UserControl
    {
        private SearchBar searchBar;

        public GiangVienHomeControl()
        {
            InitializeComponent();

            searchBar = new SearchBar();
            searchBar.Search += Do_Search;
            searchBarContainer.Controls.Add(searchBar);

            LoadSampleData();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            List<string> dashboardData = BUS_GiangVien.Instance.GetGiangVienDashboardData();
            label7.Text = dashboardData[0] + " Bài báo";
            label8.Text = dashboardData[1] + " Hours";
            label9.Text = dashboardData[2] + " Bài báo";
            label10.Text = dashboardData[3] + " Bài báo";
        }

        private void LoadSampleData()
        {
            LoadChart();
            LoadDataGrid();
        }

        private void LoadChart()
        {
            int[] months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            var dataTable = DAOGiangVien.Instance.GetReportStatisticByYear(DateTime.Now.Year, AccountSession.Id);
            var data = new Hashtable();

            foreach (DataRow row in dataTable.Rows)
            {
                data.Add(int.Parse(row["Month"].ToString()), int.Parse(row["TotalReports"].ToString()));
            }

            numOfReportChart.YAxes.GridLines.Display = false;
            numOfReportChart.XAxes.GridLines.Display = false;

            //Create a new dataset 
            int totalReports = 0;

            var dataset = new GunaAreaDataset();
            dataset.FillColor = Color.FromArgb(75, Color.Blue); // 70% opacity

            for (int i = 0; i < months.Length; i++)
            {
                int num = 0;
                if (data.ContainsKey(months[i]))
                {
                    num = (int)data[months[i]];
                    totalReports += num;
                }

                dataset.DataPoints.Add($"Tháng {months[i]}", num);
            }

            lblYearlyReportNum.Text = totalReports.ToString();
            numOfReportChart.Datasets.Add(dataset);
            numOfReportChart.Legend.Display = false;
            numOfReportChart.Update();
        }
        private void LoadDataGrid()
        {
            guna2Transition1.Hide(reportSearchList);

            List<Models.BaiBao> reports = BUS_GiangVien.Instance.GetReportsByEmail(AccountSession.Email);
            foreach (Models.BaiBao report in reports)
            {
                Image image = null;
                if (report.TrangThai.Equals("published"))
                {
                    image = Image.FromFile(@"C:\Users\Admin\Downloads\success_status.png");
                }
                else if (report.TrangThai.Equals("need re-check") || report.TrangThai.Equals("pending"))
                {
                    image = Image.FromFile(@"C:\Users\Admin\Downloads\warning_status.png");
                }
                else
                {
                    image = Image.FromFile(@"C:\Users\Admin\Downloads\success_status.png");
                }

                reportList.Rows.Add(report.ID, report.TenBaiBao, report.NgayNop, report.NgayXuLy, image);
            }
        }

        private void Go_ShowReportDetail(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: Implement this method
            if (reportList.Columns["ThaoTac"].Index != null && e.ColumnIndex == reportList.Columns["ThaoTac"].Index)
            {
                int reportId = int.Parse(reportList.Rows[e.RowIndex].Cells["id"].Value.ToString());
                this.Controls.Clear();
                this.Controls.Add(new GiangVienReportDetailControl(reportId));
            }
        }

        private void guna2DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in reportList.Rows)
            {
                if (row.Cells["TrangThai"].Value != null && row.Cells["TrangThai"].Value.ToString().Equals("Đã xuất bản"))
                {
                    row.Cells["TrangThai"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    row.Cells["TrangThai"].Style.BackColor = Color.LightCoral;
                }
            }
        }

        private void Do_Search(object sender, EventArgs e)
        {

            List<Models.BaiBao> baiBaos = BUS_GiangVien.Instance.GetReportsByEmail(AccountSession.Email);
            List<Models.BaiBao> filteredBaiBaos = new List<Models.BaiBao>();

            foreach (Models.BaiBao baiBao in baiBaos)
            {

                if (baiBao.TenBaiBao.ToLower().Contains(searchBar.SearchKey.ToLower()))
                {
                    filteredBaiBaos.Add(baiBao);
                }
            }

            if (filteredBaiBaos.Count == 0)
            {
                guna2Transition1.Hide(reportSearchList);
                return;
            }

            reportSearchList.Rows.Clear();
            foreach (Models.BaiBao baiBao in filteredBaiBaos)
            {
                Image image = null;
                if (baiBao.TrangThai.Equals("published"))
                {
                    image = Image.FromFile(@"C:\Users\Admin\Downloads\success_status.png");
                }
                else if (baiBao.TrangThai.Equals("need re-check") || baiBao.TrangThai.Equals("pending"))
                {
                    image = Image.FromFile(@"C:\Users\Admin\Downloads\warning_status.png");
                }
                else
                {
                    image = Image.FromFile(@"C:\Users\Admin\Downloads\success_status.png");
                }

                reportSearchList.Rows.Add(baiBao.ID, baiBao.TenBaiBao, baiBao.NgayNop, baiBao.NgayXuLy, image);
            }

            guna2Transition1.ShowSync(reportSearchList);
        }
    }
}
