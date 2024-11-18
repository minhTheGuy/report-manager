using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArticleManagementApp.GUI.Components;
using ArticleManagementApp.GUI.GiamSat.Controls;
using ArticleManagementApp.GUI.GiangVien.Controls;

namespace ArticleManagementApp.GUI.KiemDuyet.Controls
{
    public partial class GiamSatContainer : Form
    {
        public GiamSatContainer(string action)
        {
            InitializeComponent();

            switch (action)
            {
                case "home":
                    btnHome.Checked = true;
                    Go_Home(null, null);
                    break;
                case "timeDashboard":
                    btnTimeDashboard.Checked = true;
                    Go_TimeDashboard(null, null);
                    break;
                case "reportDashboard":
                    btnReportDashboard.Checked = true;
                    Go_ReportDashboard(null, null);
                    break;
                case "accountInfo":
                    btnInfo.Checked = true;
                    Go_AccounntInfo(null, null);
                    break;
                case "giangVien":
                    btnGiangVienList.Checked = true;
                    Go_GiangVienList(null, null);
                    break;
                default:
                    break;
            }
        }

        private void Go_GiangVienList(object sender, EventArgs e)
        {
            controlContainer.Controls.Clear();
            GiangVienList giangVienList = new GiangVienList();
            giangVienList.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(giangVienList);
        }

        private void Go_Home(object sender, EventArgs e)
        {
            controlContainer.Controls.Clear();
            GiamSatHome giamSatHome = new GiamSatHome();
            giamSatHome.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(giamSatHome);
        }

        private void Go_ReportDashboard(object sender, EventArgs e)
        {
            controlContainer.Controls.Clear();
            ReportDashboard giamSatReportDashboard = new ReportDashboard();
            giamSatReportDashboard.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(giamSatReportDashboard);
        }

        private void Go_TimeDashboard(object sender, EventArgs e)
        {
            controlContainer.Controls.Clear();
            TimeDashboard giamSatTimeDashboard = new TimeDashboard();
            giamSatTimeDashboard.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(giamSatTimeDashboard);
        }

        private void Go_AccounntInfo(object sender, EventArgs e)
        {
            controlContainer.Controls.Clear();
            GiamSatAccountInfo accountInfo = new GiamSatAccountInfo("giamSat");
            accountInfo.Dock = DockStyle.Fill;
            controlContainer.Controls.Add(accountInfo);
        }

        private void Logout(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                new Login().Show();
                this.Dispose();
            }
        }
    }
}
