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
            string maND = txtUsername.Text;
            string password = txtPassword.Text;

            if (BUS_Login.Instance.Login(maND, password))
            {
                this.Hide();
                switch (BUS_Login.Instance.CheckRole(maND))
                {
                    case 1:
                        BUS_GiangVien.Instance.SetGiangVienSession(maND);
                        GiangVienContainer gvHome = new("home");
                        gvHome.ShowDialog();
                        break;
                    case 2:
                        BUS_KiemDuyet.Instance.SetKiemDuyetSession(maND);
                        KiemDuyetContainer kdHome = new("home");
                        kdHome.ShowDialog();
                        break;
                    case 3:
                        // TODO: implement this
                        BUS_GiamSat.Instance.SetGiamSatSession(maND);
                        GiamSatContainer gsHome = new("home");
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
