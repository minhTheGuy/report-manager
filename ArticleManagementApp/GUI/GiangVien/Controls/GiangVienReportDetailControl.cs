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

namespace ArticleManagementApp.GUI.GiangVien.Controls
{
    public partial class GiangVienReportDetailControl : UserControl
    {
        private SearchBar searchBar;
        public GiangVienReportDetailControl(int reportId)
        {
            InitializeComponent();

            searchBar = new SearchBar();
            searchBar.Search += Do_Search;
            searchBarContainer.Controls.Add(searchBar);
            guna2Transition1.Hide(reportSearchList);

            LoadReportInfo(reportId);
        }


        private void LoadReportInfo(int id)
        {
            DataRow reportInfo = BUS_GiangVien.Instance.GetReportById(id);
            DataTable authors = BUS_GiangVien.Instance.GetGiangVienByReportId(id);
            txtReportName.Text = reportInfo["TenBB"].ToString();
            txtOrigin.Text = reportInfo["STBD"].ToString();
            foreach (DataRow author in authors.Rows)
            {
                if (author["VaiTro"].ToString().Equals("Chính"))
                {
                    txtMainAuthor.Text = author["HoTenGV"].ToString();
                    continue;
                }
                txtAuthors.Text += author["HoTenGV"].ToString() + ", ";
            }
            txtLink.Text = reportInfo["LinkBB"].ToString();
            txtPublishNumber.Text = reportInfo["SoPH"].ToString();
            txtNumPages.Text = reportInfo["STKT"].ToString();
            datePickerPublishDate.Text = reportInfo["NgayXB"].ToString();
            txtDOI.Text = reportInfo["DOI"].ToString();
            byte[] bytes = (byte[])reportInfo["MinhChung"];
            MemoryStream ms = new MemoryStream(bytes);
            minhChungFile.Image = Image.FromStream(ms);
            txtFacultyCode.Text = reportInfo["MaKhoa"].ToString();
            txtCourseCode.Text = reportInfo["MaMH"].ToString();

            txtReportName.Enabled = false;
            txtOrigin.Enabled = false;
            txtMainAuthor.Enabled = false;
            txtAuthors.Enabled = false;
            txtLink.Enabled = false;
            txtPublishNumber.Enabled = false;
            txtNumPages.Enabled = false;
            datePickerPublishDate.Enabled = false;
            txtDOI.Enabled = false;
        }

        private void Go_Home(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new GiangVienHomeControl());
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

        private void lblFacultyCode_Click(object sender, EventArgs e)
        {

        }

        private void txtFacultyCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Image(object sender, EventArgs e)
        {
            // show image in new form
            Form form = new Form();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(minhChungFile.Image.Size.Height, minhChungFile.Image.Size.Width);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = minhChungFile.Image;
            form.Controls.Add(pictureBox);
            form.ShowDialog();
        }
    }
}
