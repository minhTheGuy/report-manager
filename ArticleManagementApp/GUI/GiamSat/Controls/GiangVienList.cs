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
using ArticleManagementApp.GUI.Components;
using ArticleManagementApp.GUI.GiangVien.Controls;

namespace ArticleManagementApp.GUI.GiamSat.Controls
{
    public partial class GiangVienList : UserControl
    {
        private GiamSatSearchBar searchBar;

        public GiangVienList()
        {
            InitializeComponent();

            searchBar = new GiamSatSearchBar();
            searchBar.Dock = DockStyle.Fill;
            searchBarContainer.Controls.Add(searchBar);

            dashboardContainer.Controls.Add(new GiamSatDashboard());
            LoadGrid();
        }

        private void LoadGrid()
        {
            // filter reports by TrangThai
            List<Models.GiangVien> list = BUS_GiamSat.Instance.GetGiangVienList();

            listGiangVien.DataSource = list;
        }
        private void Show_Info(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != e.RowIndex - 1 && e.ColumnIndex == 0)
            {
                // get id of selected row
                int id = int.Parse(listGiangVien.Rows[e.RowIndex].Cells[1].Value.ToString());
                this.Controls.Clear();
                this.Controls.Add(new GiamSatAccountInfo("giangVien", id));
            }
        }
    }
}
