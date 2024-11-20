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
    public partial class SearchBar : UserControl
    {
        private string searchKey = "";
        public event EventHandler Search;

        public SearchBar()
        {
            InitializeComponent();
            LoadGiangVienInfo();
        }

        public string SearchKey { get => searchKey; set => searchKey = value; }

        private void LoadGiangVienInfo()
        {
            DataRow dt = BUS_GiangVien.Instance.GetGiangVienInfoById(AccountSession.Id);
            label3.Text = dt["HoTenGV"].ToString();
            label4.Text = dt["HocVi"].ToString();
            pictureBox4.Image = Image.FromStream(new System.IO.MemoryStream((byte[])dt["ADD"]));
            // scale image
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Do_Search(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                searchKey = "";
                return;
            }

            searchKey = txtSearch.Text;
            // invoke event for parent containter to handle search
            OnSearch(new EventArgs());
        }

        protected virtual void OnSearch(EventArgs e)
        {
            EventHandler handler = Search;
            handler?.Invoke(this, e);
        }

    }
}
