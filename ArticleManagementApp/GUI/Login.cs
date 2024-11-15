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
using ArticleManagementApp.DAO;
using ArticleManagementApp.GUI.KiemDuyet.Controls;

namespace ArticleManagementApp.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Do_Login(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            if (BUS_Login.Instance.Login(email, password))
            {
                this.Hide();
                switch (BUS_Login.Instance.CheckRole(email))
                {
                    case 1:
                        BUS_GiangVien.Instance.SetGiangVienSession(email);
                        GiangVienContainer gvHome = new("home");
                        gvHome.ShowDialog();
                        break;
                    case 3:
                        BUS_KiemDuyet.Instance.SetKiemDuyetSession(email);
                        KiemDuyetContainer kdHome = new("home");
                        kdHome.ShowDialog();
                        break;
                    case 2:
                        // TODO: implement this
                        BUS_KiemDuyet.Instance.SetKiemDuyetSession(email);
                        GiamSatContainer gsHome = new();
                        gsHome.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            Application.Exit();
        }
    }
}
