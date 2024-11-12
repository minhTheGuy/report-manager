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
using ArticleManagementApp.DAO;
using ArticleManagementApp.GUI.GiangVien.Controls;
using ArticleManagementApp.GUI.KiemDuyet.Controls;
using Guna.Charts.WinForms;

namespace ArticleManagementApp.GUI
{
    public partial class KiemDuyetContainer : Form
    {

        public KiemDuyetContainer(string action)
        {
            InitializeComponent();

            switch (action)
            {
                case "home":
                    btnHome.Checked = true;
                    KiemDuyetHomeControl homeControl = new KiemDuyetHomeControl();
                    homeControl.Dock = DockStyle.Fill;
                    controlContainer.Controls.Add(homeControl);
                    break;
                case "submittedReport":
                    btnReports.Checked = true;
                    break;
                case "acceptedReport":
                    // TODO: Add accepted report control
                    break;
                case "rejectedReport":
                    // TODO: Add accepted report control

                    break;
                case "thongKeBB":
                    // TODO: Add accepted report control

                    break;
                default:
                    break;
            }
        }
        private void ThongKeBB_Click(object sender, EventArgs e)
        {
            if (btnReports.Checked)
            {
                guna2Transition1.ShowSync(dropdownContainer);
            }
            else
            {
                guna2Transition1.HideSync(dropdownContainer);
            }

        }

        private void Go_Home(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(dropdownContainer);

            controlContainer.Controls.Clear();
            KiemDuyetHomeControl homeControl = new KiemDuyetHomeControl();
            homeControl.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(homeControl);

        }

        private void Go_ReportDashboard(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(dropdownContainer);

            controlContainer.Controls.Clear();
            KiemDuyetReportDashboard reportDashboard = new KiemDuyetReportDashboard();
            reportDashboard.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(reportDashboard);
        }

        private void Go_AccountInfo(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(dropdownContainer);

            controlContainer.Controls.Clear();
            AccountInfo accountInfo = new AccountInfo();
            accountInfo.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(accountInfo);
        }

        private void Go_PublishedReport(object sender, EventArgs e)
        {
            controlContainer.Controls.Clear();
            ReportList reportList = new ReportList("published");
            reportList.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(reportList);
        }

        private void Go_SubmittedReport(object sender, EventArgs e)
        {
            controlContainer.Controls.Clear();
            ReportList reportList = new ReportList("submitted");
            reportList.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(reportList);
        }

        private void Go_PendingReport(object sender, EventArgs e)
        {
            controlContainer.Controls.Clear();
            ReportList reportList = new ReportList("pending");
            reportList.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(reportList);
        }
    }
}
