using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SECOApp.DTO;

namespace SECOApp.GUI
{
    public partial class SubmittedReportPage : Form
    {
        public SubmittedReportPage()
        {
            InitializeComponent();

            // load sample data for testing
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // sample data
            BindingList<Models.BaiBao> sampleData =
            [
                new Models.BaiBao
                {
                    ID = "BG001",
                    TenBaiBao = "Bài giảng 1",
                    NgayNop = DateTime.Now,
                    NgayXuLy = DateTime.Now,
                    TrangThai = "Đã xử lý"
                },
                new Models.BaiBao
                {
                    ID = "BG002",
                    TenBaiBao = "Bài giảng 2",
                    NgayNop = DateTime.Now,
                    NgayXuLy = DateTime.Now,
                    TrangThai = "Đã xử lý"
                },
                new Models.BaiBao
                {
                    ID = "BG003",
                    TenBaiBao = "Bài giảng 3",
                    NgayNop = DateTime.Now,
                    NgayXuLy = DateTime.Now,
                    TrangThai = "Đã xử lý"
                }
            ];

            // bind sample data to grid view
            guna2DataGridView1.DataSource = sampleData;

            // add button column
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
            {
                Name = "view",
                HeaderText = "Thao tác",
                Text = "Xem",
                UseColumnTextForButtonValue = true,
            };

            guna2DataGridView1.Columns.Add(btnColumn);

            btnColumn = new DataGridViewButtonColumn
            {
                Name = "edit",
                HeaderText = "Thao tác",
                Text = "Sửa",
                UseColumnTextForButtonValue = true,
            };

            guna2DataGridView1.Columns.Add(btnColumn);


            btnColumn = new DataGridViewButtonColumn
            {
                Name = "delete",
                HeaderText = "Thao tác",
                Text = "Xóa",
                UseColumnTextForButtonValue = true,
            };

            guna2DataGridView1.Columns.Add(btnColumn);
           
        }

        private void DoAction(object sender, DataGridViewCellEventArgs e)
        {
            // get selected row
            DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];
            if (selectedRow != null && e.ColumnIndex == guna2DataGridView1.Columns["view"].Index) {
                Models.BaiBao selectedData = (Models.BaiBao)selectedRow.DataBoundItem;

                MessageBox.Show($"ID: {selectedData.ID}\nTên bài báo: {selectedData.TenBaiBao}\nNgày nộp: {selectedData.NgayNop}\nNgày xử lý: {selectedData.NgayXuLy}\nTrạng thái: {selectedData.TrangThai}");
            }
            if (selectedRow != null && e.ColumnIndex == guna2DataGridView1.Columns["edit"].Index)
            {
                Models.BaiBao selectedData = (Models.BaiBao)selectedRow.DataBoundItem;

                MessageBox.Show($"ID: {selectedData.ID}\nTên bài báo: {selectedData.TenBaiBao}\nNgày nộp: {selectedData.NgayNop}\nNgày xử lý: {selectedData.NgayXuLy}\nTrạng thái: {selectedData.TrangThai}");
            }
            if (selectedRow != null && e.ColumnIndex == guna2DataGridView1.Columns["delete"].Index)
            {
                Models.BaiBao selectedData = (Models.BaiBao)selectedRow.DataBoundItem;

                MessageBox.Show($"ID: {selectedData.ID}\nTên bài báo: {selectedData.TenBaiBao}\nNgày nộp: {selectedData.NgayNop}\nNgày xử lý: {selectedData.NgayXuLy}\nTrạng thái: {selectedData.TrangThai}");

                guna2DataGridView1.Rows.RemoveAt(e.RowIndex);
            }

            guna2DataGridView1.Update();
        }
    }
}
