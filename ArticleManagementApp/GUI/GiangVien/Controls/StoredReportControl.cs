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
using Guna.UI2.WinForms;
using static ArticleManagementApp.DTO.Models;

namespace ArticleManagementApp.GUI.GiangVien.Controls
{
    public partial class StoredReportControl : UserControl
    {

        private SearchBar searchBar;
        public StoredReportControl()
        {
            InitializeComponent();

            searchBar = new SearchBar();
            searchBar.Search += Do_Search;
            searchBarContainer.Controls.Add(searchBar);
            guna2Transition1.Hide(reportSearchList);

            LoadStoredReport();
        }

        private void LoadStoredReport()
        {
            // filter reports by TrangThai
            List<Models.BaiBao> reports = BUS_GiangVien.Instance.GetReportsByStatus(AccountSession.Email, "stored");

            if (reports.Count == 0)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Không có bài báo nào được lưu trữ :(";
                return;
            }

            foreach (Models.BaiBao report in reports)
            {
                Image image = null;

                switch (report.TrangThai)
                {
                    case "published":
                        image = Image.FromFile(@"C:\Users\Admin\Downloads\success_status.png");
                        break;
                    case "need re-check":
                    case "pending":
                        image = Image.FromFile(@"C:\Users\Admin\Downloads\warning_status.png");
                        break;
                    default:
                        image = Image.FromFile(@"C:\Users\Admin\Downloads\danger_status.png");
                        break;
                }

                reportList.Rows.Add(report.ID, report.TenBaiBao, report.NgayNop, report.NgayXuLy, image);
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
