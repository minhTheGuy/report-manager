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


        private object[] GetReportInfo(string status)
        {
            return new object[] {
                AccountSession.Id, // @giangVienId
                txtReportName.Text, // @TieuDeTC
                txtReportName.Text, // @TieuDeBB
                AccountSession.Faculty, // @MaKhoa
                txtPublishNumber.Text, // @SoPH
                txtPublishNumber.Text, // @STBD
                txtPublishNumber.Text, // @STKT
                DateTime.Now, // @NamXB
                DateTime.Now, // @NgayNop
                DateTime.Now, // @NgayXuLy
                txtLink.Text, // @LinkBB
                "MH01", // @MaMH
                txtDOI.Text, // @DOI
                status, // @TrangThai
                txtDOI.Text, // @GhiChu
            };
        }

        private void Cancel_Report(object sender, EventArgs e)
        {
            bool result = BUS_GiangVien.Instance.InsertReportByGiangVien(GetReportInfo("store"));

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
            bool result = BUS_GiangVien.Instance.InsertReportByGiangVien(GetReportInfo("submitted"));

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
