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
                    giangVienHomeContainter.Controls.Add(new ReportList("submitted", "giangVien"));
                    break;
                case "pending":
                    btnProcessingReport.Checked = true;
                    giangVienHomeContainter.Controls.Add(new ReportList("pending", "giangVien"));
                    break;
                case "published":
                    btnProcessedReport.Checked = true;
                    giangVienHomeContainter.Controls.Add(new ReportList("published", "giangVien"));
                    break;
                case "stored":
                    btnStoreReport.Checked = true;
                    giangVienHomeContainter.Controls.Add(new ReportList("stored", "giangVien"));
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
            giangVienHomeContainter.Controls.Add(new ReportList("stored", "giangVien"));
        }

        private void Go_SubmittedReport(object sender, EventArgs e)
        {
            giangVienHomeContainter.Controls.Clear();
            giangVienHomeContainter.Controls.Add(new GiangVienReportList("submitted"));
        }

        private void Go_PendingReport(object sender, EventArgs e)
        {
            giangVienHomeContainter.Controls.Clear();
            giangVienHomeContainter.Controls.Add(new GiangVienReportList("pending"));
        }

        private void Go_PublishedReport(object sender, EventArgs e)
        {
            giangVienHomeContainter.Controls.Clear();
            giangVienHomeContainter.Controls.Add(new GiangVienReportList("published"));
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
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
