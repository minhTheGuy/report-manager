using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArticleManagementApp.BUS;
using ArticleManagementApp.DTO;
using Guna.UI2.WinForms;

namespace ArticleManagementApp.GUI.GiangVien.Controls
{
    public partial class GiangVienAddReportControl : UserControl
    {
        private SearchBar searchBar;

        public GiangVienAddReportControl()
        {
            InitializeComponent();
            searchBar = new SearchBar();
            searchBar.Search += Do_Search;
            searchBarContainer.Controls.Add(searchBar);

            guna2Transition1.Hide(reportSearchList);
        }


        private object[] GetReportInfo()
        {
            // get byte[] from image
            byte[] bytes = File.ReadAllBytes(txtFilePath.Text);
            return new object[] {
                txtReportName.Text, // @TenBB
                txtOrigin.Text, // @NoiDangBai
                txtMainAuthor.Text, // @TacGiaChinh
                txtAuthors.Text, // @TacGiaHoTro
                txtLink.Text, // @LinkBB
                txtFacultyCode.Text, // @MaKhoa
                txtPublishNumber.Text, // @SoPH
                txtNumPages.Text, // @SoTrang
                datePickerPublishDate.Value, // @NgayXB
                txtDOI.Text, // @DOI
                txtCourseCode.Text, // @MaMH
                bytes,
            };
        }

        private void Cancel_Report(object sender, EventArgs e)
        {
            bool result = BUS_GiangVien.Instance.InsertReportByGiangVien(GetReportInfo());

            if (result)
            {
                MessageBox.Show("Bài báo đã được lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Controls.Clear();
                this.Controls.Add(new GiangVienHomeControl());
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Do_Submit(object sender, EventArgs e)
        {
            bool result = BUS_GiangVien.Instance.InsertReportByGiangVien(GetReportInfo());

            if (result)
            {
                MessageBox.Show("Bài báo đã được nộp thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Controls.Clear();
                this.Controls.Add(new GiangVienHomeControl());
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BrowseImage(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.Title = "Chọn minh chứng bài báo";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // set image to picture box
                txtFilePath.Text = openFileDialog.FileName;
            }
        }
    }
}
