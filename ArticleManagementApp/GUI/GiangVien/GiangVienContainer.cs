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

namespace ArticleManagementApp.GUI
{
    public partial class GiangVienContainer : Form
    {
        public GiangVienContainer(string action)
        {
            InitializeComponent();

            switch (action)
            {
                case "home":
                    btnHome.Checked = true;
                    giangVienHomeContainter.Controls.Add(new GiangVienHomeControl());
                    break;
                case "submitted":
                    btnSubmittedReport.Checked = true;
                    giangVienHomeContainter.Controls.Add(new ReportList("submitted"));
                    break;
                case "pending":
                    btnProcessingReport.Checked = true;
                    giangVienHomeContainter.Controls.Add(new ReportList("pending"));
                    break;
                case "published":
                    btnProcessedReport.Checked = true;
                    giangVienHomeContainter.Controls.Add(new ReportList("published"));
                    break;
                case "stored":
                    btnStoreReport.Checked = true;
                    giangVienHomeContainter.Controls.Add(new ReportList("stored"));
                    break;
                case "account":
                    btnInfo.Checked = true;
                    giangVienHomeContainter.Controls.Add(new AccountInfo("giangVien"));
                    break;
                default:
                    break;
            }
        }

        private void Go_Home(object sender, EventArgs e)
        {
            giangVienHomeContainter.Controls.Clear();
            giangVienHomeContainter.Controls.Add(new GiangVienHomeControl());
        }

        private void Go_AddReportForm(object sender, EventArgs e)
        {
            giangVienHomeContainter.Controls.Clear();
            giangVienHomeContainter.Controls.Add(new GiangVienAddReportControl());
        }

        private void Go_StoredReport(object sender, EventArgs e)
        {
            giangVienHomeContainter.Controls.Clear();
            giangVienHomeContainter.Controls.Add(new ReportList("stored"));
        }

        private void Go_SubmittedReport(object sender, EventArgs e)
        {
            giangVienHomeContainter.Controls.Clear();
            giangVienHomeContainter.Controls.Add(new ReportList("submitted"));
        }

        private void Go_PendingReport(object sender, EventArgs e)
        {
            giangVienHomeContainter.Controls.Clear();
            giangVienHomeContainter.Controls.Add(new ReportList("pending"));
        }

        private void Go_PublishedReport(object sender, EventArgs e)
        {
            giangVienHomeContainter.Controls.Clear();
            giangVienHomeContainter.Controls.Add(new ReportList("published"));
        }

        private void Go_AccountInfo(object sender, EventArgs e)
        {
            giangVienHomeContainter.Controls.Clear();
            giangVienHomeContainter.Controls.Add(new AccountInfo("giangVien"));
        }

        private void GiangVienContainer_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
