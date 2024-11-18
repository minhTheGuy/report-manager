using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArticleManagementApp.GUI.GiamSat.Controls;

namespace ArticleManagementApp.GUI.Components
{
    public partial class GiamSatDashboard : UserControl
    {
        public static int totalGiangViens = 0;
        public static int totalReports = 0;
        public static DateTime selectedTime = DateTime.Now;
        public GiamSatDashboard()
        {
            InitializeComponent();

            totalGiangViens = int.Parse(label2.Text);
            totalReports = int.Parse(label3.Text);
            selectedTime = DateTime.Parse(dateTimePicker.Text);

            LoadDashboard();
        }

        private void LoadDashboard()
        {
            DataRow dataRow = BUS.BUS_GiamSat.Instance.GetGiamSatDashboard();
            label2.Text = dataRow["TotalGiangVien"].ToString();
            label3.Text = dataRow["TotalReports"].ToString();
            dateTimePicker.Text = selectedTime.ToString();
        }
    }
}
