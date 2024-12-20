﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArticleManagementApp.BUS;
using ArticleManagementApp.GUI.GiangVien.Controls;

namespace ArticleManagementApp.GUI.KiemDuyet.Controls
{
    public partial class KiemDuyetReportDashboard : UserControl
    {
        private SearchBar searchBar;

        public KiemDuyetReportDashboard()
        {
            InitializeComponent();

            searchBar = new SearchBar();
            searchBar.Dock = DockStyle.Fill;
            searchBarContainer.Controls.Add(searchBar);
        }

        private void Show_SubmittedReport(object sender, DataGridViewCellEventArgs e)
        {
            DataTable data = BUS_KiemDuyet.Instance.GetAllReports();
            reportList.DataSource = data;
        }
    }
}
