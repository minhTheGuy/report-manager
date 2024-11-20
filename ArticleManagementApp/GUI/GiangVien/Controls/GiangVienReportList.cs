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

namespace ArticleManagementApp.GUI.GiangVien.Controls
{
    public partial class GiangVienReportList : UserControl
    {
        private SearchBar searchBar;
        public GiangVienReportList(string status)
        {
            InitializeComponent();

            searchBar = new SearchBar();
            searchBar.Search += Do_Search;
            searchBarContainer.Controls.Add(searchBar);

            switch (status.ToLower())
            {
                case "submitted":
                    lblReportList.Text = "Bài báo đã nộp";
                    break;
                case "pending":
                    lblReportList.Text = "Bài báo đang chờ xử lý";
                    break;
                case "published":
                    lblReportList.Text = "Bài báo đã xuất bản";
                    break;
                case "stored":
                    lblReportList.Text = "Bài báo đã lưu";
                    reportGridView.Columns["TrangThai"].Visible = false;
                    break;
                default:
                    break;
            }

            guna2Transition1.Hide(reportSearchList);
            Load_ReportList(status);

        }

        private void Load_ReportList(string status)
        {
            List<Models.BaiBao> baiBaos = BUS_GiangVien.Instance.GetReportsById(AccountSession.Id);

            foreach (Models.BaiBao baiBao in baiBaos)
            {
                if (!baiBao.TrangThai.ToLower().Equals(status))
                {
                    continue;
                }

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

                reportGridView.Rows.Add(baiBao.ID, baiBao.TenBaiBao, baiBao.Location, image, baiBao.Note);
            }

            if (!status.Equals("published"))
            {
                reportGridView.Columns["Status"].Visible = false;
            }
        }

        private void Do_Search(object sender, EventArgs e)
        {

            List<Models.BaiBao> baiBaos = BUS_GiangVien.Instance.GetReportsById(AccountSession.Id);
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

                reportSearchList.Rows.Add(baiBao.ID, baiBao.TenBaiBao, baiBao.Location, image, baiBao.Note);
            }

            guna2Transition1.ShowSync(reportSearchList);
        }

        private void Go_ShowReportDetail(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: Implement this method
            if (reportGridView.Columns["ThaoTac"].Index != null && e.ColumnIndex == reportGridView.Columns["ThaoTac"].Index)
            {
                int reportId = int.Parse(reportGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
                this.Controls.Clear();
                this.Controls.Add(new GiangVienReportDetailControl(reportId));
            }
        }
    }
}
