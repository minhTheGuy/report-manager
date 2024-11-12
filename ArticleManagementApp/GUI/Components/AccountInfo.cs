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
using Guna.UI2.WinForms;

namespace ArticleManagementApp.GUI.GiangVien.Controls
{
    public partial class AccountInfo : UserControl
    {
        private SearchBar searchBar;

        public AccountInfo()
        {
            InitializeComponent();

            searchBar = new SearchBar();
            searchBar.Search += Do_Search;
            searchBar.Dock = DockStyle.Fill;
            searchBarContainer.Controls.Add(searchBar);

            guna2Transition1.Hide(reportSearchList);
            LoadAccountInfo();
        }

        private void LoadAccountInfo()
        {
            DataRow dt = BUS_GiangVien.Instance.GetGiangVienInfoByEmail(AccountSession.Email);
            txtName.Text = dt["name"].ToString();
            txtEmail.Text = dt["email"].ToString();
            txtDegree.Text = dt["hocvi"].ToString();
            txtFaculty.Text = dt["khoa"].ToString();
            txtPhoneNumber.Text = dt["PhoneNumber"].ToString();
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
