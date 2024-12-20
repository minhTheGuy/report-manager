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
using ArticleManagementApp.DTO;

namespace ArticleManagementApp.GUI.GiangVien.Controls
{
    public partial class ReportList : UserControl
    {
        private SearchBar searchBar;
        public ReportList(string status, string role)
        {
            InitializeComponent();

            searchBar = new SearchBar();
            searchBar.Search += Do_Search;
            searchBarContainer.Controls.Add(searchBar);

            switch (status)
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
            if (role.Equals("giangVien"))
            {
                Load_ReportList(status);
            }
            else
            {
                Load_ReportList(status, "kiemDuyet");
            }
        }

        private void Load_ReportList(string status, string role = null)
        {
            if (role == null)
            {
                List<Models.BaiBao> baiBaos = BUS_GiangVien.Instance.GetReportsById(AccountSession.Id);

                foreach (Models.BaiBao baiBao in baiBaos)
                {
                    if (!baiBao.TrangThai.Equals(status))
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
            }
            else
            {
                List<Models.BaiBao> baiBaos = BUS_KiemDuyet.Instance.GetSubmittedReports();
                foreach (Models.BaiBao baiBao in baiBaos)
                {
                    if (!baiBao.TrangThai.Equals(status))
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
    }
}
