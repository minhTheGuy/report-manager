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
using ArticleManagementApp.DTO;
using ArticleManagementApp.GUI.GiamSat.Controls;
using Guna.UI2.WinForms;

namespace ArticleManagementApp.GUI.GiangVien.Controls
{
    public partial class AccountInfo : UserControl
    {
        private SearchBar searchBar;
        private string id;
        public AccountInfo(string type, string id = "")
        {
            InitializeComponent();

            if (type.Equals("giangVien") || type.Equals("kiemDuyet"))
            {
                searchBar = new SearchBar();
                searchBar.Dock = DockStyle.Top;
                searchBar.Search += Do_Search;
                searchBarContainer.Controls.Add(searchBar);
            }
            else
            {
                GiamSatSearchBar giamSatSearchBar = new GiamSatSearchBar();
                giamSatSearchBar.Dock = DockStyle.Top;
                searchBarContainer.Controls.Add(giamSatSearchBar);
            }

            guna2Transition1.Hide(reportSearchList);
            this.id = id;
            LoadAccountInfo();
        }

        private void LoadAccountInfo()
        {
            DataRow dt;
            dt = BUS_GiangVien.Instance.GetGiangVienInfoById(AccountSession.Id);
            txtMaGV.Text = dt["MaGV"].ToString();
            txtMaGV.Enabled = false;
            txtName.Text = dt["HoTenGV"].ToString();
            txtHocVi.Text = dt["HocVi"].ToString();
            txtHocHam.Text = dt["HocHam"].ToString();
            txtTotalReports.Text = dt["SLBB"].ToString();
            txtTotalTime.Text = dt["SoGio"].ToString();
            guna2CirclePictureBox1.Image = Image.FromStream(new System.IO.MemoryStream((byte[])dt["ADD"]));
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            return;

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

        private void ChangeAvatar(object sender, EventArgs e)
        {
            // open file dialog to choose image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get image path
                string imagePath = openFileDialog.FileName;
                byte[] bytes = System.IO.File.ReadAllBytes(imagePath);
                BUS_GiangVien.Instance.ChangeAvatarGV(AccountSession.Id, bytes);
                MessageBox.Show("Đổi avatar thành công!");
            }
        }

        private void Update_Info(object sender, EventArgs e)
        {
            BUS_GiangVien.Instance.UpdateInforGV(new object[] { AccountSession.Id, txtName.Text, txtHocHam.Text, txtHocVi.Text });
            MessageBox.Show("Cập nhật thông tin thành công!");
        }
    }
}
